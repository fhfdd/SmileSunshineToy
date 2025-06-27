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
    public partial class PerCusOverview : Form
    {
        private DataGridManager _customerManager;
        private DataGridManager _orderManager;
        private DataGridManager _productManager;

        public PerCusOverview()
        {
            InitializeComponent();

            // 初始化数据管理器
            _customerManager = new DataGridManager("customer", "CustomerID", "CUST");
            _orderManager = new DataGridManager("order", "OrderID", "ORD");
            _productManager = new DataGridManager("product", "ProductID", "PROD");

            // 设置连接字符串
            _customerManager.SetConnectionString(Configuration.ConnectionString);
            _orderManager.SetConnectionString(Configuration.ConnectionString);
            _productManager.SetConnectionString(Configuration.ConnectionString);
        }

        private void PerCusOverview_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            //LoadOrderComboBox();
            LoadProductComboBox();

            // 初始化状态下拉框
            coboStatus.Items.AddRange(new string[] { "Active", "Inactive", "VIP" });
            coboStatus.SelectedIndex = 0;

            // 初始化筛选下拉框
            filterComboBox.Items.AddRange(new string[] { "Name", "Email", "Phone", "Address" });
            filterComboBox.SelectedIndex = 0;
        }

        private void LoadCustomerData()
        {
            try
            {
                dataGridView1.DataSource = _customerManager.LoadData();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load customer data: {ex.Message}");
            }
        }

        //private void LoadOrderComboBox()
        //{
        //    try
        //    {
        //        var orders = _orderManager.LoadData();
        //        orderID.Items.Clear();
        //        orderID.Items.Add("All Orders");

        //        foreach (DataRow row in orders.Rows)
        //        {
        //            orderID.Items.Add(row["OrderID"].ToString());
        //        }

        //        orderID.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        FormNavigationManager.ShowError($"Failed to load orders: {ex.Message}");
        //    }
        //}

        private void LoadProductComboBox()
        {
            try
            {
                //var products = _productManager.LoadData();
                //productID.Items.Clear();
                //productID.Items.Add("All Products");

                //foreach (DataRow row in products.Rows)
                //{
                //    productID.Items.Add(row["ProductID"].ToString());
                //}

                //productID.SelectedIndex = 0;
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
                    LoadCustomerData();
                    return;
                }

                DataTable searchResult = _customerManager.SearchRecords(searchText, columnName);
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
                DataRow newRow = _customerManager.DataTable.NewRow();
                newRow["CustomerID"] = _customerManager.GenerateSystemID();
                _customerManager.DataTable.Rows.Add(newRow);

                FormNavigationManager.ShowInformation("New customer record added. Please fill in the details and save.");
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to add new customer: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_customerManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("Customer data saved successfully.");
                    LoadCustomerData();
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to save customer data: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _customerManager.DataTable.RejectChanges();
            LoadCustomerData();
            FormNavigationManager.ShowInformation("Changes discarded.");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowError("Please select a customer to edit.");
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

        //private void orderSearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (orderID.SelectedIndex <= 0) // "All Orders" selected
        //        {
        //            orderGridView.DataSource = _orderManager.LoadData();
        //        }
        //        else
        //        {
        //            string selectedOrderId = orderID.SelectedItem.ToString();
        //            string searchText = txtOrder.Text.Trim();

        //            if (string.IsNullOrEmpty(searchText))
        //            {
        //                orderGridView.DataSource = _orderManager.LoadGridData("order", "OrderID", selectedOrderId);
        //            }
        //            else
        //            {
        //                DataTable searchResult = _orderManager.SearchRecords(searchText, "OrderID");
        //                orderGridView.DataSource = searchResult;
        //            }
        //        }

        //        orderGridView.ClearSelection();
        //    }
        //    catch (Exception ex)
        //    {
        //        FormNavigationManager.ShowError($"Failed to load orders: {ex.Message}");
        //    }
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (productID.SelectedIndex <= 0) // "All Products" selected
        //        {
        //            productGridView.DataSource = _productManager.LoadData();
        //        }
        //        else
        //        {
        //            string selectedProductId = productID.SelectedItem.ToString();
        //            string searchText = txtProd.Text.Trim();

        //            if (string.IsNullOrEmpty(searchText))
        //            {
        //                productGridView.DataSource = _productManager.LoadGridData("product", "ProductID", selectedProductId);
        //            }
        //            else
        //            {
        //                DataTable searchResult = _productManager.SearchRecords(searchText, "ProductID");
        //                productGridView.DataSource = searchResult;
        //            }
        //        }

        //        productGridView.ClearSelection();
        //    }
        //    catch (Exception ex)
        //    {
        //        FormNavigationManager.ShowError($"Failed to load products: {ex.Message}");
        //    }
        //}

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
        private void btn_home_Click(object sender, EventArgs e) =>
              FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));
        private void btn_user_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm), true); }
        private void btn_sub1_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvProduct), true); }
        private void btn_sub2_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvMaterial), true); }
        private void btn_sub3_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(InvWarehouse), true); }

        private void btn_stuff_Click(object sender, EventArgs e) { FormNavigationManager.NavigateToForm(this, typeof(PerStuOverview), true); }

        private void btn_product_Click(object sender, EventArgs e)
        {

        }
    }
}