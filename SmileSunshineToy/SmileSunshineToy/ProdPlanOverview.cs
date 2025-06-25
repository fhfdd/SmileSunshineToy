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
using SmileSunshineToy.Utilities;

namespace SmileSunshineToy
{

    public partial class ProdPlanOverview : DataGridViewForm
    {   
        private bool userHasManuallySelectedOrder = false;
        private bool userHasManuallySelectedProduct = false;
        public ProdPlanOverview(): base()
        { 
            InitializeComponent();

            base.TableName = "productionplan";
            base.PrimaryKey = "planID";
            base.DataGridView = dataGridView1;
            base.FilterComboBox = filterComboBox;
            base.SearchTextBox = txtSearch;
            base.AddButton = btnAdd;
            base.SaveButton = btnSave;
            base.CancelButton = btnCancel;
            base.SearchButton = btnSearch;


            filterComboBox.Items.Add("planID");
            filterComboBox.Items.Add("startDate");
            filterComboBox.Items.Add("EndDate");
            filterComboBox.SelectedIndex = 0;

            coboStatus.Items.Add("pending");
            coboStatus.Items.Add("OnHold");
            coboStatus.Items.Add("EndDate");
            coboStatus.SelectedIndex = 0;

            orderID.Items.Add("Order ID");
            orderID.Items.Add("Order Name");
            orderID.SelectedIndex = 0;

            productID.Items.Add("Product ID");
            productID.Items.Add("Product Name");
            productID.SelectedIndex = 0;

            LoadData();
        }


    private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ProdPlanOverview_Load(object sender, EventArgs e)
        {

        }

        private void btn_inv_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void order_Click(object sender, EventArgs e) { new SalOrderQuery().Show(); this.Hide(); }
        private void btn_person_Click(object sender, EventArgs e) { new PerCusOverview().Show(); this.Hide(); }
        private void btn_proc_Click(object sender, EventArgs e) { new ProcOverview().Show(); this.Hide(); }
        private void btn_log_Click(object sender, EventArgs e) { new LoOverview().Show(); this.Hide(); }
        private void btn_prod_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_fin_Click(object sender, EventArgs e) { new FinPayOverview().Show(); this.Hide(); }
        private void btn_rd_Click(object sender, EventArgs e) { new RDdash().Show(); this.Hide(); }
        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { new Login().Show(); this.Hide(); } }
        private void btn_home_Click(object sender, EventArgs e) { this.Show(); this.Activate(); }
        private void btn_fin_Click_1(object sender, EventArgs e) { FinPayOverview finPayForm = new FinPayOverview(); finPayForm.Show(); this.Hide(); }
        private void btn_user_Click(object sender, EventArgs e) { new UserProfileForm().Show(); this.Hide(); }
        private void btn_sub1_Click(object sender, EventArgs e) { new ProdPlanOverview().Show(); this.Hide(); }
        private void btn_sub2_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_sub3_Click(object sender, EventArgs e) { new InvWarehouse().Show(); this.Hide(); }

        private void addBtn_Click(object sender, EventArgs e) => AddRecord();
        private void deleteBtn_Click(object sender, EventArgs e) => DeleteRecord();
        private void saveBtn_Click(object sender, EventArgs e) => SaveChanges();
        private void cancelBtn_Click(object sender, EventArgs e) => CancelChanges();
        private void searchBtn_Click(object sender, EventArgs e) => SearchRecords();

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtPlanID.Text = selectedRow.Cells["PlanID"].Value?.ToString() ?? "";
                object startDateValue = selectedRow.Cells["StartDate"].Value;
                if (startDateValue != DBNull.Value && startDateValue is DateTime)
                    dpStartDate.Value = (DateTime)startDateValue;
                object endDateValue = selectedRow.Cells["EndDate"].Value;
                if (endDateValue != DBNull.Value && endDateValue is DateTime)
                    dpEndDate.Value = (DateTime)endDateValue;
                coboStatus.Text = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                txtOrder.Text = selectedRow.Cells["OrderID"].Value?.ToString() ?? "";
                txtProd.Text = selectedRow.Cells["ProductID"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(orderID.Text))
                {
                    LoadGridData(orderGridView, "order", txtOrder.Text);
                }
                else
                {
                    LoadGridData(orderGridView, "order");
                }
 
