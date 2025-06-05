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




    }
}

