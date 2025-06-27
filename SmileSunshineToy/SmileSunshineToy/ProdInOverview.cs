using System;
using System.Data;
using System.Windows.Forms;
using SmileSunshineToy.Inventory;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace SmileSunshineToy
{
    public partial class ProdInOverview : Form
    {
        private DataGridManager _inboundManager;
        private SelectionHandler _productSelectionHandler;
        private bool _isDataValid;

        public ProdInOverview()
        {
            InitializeComponent();
            InitializeDataManager();
            InitializeProductSelection();
            CheckPermissions();
        }

        #region 初始化方法
        private void InitializeDataManager()
        {
            _inboundManager = new DataGridManager("inbound", "InboundID", "IN");
            _inboundManager.SetConnectionString("Server=localhost;Database=test;Uid=root;Pwd=;");
            dataGridView1.DataSource = _inboundManager.DataTable;
        }

        private void InitializeProductSelection()
        {
            _productSelectionHandler = new SelectionHandler(
                productGridView,
                productId => txtProd.Text = productId,
                "ProductID"
            );
        }

        private void CheckPermissions()
        {
            bool canEdit = UserSession.HasPermission(UserRole.Inventory) ||
                         UserSession.HasPermission(UserRole.Production);

            btnAdd.Enabled = canEdit;
            btnSave.Enabled = canEdit;
            editBtn.Enabled = canEdit;
        }
        #endregion

        #region 数据操作
        private void LoadData()
        {
            try
            {
                _inboundManager.LoadData();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"数据加载失败: {ex.Message}");
            }
        }

        private void FilterData()
        {
            DateTime startDate = dpStartDate.Value;
            DateTime endDate = dpEndDate.Value;

            var filteredData = _inboundManager.DataTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("InboundDate") >= startDate &&
                              row.Field<DateTime>("InboundDate") <= endDate)
                .CopyToDataTable();

            dataGridView1.DataSource = filteredData;
        }
        #endregion

        #region 事件处理
        private void ProdInOverview_Load(object sender, EventArgs e)
        {
            dpStartDate.Value = DateTime.Today.AddDays(-7);
            dpEndDate.Value = DateTime.Today;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new InboundAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    DataRow newRow = _inboundManager.DataTable.NewRow();
                    newRow["InboundID"] = _inboundManager.GenerateSystemID();
                    newRow["ProductID"] = addForm.ProductID;
                    newRow["Quantity"] = addForm.Quantity;
                    newRow["InboundDate"] = DateTime.Now;
                    newRow["Operator"] = UserSession.UserID;
                    newRow["Status"] = "Pending";

                    _inboundManager.DataTable.Rows.Add(newRow);
                    dataGridView1.Refresh();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inboundManager.SaveChanges())
                {
                    // 更新库存
                    foreach (DataRow row in _inboundManager.DataTable.Rows)
                    {
                        if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Modified)
                        {
                            using (var inventoryService = new InventoryService())
                            {
                                inventoryService.RecordStockIn(
                                    row["ProductID"].ToString(),
                                    Convert.ToInt32(row["Quantity"])
                                );
                            }
                        }
                    }

                    FormNavigationManager.ShowInformation("数据保存成功!");
                    _isDataValid = true;
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"保存失败: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string selectedColumn = filterComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedColumn))
            {
                dataGridView1.DataSource = _inboundManager.SearchRecords(searchText, selectedColumn);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            var settings = new ExportSettings
            {
                FileFilter = "PDF文件|*.pdf",
                DefaultFileName = $"入库记录_{DateTime.Now:yyyyMMdd}",
                FontName = "Microsoft YaHei",
                Alignment = TextAlignment.Center
            };

            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1, settings);
        }

        private void productGridView_SelectionChanged(object sender, EventArgs e)
        {
            _productSelectionHandler.ProcessCurrentSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string inboundId = row.Cells["InboundID"].Value?.ToString();

                using (var detailForm = new InboundDetailForm(inboundId))
                {
                    detailForm.ShowDialog();
                }
            }
        }
        #endregion

        #region 导航方法
        private void btn_inv_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(InvMaterial), true);
        private void order_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(SalOrderQuery), true);
        private void btn_person_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(PerCusOverview), true);
        private void btn_proc_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(ProcOverview), true);
        private void btn_log_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(LoOverview), true);
        private void btn_prod_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview), true);
        private void btn_fin_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview), true);
        private void btn_rd_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(RDdash), true);
        private void btn_user_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm), true);
        private void btn_sub1_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview), true);
        private void btn_sub2_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(ProdPlanOverview), true);
        private void btn_sub3_Click(object sender, EventArgs e) => FormNavigationManager.NavigateToForm(this, typeof(InvWarehouse), true);

        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { new Login().Show(); this.Hide(); } }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }
        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!_isDataValid && _inboundManager.DataTable.GetChanges() != null)
            {
                if (FormNavigationManager.ShowConfirmation("有未保存的数据，确定要退出吗？"))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }

    #region 辅助类
    public class InboundAddForm : Form
    {
        public string ProductID { get; private set; }
        public int Quantity { get; private set; }

        private TextBox txtProductID;
        private NumericUpDown numQuantity;
        private Button btnSave;
        private Button btnCancel;

        public InboundAddForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 窗体初始化代码
            this.txtProductID = new TextBox();
            this.numQuantity = new NumericUpDown();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.ResumeLayout(false);
            this.PerformLayout();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ProductID = txtProductID.Text;
                Quantity = (int)numQuantity.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                FormNavigationManager.ShowError("请选择商品");
                return false;
            }

            if (numQuantity.Value <= 0)
            {
                FormNavigationManager.ShowError("入库数量必须大于0");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public class InboundDetailForm : Form
    {
        public InboundDetailForm(string inboundId)
        {
            this.Text = "入库详情";
            this.Size = new Size(400, 300);
            LoadInboundDetails(inboundId);
        }

        private void LoadInboundDetails(string inboundId)
        {
            // 加载入库单详细信息
            // 可以显示商品图片、详细参数等
        }
    }
    #endregion
}