                if (!string.IsNullOrEmpty(productID.Text))
                {
                    LoadGridData(productGridView, "product", txtProd.Text);
                }
                else
                {
                    LoadGridData(productGridView, "product");
                }
            }
            else
            {
                txtPlanID.Text = "";
                dpStartDate.Text = "";
                dpEndDate.Text = "";
                coboStatus.Text = "";
                txtOrder.Text = "";
                txtProd.Text = "";
                orderGridView.DataSource = null;
                productGridView.DataSource = null;

            }
        }

        private string originalPlanID = "";
        private DateTime? originalStartDate;
        private DateTime? originalEndDate;
        private string originalStatus = "";
        private string originalOrderId = "";
        private string originalProductId = "";


        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("please choose a record");
                return;
            }
            try
            {
                DataRow row = DataTable.Rows[dataGridView1.SelectedRows[0].Index];
                bool hasChange = false;

                if (txtPlanID.Text != originalPlanID) { row["PlanID"] = txtPlanID.Text; hasChange = true; }
                if (dpStartDate.Value != originalStartDate) { row["StartDate"] = dpStartDate.Value; hasChange = true; }
                if (dpEndDate.Value != originalEndDate) { row["EndDate"] = dpEndDate.Value; hasChange = true; }
                if (coboStatus.Text != originalStatus) { row["Status"] = coboStatus.Text; hasChange = true; }
                if (txtOrder.Text != originalOrderId) { row["OrderID"] = txtOrder.Text; hasChange = true; }
                if (txtProd.Text != originalProductId) { row["ProductID"] = txtProd.Text; hasChange = true; }


                if (hasChange)
                {
                    dataGridView1.Refresh();
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("未检测到修改，无需保存");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"编辑失败: {ex.Message}");
            }
        }



        private void productGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userHasManuallySelectedProduct && productGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = productGridView.SelectedRows[0];
                txtProd.Text = selectedRow.Cells["productID"].Value?.ToString() ?? "";
            }
        }

        private void orderGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userHasManuallySelectedOrder && orderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = orderGridView.SelectedRows[0];
                txtOrder.Text = selectedRow.Cells["orderID"].Value?.ToString() ?? "";
            }
        }

        private void orderGridView_MouseDown(object sender, MouseEventArgs e)
        {
            userHasManuallySelectedOrder = true;
        }

        private void productGridView_MouseDown(object sender, MouseEventArgs e)
        {
            userHasManuallySelectedProduct = true;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            userHasManuallySelectedOrder = false;
            userHasManuallySelectedProduct = false;
        }

        private void orderSearch_Click(object sender, EventArgs e)
        {
            string orderId = txtOrder.Text.Trim();
            base.LoadGridData(orderGridView, "order", "orderID", orderId);
        }

        private void prodsearch_Click(object sender, EventArgs e)
        {
            string productId = txtProd.Text.Trim();
            base.LoadGridData(productGridView, "product", "productID", productId);
        }

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
                e.ToolTipText = "Double Cick See Detail";
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string planId = row.Cells["PlanID"].Value?.ToString();

                DateTime startDate;
                if (row.Cells["StartDate"].Value != DBNull.Value && row.Cells["StartDate"].Value != null)
                {
                    if (DateTime.TryParse(row.Cells["StartDate"].Value.ToString(), out startDate))
                    {
                        startDate = DateTime.ParseExact(startDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", null);
                    }
                    else
                    {
                        startDate = dpStartDate.MinDate;
                    }
                }
                else
                {
                    startDate = dpStartDate.MinDate;
                }

                DateTime endDate;
                if (row.Cells["EndDate"].Value != DBNull.Value && row.Cells["EndDate"].Value != null)
                {
                    if (DateTime.TryParse(row.Cells["EndDate"].Value.ToString(), out endDate))
                    {
                        endDate = DateTime.ParseExact(endDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", null);
                    }
                    else
                    {
                        endDate = dpEndDate.MinDate;
                    }
                }
                else
                {
                    endDate = dpEndDate.MinDate;
                }

                string status = row.Cells["Status"].Value?.ToString();
                string orderId = row.Cells["OrderID"].Value?.ToString();
                string productId = row.Cells["ProductID"].Value?.ToString();

                var detailForm = new ProdPlanAdd(
                    planId, startDate, endDate, status,
                    orderId,
                    productId
                );
                detailForm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = System.DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPlanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
        }

        private void productGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridViewImageHelper.ShowSelectedRowImage(
                dataGridView1,
                "ImagePath",  // 或您实际的图片列名
                "ProductID",
                "ProductName",
                "Price"
            );
        }
    }
}
