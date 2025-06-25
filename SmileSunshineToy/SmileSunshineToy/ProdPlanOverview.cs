using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmileSunshineToy.Utilities;

namespace SmileSunshineToy
{
    public partial class ProdPlanOverview : DataGridViewForm
    {
        private bool userHasManuallySelectedOrder = false;
        private bool userHasManuallySelectedProduct = false;
        private ProductImageHelper _imageHelper;
        private FileUploadManager _fileUploadManager;
        private string originalPlanID = "";
        private DateTime? originalStartDate;
        private DateTime? originalEndDate;
        private string originalStatus = "";
        private string originalOrderId = "";
        private string originalProductId = "";

        public ProdPlanOverview() : base()
        {
            InitializeComponent();

            _imageHelper = new ProductImageHelper(ConnectionString);
            _fileUploadManager = new FileUploadManager(ConnectionString);

            base.TableName = "productionplan";
            base.PrimaryKey = "planID";
            base.DataGridView = dataGridView1;
            base.FilterComboBox = filterComboBox;
            base.SearchTextBox = txtSearch;
            base.AddButton = btnAdd;
            base.SaveButton = btnSave;
            base.CancelButton = btnCancel;
            base.SearchButton = btnSearch;

            filterComboBox.Items.AddRange(new[] { "planID", "startDate", "EndDate" });
            coboStatus.Items.AddRange(new[] { "pending", "OnHold", "Completed" });
            orderID.Items.AddRange(new[] { "Order ID", "Order Name" });
            productID.Items.AddRange(new[] { "Product ID", "Product Name" });

            filterComboBox.SelectedIndex = 0;
            coboStatus.SelectedIndex = 0;
            orderID.SelectedIndex = 0;
            productID.SelectedIndex = 0;

            LoadData();
        }

        public override void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString + ";Convert Zero Datetime=True;"))
                {
                    conn.Open();
                    DataAdapter = new MySqlDataAdapter($"SELECT * FROM `{TableName}`", conn);

                    DataTable.Clear();
                    DataAdapter.Fill(DataTable);

                    foreach (DataRow row in DataTable.Rows)
                    {
                        if (row["StartDate"] == DBNull.Value)
                            row["StartDate"] = DateTime.MinValue;

                        if (row["EndDate"] == DBNull.Value || row["EndDate"].ToString() == "0000-00-00")
                            row["EndDate"] = DateTime.MinValue;
                    }

                    DataGridView.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data load failed: {ex.Message}");
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
        private void cancelBtn_Click(object sender, EventArgs e) => CancelChanges();
        private void saveBtn_Click(object sender, EventArgs e) => SaveChanges();
        private void addBtn_Click(object sender, EventArgs e) => AddRecord();
        private void searchBtn_Click(object sender, EventArgs e) => SearchRecords();
        private void txtPlanID_TextChanged(object sender, EventArgs e) { }
        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtPlanID.Text = selectedRow.Cells["PlanID"].Value?.ToString() ?? "";

                if (selectedRow.Cells["StartDate"].Value is DateTime startDate)
                    dpStartDate.Value = startDate;

                if (selectedRow.Cells["EndDate"].Value is DateTime endDate)
                    dpEndDate.Value = endDate;

                coboStatus.Text = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                txtOrder.Text = selectedRow.Cells["OrderID"].Value?.ToString() ?? "";
                txtProd.Text = selectedRow.Cells["ProductID"].Value?.ToString() ?? "";

                LoadGridData(orderGridView, "order", !string.IsNullOrEmpty(txtOrder.Text) ? txtOrder.Text : null);
                LoadGridData(productGridView, "product", !string.IsNullOrEmpty(txtProd.Text) ? txtProd.Text : null);
            }
            else
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
                DataRow row = DataTable.Rows[dataGridView1.SelectedRows[0].Index];
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

        public override void AddRecord()
        {
            using (var dialog = new ProdPlanAdd(ConnectionString))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DataRow newRow = DataTable.NewRow();
                    newRow["StartDate"] = dialog.StartDate;
                    newRow["EndDate"] = dialog.EndDate;
                    newRow["Status"] = dialog.Status;
                    newRow["OrderID"] = dialog.OrderID;
                    newRow["ProductID"] = dialog.ProductID;
                    DataTable.Rows.Add(newRow);
                    DataGridView.Refresh();
                }
            }
        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                e.ToolTipText = "Double Click See Detail";
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string planId = row.Cells["PlanID"].Value?.ToString();

                DateTime startDate = row.Cells["StartDate"].Value is DateTime start ? start : dpStartDate.MinDate;
                DateTime endDate = row.Cells["EndDate"].Value is DateTime end ? end : dpEndDate.MinDate;

                new ProdPlanAdd(
                    planId,
                    startDate,
                    endDate,
                    row.Cells["Status"].Value?.ToString(),
                    row.Cells["OrderID"].Value?.ToString(),
                    row.Cells["ProductID"].Value?.ToString()
                ).ShowDialog();
            }
        }

        private void productGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productGridView.Rows[e.RowIndex];
                string productId = row.Cells["productID"].Value?.ToString(); // 直接获取字符串值
                string productName = row.Cells["Name"].Value?.ToString() ?? "Unknown";
                string description = row.Cells["description"].Value?.ToString() ?? "";

                var detailForm = new ProductDetailForm(
                    productId,
                    productName,
                    description,
                    _fileUploadManager,
                    _imageHelper
                );

                detailForm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) => toolStripLabel1.Text = DateTime.Now.ToString();
        private void export_Click(object sender, EventArgs e) => TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
    }
}