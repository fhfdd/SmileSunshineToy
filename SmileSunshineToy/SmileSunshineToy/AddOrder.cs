using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;CharSet=utf8mb4;";
        private DataTable productsTable;


        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            txtOrderID.Text = GenerateOrderID();
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void LoadProducts()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ProductID,Name  ProductName, Price FROM product";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    productsTable = new DataTable();
                    adapter.Fill(productsTable);

                    cmbProduct.DataSource = productsTable;
                    cmbProduct.DisplayMember = "ProductName";
                    cmbProduct.ValueMember = "ProductID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateOrderID()
        {
            return "ORD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveOrder();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Please enter Customer ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                return false;
            }

            if (cmbProduct.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProduct.Focus();
                return false;
            }

            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return false;
            }

            if (!decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount) || totalAmount <= 0)
            {
                MessageBox.Show("Invalid total amount", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalAmount.Focus();
                return false;
            }

            return true;
        }
        private void SaveOrder()
        {
            try
            {
                // 检查库存
                if (!ValidateInventory())
                {
                    return; // 库存不足，取消保存
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"
                INSERT INTO `test`.`order` (
                  `CustomerID`,
                  `OrderDate`,
                  `Status`,
                  `TotalAmount`,
                  `Product`,
                  `Qty`
                )
                VALUES (
                  {txtCustomerID.Text},
                  '{txtOrderDate.Text}',
                 '{cmbStatus.SelectedItem.ToString()}',
                  {decimal.Parse(txtTotalAmount.Text)},
                  '{cmbProduct.SelectedValue.ToString()}',
                  {int.Parse(txtQty.Text)}
                )";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@CustomerID", );
                    //command.Parameters.AddWithValue("@OrderDate", );
                    //command.Parameters.AddWithValue("@Status", );
                    //command.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtTotalAmount.Text));
                    //command.Parameters.AddWithValue("@Product", cmbProduct.SelectedValue.ToString());
                    //command.Parameters.AddWithValue("@Qty", int.Parse(txtQty.Text));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save order", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInventory()
        {
            if (cmbProduct.SelectedIndex < 0 || !int.TryParse(txtQty.Text, out int orderQuantity))
            {
                return false;
            }

            string productId = cmbProduct.SelectedValue.ToString();
            int availableStock = GetProductStock(productId);

            if (availableStock > 0 && availableStock < orderQuantity * 0.5)
            {
                DialogResult result = MessageBox.Show(
                    $"Warning: Current product stock ({availableStock}) is less than 50% of the order quantity!\nDo you want to proceed with the order submission?");

                return result == DialogResult.Yes;
            }

            return true;
        }

        private int GetProductStock(string productId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Quantity FROM test.inventory WHERE ProductID = @ProductID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"检查库存时出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
        private void ClearForm()
        {
            txtOrderID.Text = GenerateOrderID();
            txtCustomerID.Clear();
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cmbStatus.SelectedIndex = 0;
            txtTotalAmount.Clear();
            cmbProduct.SelectedIndex = -1;
            txtQty.Clear();
        }

        private void CalculateTotalAmount()
        {
            if (cmbProduct.SelectedIndex >= 0 && int.TryParse(txtQty.Text, out int quantity) && quantity > 0)
            {
                DataRowView selectedProduct = (DataRowView)cmbProduct.SelectedItem;
                decimal price = Convert.ToDecimal(selectedProduct["Price"]);
                decimal total = price * quantity;
                txtTotalAmount.Text = total.ToString("0.00");
            }
            else
            {
                txtTotalAmount.Clear();
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
    }
}
