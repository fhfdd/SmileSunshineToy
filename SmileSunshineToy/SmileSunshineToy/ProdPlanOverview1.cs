using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy
{
    public partial class ProdPlanOverview1 : Form
    {
        private string ConnectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
        private DataTable dataTable = new DataTable();

        public ProdPlanOverview1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeNavigationPanel();
            InitializeDateTimeDisplay();
            InitializeMainControls();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            // 设置DataGridView列名与数据库一致
            dataTable.Columns.Add("planID", typeof(string));
            dataTable.Columns.Add("startDate", typeof(DateTime));
            dataTable.Columns.Add("endDate", typeof(DateTime));
            dataTable.Columns.Add("status", typeof(string));
            dataTable.Columns.Add("orderID", typeof(string));
            dataTable.Columns.Add("productID", typeof(string));

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
        }

        private void InitializeNavigationPanel()
        {
            // 导航栏样式
            panelNav.BackColor = Color.FromArgb(255, 240, 200); // 浅橙色

            // 初始化导航栏按钮
            btnHome = CreateNavButton("Home", 10, 50);
            btnSaleOrder = CreateNavButton("Sale Order", 10, 100);
            btnRD = CreateNavButton("R&D", 10, 150);
            btnFinancial = CreateNavButton("Financial", 10, 200);
            btnProduction = CreateNavButton("Production", 10, 250);
            btnLogistics = CreateNavButton("Logistics", 10, 300);
            btnProcurement = CreateNavButton("Procurement", 10, 350);
            btnPersonnel = CreateNavButton("Personnel", 10, 400);
            btnInventory = CreateNavButton("Inventory", 10, 450);
        }

        private void InitializeDateTimeDisplay()
        {
            // 时间显示
            lblDateTime.Font = new Font("Arial", 10);
            lblDateTime.Text = DateTime.Now.ToString("HH:mm:ss, yyyy-MM-dd");

            // 定时器
            timer1.Interval = 1000;
            timer1.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("HH:mm:ss, yyyy-MM-dd");
            timer1.Start();
        }

        private void InitializeMainControls()
        {
            // 主面板样式
            panelMain.BackColor = Color.White;

            // Plan ID 区域
            txtPlanID.Location = new Point(20, 50);
            txtPlanID.Size = new Size(150, 25);

            // Status 下拉框
            coboStatus.Location = new Point(200, 50);
            coboStatus.Size = new Size(150, 25);
            coboStatus.Items.AddRange(new[] { "Pending", "Processing", "Completed" });

            // Search 按钮
            btnSearch.Location = new Point(370, 50);
            btnSearch.Size = new Size(80, 25);
            btnSearch.Text = "Search";
            btnSearch.BackColor = Color.LightGray;

            // Order ID 区域
            txtOrderID.Location = new Point(20, 100);
            txtOrderID.Size = new Size(150, 25);
            btnOrderSearch.Location = new Point(180, 100);
            btnOrderSearch.Size = new Size(80, 25);
            btnOrderSearch.Text = "Search";
            btnOrderSearch.BackColor = Color.LightGray;

            // 日期选择器
            dpStartDate.Location = new Point(20, 150);
            dpStartDate.Size = new Size(150, 25);
            dpStartDate.Format = DateTimePickerFormat.Short;

            dpEndDate.Location = new Point(200, 150);
            dpEndDate.Size = new Size(150, 25);
            dpEndDate.Format = DateTimePickerFormat.Short;

            // Product ID 区域
            txtProductID.Location = new Point(20, 200);
            txtProductID.Size = new Size(150, 25);
            btnProductSearch.Location = new Point(180, 200);
            btnProductSearch.Size = new Size(80, 25);
            btnProductSearch.Text = "Search";
            btnProductSearch.BackColor = Color.LightGray;

            // 操作按钮
            btnAdd.Location = new Point(20, 250);
            btnAdd.Size = new Size(80, 30);
            btnAdd.Text = "ADD";
            btnAdd.BackColor = Color.LightGray;

            btnCancel.Location = new Point(120, 250);
            btnCancel.Size = new Size(80, 30);
            btnCancel.Text = "Cancel";
            btnCancel.BackColor = Color.LightGray;

            btnSave.Location = new Point(220, 250);
            btnSave.Size = new Size(80, 30);
            btnSave.Text = "Save";
            btnSave.BackColor = Color.LightGray;

            btnExport.Location = new Point(320, 250);
            btnExport.Size = new Size(80, 30);
            btnExport.Text = "Export";
            btnExport.BackColor = Color.LightGray;

            // DataGridView 位置
            dataGridView1.Location = new Point(20, 300);
            dataGridView1.Size = new Size(700, 400);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的计划");
                return;
            }

            if (MessageBox.Show("确认删除选中的计划吗？", "删除确认",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string planID = dataGridView1.SelectedRows[0].Cells["planID"].Value.ToString();

                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        new MySqlCommand($"DELETE FROM productionplan WHERE planID='{planID}'", conn)
                            .ExecuteNonQuery();

                        // 从DataTable移除
                        DataRow[] rows = dataTable.Select($"planID='{planID}'");
                        foreach (DataRow row in rows)
                        {
                            dataTable.Rows.Remove(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"删除失败: {ex.Message}");
                }
            }
        }

        private Button CreateNavButton(string text, int x, int y)
        {
            var btn = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(120, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft
            };
            panelNav.Controls.Add(btn);
            return btn;
        }

        private void LoadData()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM productionplan", conn);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载数据失败: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newPlanID = $"PLAN-{DateTime.Now:yyyyMMdd}-{dataTable.Rows.Count + 1:000}";

            using (var addForm = new ProdPlanAdd(ConnectionString))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // 添加新行到DataTable
                    DataRow newRow = dataTable.NewRow();
                    newRow["planID"] = addForm.PlanID;
                    newRow["startDate"] = addForm.StartDate;
                    newRow["endDate"] = addForm.EndDate;
                    newRow["status"] = addForm.Status;
                    newRow["orderID"] = addForm.OrderID;
                    newRow["productID"] = addForm.ProductID;

                    dataTable.Rows.Add(newRow);

                    // 保存到数据库
                    SaveToDatabase(newRow);
                }
            }
        }

        private void SaveToDatabase(DataRow row)
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO productionplan (planID, startDate, endDate, status, orderID, productID) " +
                        "VALUES (@planID, @startDate, @endDate, @status, @orderID, @productID)", conn);

                    cmd.Parameters.AddWithValue("@planID", row["planID"]);
                    cmd.Parameters.AddWithValue("@startDate", row["startDate"]);
                    cmd.Parameters.AddWithValue("@endDate", row["endDate"]);
                    cmd.Parameters.AddWithValue("@status", row["status"]);
                    cmd.Parameters.AddWithValue("@orderID", row["orderID"]);
                    cmd.Parameters.AddWithValue("@productID", row["productID"]);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存到数据库失败: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 搜索功能实现
            string filter = $"planID LIKE '%{txtPlanID.Text}%' AND status LIKE '%{coboStatus.Text}%'";
            dataTable.DefaultView.RowFilter = filter;
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            // 订单搜索功能
            string orderId = txtOrderID.Text;
            if (!string.IsNullOrEmpty(orderId))
            {
                string filter = $"orderID LIKE '%{orderId}%'";
                dataTable.DefaultView.RowFilter = filter;
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            // 产品搜索功能
            string productId = txtProductID.Text;
            if (!string.IsNullOrEmpty(productId))
            {
                string filter = $"productID LIKE '%{productId}%'";
                dataTable.DefaultView.RowFilter = filter;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM productionplan", conn);
                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.Update(dataTable);
                    MessageBox.Show("数据保存成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败: {ex.Message}");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // 导出PDF功能
            MessageBox.Show("导出PDF功能");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData(); // 重新加载数据取消更改
        }
    }
}