using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing; // 新增命名空间

namespace SmileSunshineToy
{
    public partial class RD : Form
    {
        private DataTable dataTable;

        public RD()
        {
            InitializeComponent();
            BindData();
            InitializeEvents();
        }

        private void BindData()
        {
            dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[] {
                new DataColumn("project ID", typeof(string)),
                new DataColumn("project name", typeof(string)),
                new DataColumn("start date", typeof(DateTime)),
                new DataColumn("end Date", typeof(DateTime)),
                new DataColumn("manager ID", typeof(string)),
                new DataColumn("manager name", typeof(string)),
                new DataColumn("requirement", typeof(string)),
                new DataColumn("status", typeof(string))
            });

            // 模拟数据
            dataTable.Rows.Add("P001", "Project 1", DateTime.Now, DateTime.Now.AddDays(10), "M001", "Manager 1", "Req 1", "Pending");
            dataTable.Rows.Add("P002", "Project 2", DateTime.Now, DateTime.Now.AddDays(20), "M002", "Manager 2", "Req 2", "confirmed");

            dataGridView.DataSource = dataTable;
            SetStatusColors();
        }

        private void SetStatusColors()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string status = row.Cells["status"].Value.ToString();
                switch (status)
                {
                    case "Pending":
                        row.Cells["status"].Style.ForeColor = Color.Gray;
                        break;
                    case "confirmed":
                        row.Cells["status"].Style.ForeColor = Color.Green;
                        break;
                    case "shipped":
                        row.Cells["status"].Style.ForeColor = Color.Blue;
                        break;
                    case "completed":
                        row.Cells["status"].Style.ForeColor = Color.Green;
                        break;
                    case "canceled":
                        row.Cells["status"].Style.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void InitializeEvents()
        {
            searchButton.Click += (sender, e) =>
            {
                MessageBox.Show("Search functionality is not implemented yet.");
            };

            createProjectButton.Click += (sender, e) =>
            {
                MessageBox.Show("Create project functionality is not implemented yet.");
            };

            dataGridView.CellClick += (sender, e) =>
            {
                if (e.ColumnIndex == colDetailButton.Index)
                {
                    string projectID = dataGridView.Rows[e.RowIndex].Cells["project ID"].Value.ToString();
                    MessageBox.Show($"View details for project {projectID} (not implemented).");
                }
                else if (e.ColumnIndex == colDeleteButton.Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete this project?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string projectID = dataGridView.Rows[e.RowIndex].Cells["project ID"].Value.ToString();
                        MessageBox.Show($"Delete project {projectID} (not implemented).");
                    }
                }
            };
        }

        private void RD_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}