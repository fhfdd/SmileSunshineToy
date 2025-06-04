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
    public partial class SalDetail : Form
    {

        private string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
        private int _orderId;

        public SalDetail()
        {
            InitializeComponent();


        }

        public SalDetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            LoadDetailData(orderId);
            LoadCustomerData(orderId);
            LoadProductData(orderId);
        }

        private void LoadDetailData(int orderId)
        {
            string query = "SELECT * FROM `order` WHERE OrderID = @OrderID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            orderID_text.Text = reader["OrderID"].ToString();
                            signDate.Text = reader["OrderDate"].ToString();

                        }
                        else
                        {
                            MessageBox.Show($"未找到订单 #{orderId} 的数据");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载详情失败: {ex.Message}");
                }
            }
        }

        private void LoadCustomerData(int orderId)
        {
            string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            string query = "SELECT * FROM `customer`";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable("customer");

                    adapter.Fill(dataTable);

                    customerGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }
        }

        private void LoadProductData(int orderId)
        {
            string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            string query = "SELECT * FROM `product`";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable("product");

                    adapter.Fill(dataTable);

                    customerGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }
        }


        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancel(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void productionGrid(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalDetail_Load_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            string CusQuery = "SELECT * FROM `customer`";
            string ProdQuery = "SELECT * FROM `product`";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(CusQuery, connection);

                    DataTable dataTable = new DataTable("customer");

                    adapter.Fill(dataTable);

                    productGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(ProdQuery, connection);

                    DataTable dataTable = new DataTable("product");

                    adapter.Fill(dataTable);

                    productGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }


        }
    }
}
