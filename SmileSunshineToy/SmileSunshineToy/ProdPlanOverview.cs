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
                txtStartDate.Text = FormatDateForMySQL(startDateValue);
                object endDateValue = selectedRow.Cells["EndDate"].Value;
                txtEndDate.Text = FormatDateForMySQL(endDateValue);
                txtStatus.Text = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                orderID.Text = selectedRow.Cells["order_id"].Value?.ToString() ?? "";
                productID.Text = selectedRow.Cells["product_id"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(productID.Text))
                {
                    LoadGridData(orderGridView, "order", orderId);
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
                txtStartDate.Text = "";
                txtEndDate.Text = "";
                txtStatus.Text = "";
                orderID.Text = "";
                productID.Text = "";
                orderGridView.DataSource = null;
                productGridView.DataSource = null;

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("请先选择一个生产计划进行编辑", "提示",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 获取当前选中的行
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                // 使用文本框中的值更新数据行
                if (DataTable.Rows.Count > rowIndex)
                {
                    DataRow row = DataTable.Rows[rowIndex];

                    // 更新生产计划基本信息
                    row["PlanID"] = txtPlanID.Text;
                    row["StartDate"] = DateTime.Parse(txtStartDate.Text); // 根据实际类型调整
                    row["EndDate"] = DateTime.Parse(txtEndDate.Text);
                    row["Status"] = txtStatus.Text;

                    // 更新关联信息
                    row["order_id"] = orderID.Text;
                    row["product_id"] = productID.Text;

                    // 提交更改到数据库
                    base.SaveChanges();

                    // 刷新显示
                    dataGridView1.Refresh();

                    MessageBox.Show("生产计划更新成功!", "成功",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("日期格式不正确！请使用yyyy-MM-dd格式", "格式错误",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"编辑失败: {ex.Message}", "错误",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
