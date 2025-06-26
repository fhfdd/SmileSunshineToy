using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public class DataGridViewForm : BaseDataForm
    {
        protected string IDPrefix { get; set; }
        protected TextBox IDTextBox { get; set; }
        protected bool AutoGenerateID { get; set; } = true;
        protected string ConnectionString { get; set; } = "Server=localhost;Database=test;Uid=root;Pwd=;";
        protected DataTable DataTable { get; set; } = new DataTable();
        protected MySqlDataAdapter DataAdapter { get; set; }
        protected string TableName { get; set; }
        protected string PrimaryKey { get; set; }
        protected DataGridView DataGridView { get; set; }
        protected ComboBox FilterComboBox { get; set; }
        protected TextBox SearchTextBox { get; set; }
        protected Button AddButton { get; set; }
        protected Button DeleteButton { get; set; }
        protected Button SaveButton { get; set; }
        protected Button CancelButton { get; set; }
        protected Button SearchButton { get; set; }

        protected virtual void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "DataGridViewForm";
            this.Load += DataGridViewForm_Load;
            this.ResumeLayout(false);
        }

        public virtual void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    DataAdapter = new MySqlDataAdapter($"SELECT * FROM `{TableName}`", conn);
                    DataTable.Clear();
                    DataAdapter.Fill(DataTable);
                    DataGridView.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据加载失败: {ex.Message}", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void AddRecord()
        {
            try
            {
                DataRow newRow = DataTable.NewRow();
                DataTable.Rows.Add(newRow);
                if (DataGridView.Rows.Count > 0 && DataGridView.Columns.Count > 1)
                {
                    DataGridView.CurrentCell = DataGridView.Rows[DataGridView.Rows.Count - 1].Cells[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加记录失败: {ex.Message}", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void DeleteRecord()
        {
            if (DataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("确认删除选中的记录?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in DataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            DataTable.Rows[row.Index].Delete();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"删除记录失败: {ex.Message}", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public virtual void CancelChanges()
        {
            if (MessageBox.Show("确定放弃所有更改?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadData();
            }
        }

        public virtual void SearchRecords()
        {
            string searchText = SearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText) || FilterComboBox.SelectedIndex < 0)
            {
                LoadData();
                return;
            }

            string selectedColumn = FilterComboBox.SelectedItem.ToString();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {TableName} WHERE {selectedColumn} LIKE @search";
                    DataAdapter = new MySqlDataAdapter(query, conn);
                    DataAdapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchText}%");
                    DataTable.Clear();
                    DataAdapter.Fill(DataTable);
                    DataGridView.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索记录失败: {ex.Message}", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadData();
            }
        }

        protected void LoadGridData(DataGridView targetGrid, string tableName, string idColumn = null, object idValue = null)
        {
            try
            {
                string query = $"SELECT * FROM `{tableName}`";
                if (!string.IsNullOrEmpty(idColumn) && idValue != null)
                {
                    query += $" WHERE {idColumn} = @id";
                }

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(idColumn) && idValue != null)
                    {
                        cmd.Parameters.AddWithValue("@id", idValue);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    targetGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载数据失败: {ex.Message}", "系统错误");
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (AutoGenerateID && IDTextBox != null && !string.IsNullOrEmpty(IDPrefix))
            {
                IDTextBox.ReadOnly = true;
                string newID = GenerateSystemID(IDPrefix, TableName, PrimaryKey);
                IDTextBox.Text = newID;
            }
        }
    }
}