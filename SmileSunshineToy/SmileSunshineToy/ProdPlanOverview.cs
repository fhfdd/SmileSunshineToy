using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmileSunshineToy.Utilities;

namespace SmileSunshineToy
{
    public partial class ProdPlanOverview : BaseForm
    {
        private DataGridManager _dataManager;
        private bool userHasManuallySelectedOrder = false;
        private bool userHasManuallySelectedProduct = false;
        private ProductImageManager _imageManager;
        private string originalPlanID = "";
        private DateTime? originalStartDate;
        private DateTime? originalEndDate;
        private string originalStatus = "";
        private string originalOrderId = "";
        private string originalProductId = "";
        private bool _isDataValid;

        public ProdPlanOverview()
        {
            InitializeComponent();
            InitializeDataManager();
            InitializeUIComponents();
            LoadData();
        }

        private void InitializeDataManager()
        {
            _dataManager = new DataGridManager("productionplan", "planID", "PROD");
            _dataManager.SetConnectionString(Configuration.ConnectionString);
        }

        private void InitializeUIComponents()
        {
            _imageManager = new ProductImageManager(Configuration.ConnectionString);

            filterComboBox.Items.AddRange(new[] { "planID", "startDate", "EndDate" });
            coboStatus.Items.AddRange(new[] { "pending", "OnHold", "Completed" });
            orderID.Items.AddRange(new[] { "Order ID", "Order Name" });
            productID.Items.AddRange(new[] { "Product ID", "Product Name" });

            filterComboBox.SelectedIndex = 0;
            coboStatus.SelectedIndex = 0;
            orderID.SelectedIndex = 0;
            productID.SelectedIndex = 0;

            dataGridView1.DataSource = _dataManager.DataTable;
        }

        private void LoadData()
        {
            try
            {
                _dataManager.LoadData();
                foreach (DataRow row in _dataManager.DataTable.Rows)
                {
                    if (row["StartDate"] == DBNull.Value) row["StartDate"] = DateTime.MinValue;
                    if (row["EndDate"] == DBNull.Value) row["EndDate"] = DateTime.MinValue;
                    if (!IsOrderIdValid(row["OrderID"].ToString()))
                    {
                        row.SetColumnError("OrderID", "订单不存在");
                    }
                }
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data load failed: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (DialogResult == DialogResult.OK && !_isDataValid)
            {
                MessageBox.Show("Please save data first");
                e.Cancel = true;
            }
        }

        private void ProdPlanOverview_Load(object sender, EventArgs e) { }
        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { new Login().Show(); this.Hide(); } }
        private void btn_sub2_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_sub1_Click(object sender, EventArgs e) { new ProdPlanOverview().Show(); this.Hide(); }
        private void btn_user_Click(object sender, EventArgs e) { new UserProfileForm().Show(); this.Hide(); }
        private void btn_inv_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void btn_person_Click(object sender, EventArgs e) { new PerCusOverview().Show(); this.Hide(); }
        private void btn_proc_Click(object sender, EventArgs e) { new ProcOverview().Show(); this.Hide(); }
        private void btn_log_Click(object sender, EventArgs e) { new LoOverview().Show(); this.Hide(); }
        private void btn_prod_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_fin_Click(object sender, EventArgs e) { new FinPayOverview().Show(); this.Hide(); }
        private void btn_rd_Click(object sender, EventArgs e) { new RDdash().Show(); this.Hide(); }
        private void order_Click(object sender, EventArgs e) { new SalOrderQuery().Show(); this.Hide(); }
        private void btn_home_Click(object sender, EventArgs e) { this.Show(); this.Activate(); }
        private void cancelBtn_Click(object sender, EventArgs e) { LoadData(); }
        private void addBtn_Click(object sender, EventArgs e) { AddRecord(); }
        private void searchBtn_Click(object sender, EventArgs e) { SearchRecords(); }
        private void txtPlanID_TextChanged(object sender, EventArgs e) { }
        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // 检查订单ID是否存在
            if (!IsOrderIdValid(txtOrder.Text.Trim()))
            {
                MessageBox.Show("订单ID无效或不存在，请重新输入");
                return;
            }

            try
            {
                if (_dataManager.SaveChanges())
                {
                    MessageBox.Show("数据保存成功");
                    _isDataValid = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败: {ex.Message}");
            }
        }

