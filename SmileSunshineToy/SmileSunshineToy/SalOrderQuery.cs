using System;
using System.Data;
using System.Windows.Forms;
using SmileSunshineToy;

namespace SmileSunshineToy
{
    public partial class SalOrderQuery : BaseForm
    {
        private readonly DataGridManager _dataManager;

        public SalOrderQuery()
        {
            InitializeComponent();
            _dataManager = new DataGridManager("order", "OrderID", "ORD");
            _dataManager.SetConnectionString(Configuration.ConnectionString);
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = _dataManager.DataTable;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
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
                FormNavigationManager.ShowError($"加载订单数据失败: {ex.Message}");
            }
        }

        #region 菜单导航事件
        private void btn_fin_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));

        private void btn_rd_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(RDdash));

        private void logout_Click(object sender, EventArgs e)
        {
            if (FormNavigationManager.ConfirmLogout())
            {
                UserSession.UserID = null;
                UserSession.UserName = null;
                UserSession.Role = UserRole.None;
                FormNavigationManager.NavigateToForm(this, typeof(Login), true);
            }
        }

        private void order_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(SalOrderQuery));

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void btn_inv_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvMaterial));

        private void btn_person_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(PerCusOverview));

        private void btn_proc_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProcOverview));

        private void btn_log_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(LoOverview));

        private void btn_prod_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview));
        #endregion

        #region 数据操作事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.AddRecord(true))
                {
                    dataGridView1.Refresh();
                    FormNavigationManager.ShowInformation("已添加新订单记录");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"添加订单记录失败: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowInformation("请选择要删除的订单记录");
                return;
            }

            if (FormNavigationManager.ShowConfirmation("确定要删除选中的订单记录吗?"))
            {
                try
                {
                    if (_dataManager.DeleteRecord(dataGridView1.SelectedRows) &&
                        _dataManager.SaveChanges())
                    {
                        dataGridView1.Refresh();
                        FormNavigationManager.ShowInformation("订单记录删除成功");
                    }
                }
                catch (Exception ex)
                {
                    FormNavigationManager.ShowError($"删除订单记录失败: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("订单数据保存成功");
                }
                else
                {
                    FormNavigationManager.ShowInformation("没有需要保存的更改");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"保存订单数据失败: {ex.Message}");
            }
        }

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
                    filterComboBox.SelectedItem?.ToString() ?? "OrderID"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"搜索订单记录失败: {ex.Message}");
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
        }
        #endregion

        private void SalOrderQuery_Load(object sender, EventArgs e) { }
    }



    }
