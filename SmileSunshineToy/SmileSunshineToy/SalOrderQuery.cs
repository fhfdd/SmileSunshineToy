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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("load data fail: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                SalDetail sal_detail = new SalDetail(orderId);
                sal_detail.ShowDialog(); 
            }
        }
    }
}
