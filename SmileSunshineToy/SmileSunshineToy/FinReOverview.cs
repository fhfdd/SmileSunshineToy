using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class FinReOverview : Form
    {
        private readonly DataGridManager _invoiceManager;
        private readonly DataGridManager _orderManager;
        private readonly DataGridManager _productManager;

        public FinReOverview()
        {
            InitializeComponent();

            // 初始化三个数据管理器
            _invoiceManager = new DataGridManager("invoice", "InvoiceID", "INV");
            _orderManager = new DataGridManager("order", "OrderID", "ORD");
            _productManager = new DataGridManager("product", "ProductID", "PROD");

            // 设置连接字符串
            _invoiceManager.SetConnectionString(Configuration.ConnectionString);
            _orderManager.SetConnectionString(Configuration.ConnectionString);
            _productManager.SetConnectionString(Configuration.ConnectionString);

            // 初始化数据网格
            InitializeDataGridViews();
            LoadData();

            // 初始化日期控件
            dpStartDate.Value = DateTime.Now;
            dpEndDate.Value = DateTime.Now.AddDays(30);

            // 初始化下拉框
            InitializeComboBoxes();
        }

        private void InitializeDataGridViews()
        {
            dataGridView1.DataSource = _invoiceManager.DataTable;
            orderGridView.DataSource = _orderManager.DataTable;
            productGridView.DataSource = _productManager.DataTable;

            dataGridView1.AutoGenerateColumns = true;
            orderGridView.AutoGenerateColumns = true;
            productGridView.AutoGenerateColumns = true;
        }

        private void InitializeComboBoxes()
        {
            // 初始化状态下拉框
            coboStatus.Items.AddRange(new object[] { "Pending", "Paid", "Overdue" });
            coboStatus.SelectedIndex = 0;

            // 初始化搜索条件下拉框
            filterComboBox.Items.AddRange(new object[] { "InvoiceID", "OrderID", "CustomerID", "TotalAmount" });
            filterComboBox.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                _invoiceManager.LoadData();
                _orderManager.LoadData();
                _productManager.LoadData();

                dataGridView1.Refresh();
                orderGridView.Refresh();
                productGridView.Refresh();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"加载数据失败: {ex.Message}");
            }
        }

        // 搜索发票记录
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _invoiceManager.LoadData();
                return;
            }

            try
            {
                dataGridView1.DataSource = _invoiceManager.SearchRecords(
                    txtSearch.Text,
                    filterComboBox.SelectedItem?.ToString() ?? "InvoiceID"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"搜索失败: {ex.Message}");
            }
        }

        // 添加新发票记录
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string newInvoiceId = _invoiceManager.GenerateSystemID();
                txtPlanID.Text = newInvoiceId;

                DataRow newRow = _invoiceManager.DataTable.NewRow();
                newRow["InvoiceID"] = newInvoiceId;
                newRow["InvoiceDate"] = dpStartDate.Value;
                newRow["Status"] = coboStatus.SelectedItem.ToString();

                _invoiceManager.DataTable.Rows.Add(newRow);
                dataGridView1.Refresh();

                FormNavigationManager.ShowInformation("已创建新发票记录");
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"添加记录失败: {ex.Message}");
            }
        }

        // 保存所有更改
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_invoiceManager.SaveChanges())
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

        // 取消编辑
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _invoiceManager.DataTable.RejectChanges();
            dataGridView1.Refresh();
            FormNavigationManager.ShowInformation("已取消所有未保存的更改");
        }

        // 编辑选中记录
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowInformation("请选择要编辑的记录");
                return;
            }

            try
            {
                DataRow selectedRow = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;

                // 更新选中记录的状态和日期
                selectedRow["Status"] = coboStatus.SelectedItem.ToString();
                selectedRow["InvoiceDate"] = dpStartDate.Value;

                dataGridView1.Refresh();
                FormNavigationManager.ShowInformation("记录已更新");
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"编辑失败: {ex.Message}");
            }
        }

        // 导出为PDF
        private void export_Click(object sender, EventArgs e)
        {
            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
        }

        // 搜索订单
        private void orderSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrder.Text))
            {
                _orderManager.LoadData();
                return;
            }

            try
            {
                orderGridView.DataSource = _orderManager.SearchRecords(
                    txtOrder.Text,
                    "OrderID"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"订单搜索失败: {ex.Message}");
            }
        }

        // 搜索产品
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProd.Text))
            {
                _productManager.LoadData();
                return;
            }

            try
            {
                productGridView.DataSource = _productManager.SearchRecords(
                    txtProd.Text,
                    "ProductID"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"产品搜索失败: {ex.Message}");
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

        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { new Login().Show(); this.Hide(); } }

        private void btn_home_Click(object sender, EventArgs e) =>
             FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));

        private void btn_user_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));

        private void btn_sub1_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinReOverview));

        private void btn_sub2_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));

        private void btn_sub3_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvWarehouse));

        // 空事件处理器
        private void FinReOverview_Load(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}