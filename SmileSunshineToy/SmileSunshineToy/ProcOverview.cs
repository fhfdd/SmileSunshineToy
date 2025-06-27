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
    public partial class ProcOverview : Form
    {
        private DataGridManager _procurementManager;
        private DataGridManager _supplierManager;
        private DataGridManager _materialManager;

        public ProcOverview()
        {
            InitializeComponent();

            // 初始化数据管理器
            _procurementManager = new DataGridManager("procurement", "ProcurementID", "PROC");
            _supplierManager = new DataGridManager("supplier", "SupplierID", "SUPP");
            _materialManager = new DataGridManager("material", "MaterialID", "MAT");

            // 设置连接字符串
            _procurementManager.SetConnectionString(Configuration.ConnectionString);
            _supplierManager.SetConnectionString(Configuration.ConnectionString);
            _materialManager.SetConnectionString(Configuration.ConnectionString);
        }

        private void ProcOverview_Load(object sender, EventArgs e)
        {
            LoadProcurementData();
            LoadSupplierComboBox();
            LoadMaterialComboBox();

            // 初始化状态下拉框
            coboStatus.Items.AddRange(new string[] { "Pending", "Approved", "Completed", "Cancelled" });
            coboStatus.SelectedIndex = 0;

            // 初始化筛选下拉框
            filterComboBox.Items.AddRange(new string[] { "SupplierID", "MaterialID", "Status" });
            filterComboBox.SelectedIndex = 0;
        }

        private void LoadProcurementData()
        {
            try
            {
                dataGridView1.DataSource = _procurementManager.LoadData();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load procurement data: {ex.Message}");
            }
        }

        private void LoadSupplierComboBox()
        {
            try
            {
                var suppliers = _supplierManager.LoadData();
                orderID.Items.Clear();
                orderID.Items.Add("All Suppliers");

                foreach (DataRow row in suppliers.Rows)
                {
                    orderID.Items.Add(row["SupplierID"].ToString());
                }

                orderID.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load suppliers: {ex.Message}");
            }
        }

        private void LoadMaterialComboBox()
        {
            try
            {
                var materials = _materialManager.LoadData();
                productID.Items.Clear();
                productID.Items.Add("All Materials");

                foreach (DataRow row in materials.Rows)
                {
                    productID.Items.Add(row["MaterialID"].ToString());
                }

                productID.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load materials: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string columnName = filterComboBox.SelectedItem.ToString();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadProcurementData();
                    return;
                }

                DataTable searchResult = _procurementManager.SearchRecords(searchText, columnName);
                dataGridView1.DataSource = searchResult;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Search failed: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = _procurementManager.DataTable.NewRow();
                newRow["ProcurementID"] = _procurementManager.GenerateSystemID();
                newRow["Status"] = "Pending"; // 默认状态
                newRow["OrderDate"] = DateTime.Now.ToString("yyyy-MM-dd");
                _procurementManager.DataTable.Rows.Add(newRow);

                FormNavigationManager.ShowInformation("New procurement record added. Please fill in the details and save.");
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to add new procurement: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_procurementManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("Procurement data saved successfully.");
                    LoadProcurementData();
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to save procurement data: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _procurementManager.DataTable.RejectChanges();
            LoadProcurementData();
            FormNavigationManager.ShowInformation("Changes discarded.");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowError("Please select a procurement record to edit.");
                return;
            }

            // 这里可以添加编辑特定字段的逻辑
            FormNavigationManager.ShowInformation("Edit mode activated. Make changes and click Save.");
        }

        private void export_Click(object sender, EventArgs e)
        {
            try
            {
                ExportSettings settings = new ExportSettings
                {
                    FontName = "Arial",
                    FontSize = 10f,
                    Alignment = TextAlignment.Left,
                    HeaderAlignment = TextAlignment.Center,
                    Title = "Procurement Report"
                };

                bool success = TextPdfExporter.ExportDataGridViewToPdf(dataGridView1, settings);

                if (!success)
                {
                    FormNavigationManager.ShowError("Export to PDF failed.");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Export failed: {ex.Message}");
            }
        }

        private void orderSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderID.SelectedIndex <= 0) // "All Suppliers" selected
                {
                    orderGridView.DataSource = _supplierManager.LoadData();
                }
                else
                {
                    string selectedSupplierId = orderID.SelectedItem.ToString();
                    string searchText = txtOrder.Text.Trim();

                    if (string.IsNullOrEmpty(searchText))
                    {
                        orderGridView.DataSource = _supplierManager.LoadGridData("supplier", "SupplierID", selectedSupplierId);
                    }
                    else
                    {
                        DataTable searchResult = _supplierManager.SearchRecords(searchText, "SupplierID");
                        orderGridView.DataSource = searchResult;
                    }
                }

                orderGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load suppliers: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (productID.SelectedIndex <= 0) // "All Materials" selected
                {
                    productGridView.DataSource = _materialManager.LoadData();
                }
                else
                {
                    string selectedMaterialId = productID.SelectedItem.ToString();
                    string searchText = txtProd.Text.Trim();

                    if (string.IsNullOrEmpty(searchText))
                    {
                        productGridView.DataSource = _materialManager.LoadGridData("material", "MaterialID", selectedMaterialId);
                    }
                    else
                    {
                        DataTable searchResult = _materialManager.SearchRecords(searchText, "MaterialID");
                        productGridView.DataSource = searchResult;
                    }
                }

                productGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load materials: {ex.Message}");
            }
        }

        // 导航按钮事件处理
        private void btn_inv_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvMaterial), true); }
        private void order_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(SalOrderQuery), true); }
        private void btn_person_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(PerCusOverview), true); }
        private void btn_proc_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(ProcOverview), true); }
        private void btn_log_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(LoOverview), true); }
        private void btn_prod_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview), true); }
        private void btn_fin_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview), true); }
        private void btn_rd_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(RDdash), true); }
        private void logout_Click(object sender, EventArgs e) { if (FormNavigationManager.ShowConfirmation("Confirm logout?")) { this.Close(); FormNavigationManager.NavigateToForm(this, typeof(Login), false); } }
        private void btn_home_Click(object sender, EventArgs e) { this.Show(); this.Activate(); }
        private void btn_user_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm), true); }
        private void btn_sub1_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvProduct), true); }
        private void btn_sub2_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvMaterial), true); }
        private void btn_sub3_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvWarehouse), true); }
    }
}