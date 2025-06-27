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
    public partial class PerSupOverview : Form
    {
        private DataGridManager _supplierManager;
        private DataGridManager _materialManager;
        private DataGridManager _productManager;

        public PerSupOverview()
        {
            InitializeComponent();

            // 初始化数据管理器
            _supplierManager = new DataGridManager("supplier", "SupplierID", "SUPP");
            _materialManager = new DataGridManager("material", "MaterialID", "MAT");
            _productManager = new DataGridManager("product", "ProductID", "PROD");

            // 设置连接字符串
            _supplierManager.SetConnectionString(Configuration.ConnectionString);
            _materialManager.SetConnectionString(Configuration.ConnectionString);
            _productManager.SetConnectionString(Configuration.ConnectionString);
        }

        private void PerSupOverview_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
            LoadMaterialComboBox();
            LoadProductComboBox();

            // 初始化状态下拉框
            coboStatus.Items.AddRange(new string[] { "Active", "Inactive", "Preferred" });
            coboStatus.SelectedIndex = 0;

            // 初始化筛选下拉框
            filterComboBox.Items.AddRange(new string[] { "Name", "ContactInfo", "Address" });
            filterComboBox.SelectedIndex = 0;
        }

        private void LoadSupplierData()
        {
            try
            {
                dataGridView1.DataSource = _supplierManager.LoadData();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load supplier data: {ex.Message}");
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

        private void LoadProductComboBox()
        {
            try
            {
                var products = _productManager.LoadData();
                orderID.Items.Clear();
                orderID.Items.Add("All Products");

                foreach (DataRow row in products.Rows)
                {
                    orderID.Items.Add(row["ProductID"].ToString());
                }

                orderID.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load products: {ex.Message}");
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
                    LoadSupplierData();
                    return;
                }

                DataTable searchResult = _supplierManager.SearchRecords(searchText, columnName);
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
                DataRow newRow = _supplierManager.DataTable.NewRow();
                newRow["SupplierID"] = _supplierManager.GenerateSystemID();
                _supplierManager.DataTable.Rows.Add(newRow);

                FormNavigationManager.ShowInformation("New supplier record added. Please fill in the details and save.");
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to add new supplier: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_supplierManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("Supplier data saved successfully.");
                    LoadSupplierData();
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to save supplier data: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _supplierManager.DataTable.RejectChanges();
            LoadSupplierData();
            FormNavigationManager.ShowInformation("Changes discarded.");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowError("Please select a supplier to edit.");
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
                    HeaderAlignment = TextAlignment.Center
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
                if (orderID.SelectedIndex <= 0) // "All Products" selected
                {
                    orderGridView.DataSource = _productManager.LoadData();
                }
                else
                {
                    string selectedProductId = orderID.SelectedItem.ToString();
                    string searchText = txtOrder.Text.Trim();

                    if (string.IsNullOrEmpty(searchText))
                    {
                        orderGridView.DataSource = _productManager.LoadGridData("product", "ProductID", selectedProductId);
                    }
                    else
                    {
                        DataTable searchResult = _productManager.SearchRecords(searchText, "ProductID");
                        orderGridView.DataSource = searchResult;
                    }
                }

                orderGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load products: {ex.Message}");
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