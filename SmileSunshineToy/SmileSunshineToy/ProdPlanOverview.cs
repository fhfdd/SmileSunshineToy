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
    public partial class ProdPlanOverview : Form
    {
        public ProdPlanOverview()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ProdPlanOverview_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            string query = "SELECT * FROM productionplan";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // 创建数据适配器
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    // 创建 DataTable
                    DataTable dataTable = new DataTable("productionplan");

                    // 填充数据
                    adapter.Fill(dataTable);

                    // 绑定到 DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }
        }


    }
}
