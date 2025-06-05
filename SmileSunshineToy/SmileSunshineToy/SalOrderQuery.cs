using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy
{
    public partial class SalOrderQuery : Form
    {
        public SalOrderQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to sign out?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void SalOrderQuery_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            string query = "SELECT * FROM `order`";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable("order");

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    filterComboBox.Items.Clear();
                    filterComboBox.Items.Add("OrderID");
                    filterComboBox.Items.Add("Status");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }

        }




        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void delect_col_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // 1. 先创建事务对象
                MySqlTransaction trans = connection.BeginTransaction();
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.Transaction = trans; // 关联事务

                    // 2. 添加具体的删除 SQL 语句，这里假设要删除 order 表数据，根据 OrderID 删除
                    cmd.CommandText = "DELETE FROM `order` WHERE OrderID = @OrderID";
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow) // 跳过新增行（如果有）
                        {
                            int orderId = Convert.ToInt32(row.Cells[1].Value); // 假设 OrderID 在第 2 列（索引 1）
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@OrderID", orderId);
                            cmd.ExecuteNonQuery();
                            dataGridView1.Rows.Remove(row); // 从 DataGridView 中移除该行
                        }
                    }

                    trans.Commit(); // 用事务对象提交
                    MessageBox.Show("删除成功！");
                }
                catch (Exception ex)
                {
                    trans.Rollback(); // 失败回滚
                    MessageBox.Show($"删除失败：{ex.Message}");
                }
            }
        }
    }

}

