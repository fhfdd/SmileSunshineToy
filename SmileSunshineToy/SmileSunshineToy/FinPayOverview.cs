using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class FinPayOverview : Form
    {
        private readonly DataGridManager _dataManager;

        public FinPayOverview()
        {
            InitializeComponent();
            _dataManager = new DataGridManager("payment", "PaymentID", "PAY");
            _dataManager.SetConnectionString(Configuration.ConnectionString);
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = _dataManager.DataTable;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void LoadData()
        {
            try
            {
                _dataManager.LoadData();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"加载数据失败: {ex.Message}");
            }
        }

        // 使用FormNavigationManager进行导航
        private void btn_inv_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvMaterial));

        private void order_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(SalOrderQuery));

        private void btn_person_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(PerCusOverview));

        private void btn_proc_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProcOverview));

        private void btn_log_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(LoOverview));

        private void btn_prod_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview));

        private void btn_fin_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));

        private void btn_rd_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(RDdash));

        private void logout_Click(object sender, EventArgs e)
        {
            if (FormNavigationManager.ConfirmLogout())
            {
                // 清除用户会话
                UserSession.UserID = null;
                UserSession.UserName = null;
                UserSession.Role = UserRole.None;

                // 返回登录页面
                FormNavigationManager.NavigateToForm(this, typeof(Login), true);
            }
        }


        private void btn_home_Click(object sender, EventArgs e) =>
     FormNavigationManager.NavigateToForm(this, typeof(Dashboard));

        private void btn_user_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));

        private void btn_sub1_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));

        private void btn_sub2_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinReOverview));

        private void btn_sub3_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvWarehouse));

        // 添加新支付记录
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.AddRecord(true))
                {
                    dataGridView1.Refresh();
                    FormNavigationManager.ShowInformation("已添加新支付记录");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"添加记录失败: {ex.Message}");
            }
        }

        // 删除支付记录
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowInformation("请选择要删除的记录");
                return;
            }

            if (FormNavigationManager.ShowConfirmation("确定要删除选中的支付记录吗？"))
            {
                try
                {
                    if (_dataManager.DeleteRecord(dataGridView1.SelectedRows) &&
                        _dataManager.SaveChanges())
                    {
                        dataGridView1.Refresh();
                        FormNavigationManager.ShowInformation("删除成功");
                    }
                }
                catch (Exception ex)
                {
                    FormNavigationManager.ShowError($"删除失败: {ex.Message}");
                }
            }
        }

        // 保存所有更改
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("数据保存成功");
                }
                else
                {
                    FormNavigationManager.ShowInformation("没有需要保存的更改");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"保存失败: {ex.Message}");
            }
        }

        // 搜索支付记录
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadData();
                return;
            }

            try
            {
                dataGridView1.DataSource = _dataManager.SearchRecords(
                    txtSearch.Text,
                    filterComboBox.SelectedItem?.ToString() ?? "PaymentID"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"搜索失败: {ex.Message}");
            }
        }

        // 导出为PDF
        private void btnExport_Click(object sender, EventArgs e)
        {
            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
        }

        // 空事件处理器保持不变
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e) { }
        private void LeftToolStripPanel_Click(object sender, EventArgs e) { }
        private void RightToolStripPanel_Click(object sender, EventArgs e) { }
        private void TopToolStripPanel_Click(object sender, EventArgs e) { }
        private void BottomToolStripPanel_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void FinPayOverview_Load(object sender, EventArgs e) { }
            private void btn_product_Click(object sender, EventArgs e) =>
    FormNavigationManager.NavigateToForm(this, typeof(FinReOverview));

        private void btn_material_Click(object sender, EventArgs e) =>
      FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));
    }
}