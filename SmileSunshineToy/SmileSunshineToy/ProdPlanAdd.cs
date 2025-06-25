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

            PlanID = GeneratePlanID();
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            OrderID = orderId;
            ProductID = productId;

            _isViewMode = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            StartDate = dpStartDate.Value;
            EndDate = dpEndDate.Value;
            Status = coboStatus.Text;

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

        private string GeneratePlanID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT generate_id('PLAN')", conn);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "PLAN-ERROR";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"生成ID失败: {ex.Message}");
                return $"PLAN-{DateTime.Now:yyyyMMdd}-001"; // 默认值
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