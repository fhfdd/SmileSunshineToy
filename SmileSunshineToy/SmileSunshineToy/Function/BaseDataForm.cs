using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public class BaseDataForm : Form
    {
        protected string IDPrefix { get; set; }
        protected TextBox IDTextBox { get; set; }
        protected bool AutoGenerateID { get; set; } = true;
        protected string ConnectionString { get; set; } = "Server=localhost;Database=test;Uid=root;Pwd=;";
        protected DataTable DataTable { get; set; } = new DataTable();
        protected MySqlDataAdapter DataAdapter { get; set; }
        protected string TableName { get; set; }
        protected string PrimaryKey { get; set; }

        protected virtual void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "BaseDataForm";
            this.ResumeLayout(false);
        }

        protected bool ValidateSystemID()
        {
            string id = IDTextBox.Text.Trim();
            if (string.IsNullOrEmpty(id)) return false;
            if (!id.StartsWith(IDPrefix)) return false;
            if (!id.Contains(DateTime.Now.ToString("yyyyMMdd"))) return false;
            return true;
        }

        public virtual void SaveChanges()
        {
            try
            {
                DataTable changes = DataTable.GetChanges();
                if (changes == null || changes.Rows.Count == 0)
                {
                    MessageBox.Show("没有需要保存的更改", "提示");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        string insertQuery = $"INSERT INTO {TableName} (PlanID, StartDate, EndDate, Status, OrderID, ProductID) VALUES (@PlanID, @StartDate, @EndDate, @Status, @OrderID, @ProductID)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn, trans);
                        insertCommand.Parameters.Add("@PlanID", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@StartDate", MySqlDbType.DateTime);
                        insertCommand.Parameters.Add("@EndDate", MySqlDbType.DateTime);
                        insertCommand.Parameters.Add("@Status", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@OrderID", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@ProductID", MySqlDbType.VarChar);

                        string updateQuery = $"UPDATE {TableName} SET StartDate = @StartDate, EndDate = @EndDate, Status = @Status, OrderID = @OrderID, ProductID = @ProductID WHERE PlanID = @PlanID";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn, trans);
                        updateCommand.Parameters.Add("@PlanID", MySqlDbType.VarChar);
                        updateCommand.Parameters.Add("@StartDate", MySqlDbType.DateTime);
                        updateCommand.Parameters.Add("@EndDate", MySqlDbType.DateTime);
                        updateCommand.Parameters.Add("@Status", MySqlDbType.VarChar);
                        updateCommand.Parameters.Add("@OrderID", MySqlDbType.VarChar);
                        updateCommand.Parameters.Add("@ProductID", MySqlDbType.VarChar);

                        string deleteQuery = $"DELETE FROM {TableName} WHERE PlanID = @PlanID";
                        MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn, trans);
                        deleteCommand.Parameters.Add("@PlanID", MySqlDbType.VarChar);

                        int rowsAffected = 0;

                        foreach (DataRow row in changes.Rows)
                        {
                            if (row.RowState == DataRowState.Added)
                            {
                                insertCommand.Parameters["@PlanID"].Value = row["PlanID"];
                                insertCommand.Parameters["@StartDate"].Value = row["StartDate"];
                                insertCommand.Parameters["@EndDate"].Value = row["EndDate"];
                                insertCommand.Parameters["@Status"].Value = row["Status"];
                                insertCommand.Parameters["@OrderID"].Value = row["OrderID"];
                                insertCommand.Parameters["@ProductID"].Value = row["ProductID"];
                                rowsAffected += insertCommand.ExecuteNonQuery();
                            }
                            else if (row.RowState == DataRowState.Modified)
                            {
                                updateCommand.Parameters["@PlanID"].Value = row["PlanID"];
                                updateCommand.Parameters["@StartDate"].Value = row["StartDate"];
                                updateCommand.Parameters["@EndDate"].Value = row["EndDate"];
                                updateCommand.Parameters["@Status"].Value = row["Status"];
                                updateCommand.Parameters["@OrderID"].Value = row["OrderID"];
                                updateCommand.Parameters["@ProductID"].Value = row["ProductID"];
                                rowsAffected += updateCommand.ExecuteNonQuery();
                            }
                            else if (row.RowState == DataRowState.Deleted)
                            {
                                deleteCommand.Parameters["@PlanID"].Value = row["PlanID", DataRowVersion.Original];
                                rowsAffected += deleteCommand.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        MessageBox.Show($"成功保存 {rowsAffected} 条记录", "成功");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存操作失败: {ex.Message}", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected string GenerateSystemID(string prefix, string tableName, string primaryKey)
        {
            try
            {
                string datePart = DateTime.Now.ToString("yyyyMMdd");
                string query = $"SELECT COUNT(*) FROM `{tableName}` WHERE `{primaryKey}` LIKE @Pattern";
                string pattern = $"{prefix}-{datePart}-%";

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Pattern", pattern);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return $"{prefix}-{datePart}-{(count + 1):D3}";
                }
            }
            catch
            {
                return $"{prefix}-{DateTime.Now:yyyyMMdd}-001";
            }
        }
    }
}