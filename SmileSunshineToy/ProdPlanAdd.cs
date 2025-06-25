using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class ProdPlanAdd : Form
    {
        private string _connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
        private bool _isViewMode = false;
        public string PlanID { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Status { get; private set; }
        public string OrderID { get; private set; }
        public string ProductID { get; private set; }

        public ProdPlanAdd(string connectionString)
        {
            InitializeComponent();
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(7);
            Status = "pending";
            _isViewMode = false;
        }
        public ProdPlanAdd(
            string planId,
            DateTime startDate,
            DateTime endDate,
            string status,
            string orderId,
            string productId)
        {
            InitializeComponent();

            PlanID = planId;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            OrderID = orderId;
            ProductID = productId;

            _isViewMode = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtOrder.Text.Trim(), out int orderId))
            {
                MessageBox.Show("请输入有效的订单ID");
                return;
            }

            if (!int.TryParse(txtProd.Text.Trim(), out int productId))
            {
                MessageBox.Show("请输入有效的产品ID");
                return;
            }
            if (!CheckForeignKeyExists(_connectionString, "`order`", "OrderID", orderId))
            {
                MessageBox.Show("订单ID不存在，请输入有效的订单ID");
                return;
            }

            if (!CheckForeignKeyExists(_connectionString, "`product`", "ProductID", productId))
            {
                MessageBox.Show("产品ID不存在，请输入有效的产品ID");
                return;
            }

            StartDate = dpStartDate.Value;
            EndDate = dpEndDate.Value;
            Status = coboStatus.Text;
            OrderID = txtOrder.Text.Trim();
            ProductID = txtProd.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool CheckForeignKeyExists(string connectionString, string tableName, string columnName, int value)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @Value";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Value", value);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"检查外键时发生错误: {ex.Message}");
                return false;
            }
        }

        private void ProdPlanAdd_Load(object sender, EventArgs e)
        {
            txtPlanID.Text = PlanID;
            dpStartDate.Value = StartDate;
            dpEndDate.Value = EndDate;
            coboStatus.Text = Status;
            txtOrder.Text = OrderID;
            txtProd.Text = ProductID;

            if (_isViewMode)
            {
                txtPlanID.ReadOnly = true;
                dpStartDate.Enabled = false;
                dpEndDate.Enabled = false;
                coboStatus.Enabled = false;
                txtOrder.ReadOnly = true;
                txtProd.ReadOnly = true;

                btnSave.Visible = false;
                btnCancel.Text = "Close";
            }
        }

    }
}