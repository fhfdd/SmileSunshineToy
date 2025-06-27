using System;
using System.Data;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class InvProduct : BaseForm
    {
        private readonly DataGridManager _dataManager;

        public InvProduct()
        {
            InitializeComponent();

            // 初始化DataGridManager
            _dataManager = new DataGridManager("product", "ProductID", "PROD");
            _dataManager.SetConnectionString(Configuration.ConnectionString);

            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            // 配置DataGridView属性
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = false;

            // 清除现有列
            dataGridView1.Columns.Clear();

            // 添加自定义列
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "产品ID",
                Name = "ProductID",
                ReadOnly = true,
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "产品名称",
                Name = "Name",
                Width = 180
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "描述",
                Name = "Description",
                Width = 250
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "价格",
                Name = "Price",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockQuantity",
                HeaderText = "库存数量",
                Name = "StockQuantity",
                Width = 120
            });

            // 设置数据源
            dataGridView1.DataSource = _dataManager.DataTable;

            // 初始化搜索条件
            filterComboBox.Items.AddRange(new string[] {
                "ProductID",
                "Name",
                "Description"
            });
            filterComboBox.SelectedIndex = 0;
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

        // 添加产品
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.AddRecord(true))
                {
                    dataGridView1.Refresh();
                    FormNavigationManager.ShowInformation("已添加新产品记录");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"添加记录失败: {ex.Message}");
            }
        }

        // 删除产品
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowInformation("请选择要删除的记录");
                return;
            }

            if (FormNavigationManager.ShowConfirmation("确定要删除选中的产品记录吗？"))
            {
                try
                {
                    if (_dataManager.DeleteRecord(dataGridView1.SelectedRows))
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

        // 保存更改
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("数据保存成功");
                    LoadData(); // 刷新数据
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

        // 取消更改
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (FormNavigationManager.ShowConfirmation("确定要放弃所有未保存的更改吗？"))
            {
                _dataManager.DataTable.RejectChanges();
                dataGridView1.Refresh();
            }
        }

        // 搜索产品
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
                    filterComboBox.SelectedItem?.ToString() ?? "Name"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"搜索失败: {ex.Message}");
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
                UserSession.UserID = null;
                UserSession.UserName = null;
                UserSession.Role = UserRole.None;
                FormNavigationManager.NavigateToForm(this, typeof(Login), true);
            }
        }

        private void btn_home_Click(object sender, EventArgs e) =>
              FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));
        private void btn_user_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));

        private void btn_sub1_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvProduct));

        private void btn_sub2_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvMaterial));

        private void btn_sub3_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvWarehouse));

        // 空事件处理器
        private void InvProduct_Load(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
    }
}