        // 检查订单ID是否有效
        private bool IsOrderIdValid(string orderId)
        {
            using (var conn = new MySqlConnection(Configuration.ConnectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM `order` WHERE OrderID = @orderId", conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtPlanID.Text = selectedRow.Cells["PlanID"].Value?.ToString() ?? "";
                coboStatus.Text = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                txtOrder.Text = selectedRow.Cells["OrderID"].Value?.ToString() ?? "";
                txtProd.Text = selectedRow.Cells["ProductID"].Value?.ToString() ?? "";
                dpStartDate.Value = selectedRow.Cells["StartDate"].Value is DateTime startDate && startDate > DateTime.MinValue
                    ? startDate
                    : DateTime.Today;

                dpEndDate.Value = selectedRow.Cells["EndDate"].Value is DateTime endDate && endDate > DateTime.MinValue
                    ? endDate
                    : DateTime.Today.AddDays(7);

                LoadGridData(orderGridView, "order", !string.IsNullOrEmpty(txtOrder.Text) ? txtOrder.Text : null);
                LoadGridData(productGridView, "product", !string.IsNullOrEmpty(txtProd.Text) ? txtProd.Text : null);
            }
            else
            {
                ClearSelection();
            }
        }

        private void ClearSelection()
        {
            txtPlanID.Text = "";
            dpStartDate.Value = DateTime.Now;
            dpEndDate.Value = DateTime.Now;
            coboStatus.Text = "";
            txtOrder.Text = "";
            txtProd.Text = "";
            orderGridView.DataSource = null;
            productGridView.DataSource = null;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please choose a record");
                return;
            }

            try
            {
                DataRow row = _dataManager.DataTable.Rows[dataGridView1.SelectedRows[0].Index];
                bool hasChange = txtPlanID.Text != originalPlanID ||
                               dpStartDate.Value != originalStartDate ||
                               dpEndDate.Value != originalEndDate ||
                               coboStatus.Text != originalStatus ||
                               txtOrder.Text != originalOrderId ||
                               txtProd.Text != originalProductId;

                if (hasChange)
                {
                    row["PlanID"] = txtPlanID.Text;
                    row["StartDate"] = dpStartDate.Value;
                    row["EndDate"] = dpEndDate.Value;
                    row["Status"] = coboStatus.Text;
                    row["OrderID"] = txtOrder.Text;
                    row["ProductID"] = txtProd.Text;

                    dataGridView1.Refresh();
                    MessageBox.Show("Update successful!");
                }
                else
                {
                    MessageBox.Show("No changes detected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Edit failed: {ex.Message}");
            }
        }

        private void productGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userHasManuallySelectedProduct && productGridView.SelectedRows.Count == 1)
            {
                txtProd.Text = productGridView.SelectedRows[0].Cells["productID"].Value?.ToString() ?? "";
            }
        }

        private void orderGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userHasManuallySelectedOrder && orderGridView.SelectedRows.Count > 0)
            {
                txtOrder.Text = orderGridView.SelectedRows[0].Cells["orderID"].Value?.ToString() ?? "";
            }
        }

        private void orderGridView_MouseDown(object sender, MouseEventArgs e) => userHasManuallySelectedOrder = true;
        private void productGridView_MouseDown(object sender, MouseEventArgs e) => userHasManuallySelectedProduct = true;
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            userHasManuallySelectedOrder = false;
            userHasManuallySelectedProduct = false;
        }

        private void orderSearch_Click(object sender, EventArgs e) => LoadGridData(orderGridView, "order", "orderID", txtOrder.Text.Trim());
        private void prodsearch_Click(object sender, EventArgs e) => LoadGridData(productGridView, "product", "productID", txtProd.Text.Trim());

        private void AddRecord()
        {
            using (var dialog = new ProdPlanAdd(Configuration.ConnectionString))
            {
                if (dialog.ShowDialog() == DialogResult.OK && dialog.PlanData != null)
                {
                    DataRow newRow = _dataManager.DataTable.NewRow();
                    newRow["PlanID"] = dialog.PlanData["PlanID"];
                    newRow["StartDate"] = dialog.PlanData["StartDate"];
                    newRow["EndDate"] = dialog.PlanData["EndDate"];
                    newRow["Status"] = dialog.PlanData["Status"];
                    newRow["OrderID"] = dialog.PlanData["OrderID"];
                    newRow["ProductID"] = dialog.PlanData["ProductID"];
                    _dataManager.DataTable.Rows.Add(newRow);
                    dataGridView1.Refresh();
                }
            }
        }

        private void SearchRecords()
        {
            string searchText = txtSearch.Text.Trim();
            string selectedColumn = filterComboBox.SelectedItem?.ToString();
            dataGridView1.DataSource = _dataManager.SearchRecords(searchText, selectedColumn);
        }

        private void LoadGridData(DataGridView grid, string tableName, string idColumn = null, object idValue = null)
        {
            grid.DataSource = _dataManager.LoadGridData(tableName, idColumn, idValue);
        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0) e.ToolTipText = "Double Click See Detail";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                new ProdPlanAdd(
                    row.Cells["PlanID"].Value?.ToString(),
                    row.Cells["StartDate"].Value is DateTime start ? start : dpStartDate.MinDate,
                    row.Cells["EndDate"].Value is DateTime end ? end : dpEndDate.MinDate,
                    row.Cells["Status"].Value?.ToString(),
                    row.Cells["OrderID"].Value?.ToString(),
                    row.Cells["ProductID"].Value?.ToString(),
                    Configuration.ConnectionString
                ).ShowDialog();
            }
        }

        private void productGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productGridView.Rows[e.RowIndex];
                new ProductDetailForm(
                    row.Cells["productID"].Value?.ToString(),
                    row.Cells["Name"].Value?.ToString() ?? "Unknown",
                    row.Cells["description"].Value?.ToString() ?? ""
                ).ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) => toolStripLabel1.Text = DateTime.Now.ToString();
        private void export_Click(object sender, EventArgs e) => TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
    }
}