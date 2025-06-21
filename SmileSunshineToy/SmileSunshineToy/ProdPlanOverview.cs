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
    public partial class ProdPlanOverview : DataGridViewForm
    {
        public ProdPlanOverview(): base()
        {
            InitializeComponent();

            base.TableName = "productionplan";
            base.PrimaryKey = "planID";
            base.DataGridView = dataGridView1;
            base.FilterComboBox = filterComboBox;
            base.SearchTextBox = txtSearch;
            base.AddButton = btnAdd;
            base.DeleteButton = btnDelete;
            base.SaveButton = btnSave;
            base.CancelButton = btnCancel;
            base.SearchButton = btnSearch;


            filterComboBox.Items.Add("planID");
            filterComboBox.Items.Add("startDate");
            filterComboBox.Items.Add("EndDate");
            filterComboBox.SelectedIndex = 0;

            LoadData();

        }

        //public override void SaveChanges()
        //{
        //    if (dataGridView1.SelectedRows.Count == 1)
        //    {
        //        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

        //        selectedRow.Cells["PlanID"].Value = txtPlanID.Text;
        //        selectedRow.Cells["StartDate"].Value = txtStartDate.Text;
        //        selectedRow.Cells["EndDate"].Value = txtEndDate.Text;
        //        selectedRow.Cells["Status"].Value = txtStatus.Text;
        //        selectedRow.Cells["order_id"].Value = orderID.Text;
        //    }
        //    base.SaveChanges();
        //}


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
        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { this.Close(); new Login().Show(); } }
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
                string orderId = selectedRow.Cells["order_id"].Value?.ToString() ?? "";
                txtPlanID.Text = selectedRow.Cells["PlanID"].Value?.ToString() ?? "";
                object startDateValue = selectedRow.Cells["StartDate"].Value;
                if (startDateValue != DBNull.Value && startDateValue is DateTime)
                    dpStartDate.Value = (DateTime)startDateValue;
                object endDateValue = selectedRow.Cells["EndDate"].Value;
                if (endDateValue != DBNull.Value && endDateValue is DateTime)
                    dpEndDate.Value = (DateTime)endDateValue;
                txtStatus.Text = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                orderID.Text = selectedRow.Cells["order_id"].Value?.ToString() ?? "";
                productID.Text = selectedRow.Cells["product_id"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(productID.Text))
                {
                    LoadGridData(orderGridView, "order", orderID.Text);
                }
                else
                {
                    orderGridView.DataSource = null;               
                }
 
                if (!string.IsNullOrEmpty(productID.Text))
                {
                    LoadGridData(productGridView, "product", productID.Text);
                }
                else
                {
                    orderGridView.DataSource = null;
                }
            }
            else
            {
                txtPlanID.Text = "";
                dpStartDate.Text = "";
                dpEndDate.Text = "";
                txtStatus.Text = "";
                orderID.Text = "";
                productID.Text = "";
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
                if (txtStatus.Text != originalStatus) { row["Status"] = txtStatus.Text; hasChange = true; }
                if (orderID.Text != originalOrderId) { row["order_id"] = orderID.Text; hasChange = true; }
                
                string newProductId = productID.Text.Trim();
                if (newProductId != originalProductId) {
                    row["product_id"] = string.IsNullOrEmpty(newProductId) ? (object)DBNull.Value : int.Parse(newProductId);
                    hasChange = true;
                }


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
    }
}
