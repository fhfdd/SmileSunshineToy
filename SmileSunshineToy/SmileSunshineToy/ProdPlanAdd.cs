using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class ProdPlanAdd : BaseDataForm
    {
        private bool _isViewMode = false;
        public string PlanID { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Status { get; private set; }
        public string OrderID { get; private set; }
        public string ProductID { get; private set; }
        public DataRow PlanData { get; private set; }
        private bool _isDataValid = false;

        public ProdPlanAdd(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;

            IDPrefix = "PLAN";
            IDTextBox = txtPlanID;
            TableName = "productionplan";
            PrimaryKey = "planID";

            coboStatus.Items.AddRange(new[] { "Pending", "Processing", "Completed" });
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(7);
            Status = "pending";
            _isViewMode = false;
            txtPlanID.Text = GenerateSystemID(IDPrefix, TableName, PrimaryKey);
            txtPlanID.ReadOnly = true;

            InitializeDataTableStructure();
            InitializeDefaultData();
            LoadOrderAndProductReferences();
        }

        private void InitializeDefaultData()
        {
            PlanData = DataTable.NewRow();
            PlanData["planID"] = txtPlanID.Text;
            PlanData["startDate"] = DateTime.Now;
            PlanData["endDate"] = DateTime.Now.AddDays(7);
            PlanData["status"] = "pending";

            dpStartDate.Value = (DateTime)PlanData["startDate"];
            dpEndDate.Value = (DateTime)PlanData["endDate"];
            coboStatus.Text = PlanData["status"].ToString();
        }

        private void LoadOrderAndProductReferences()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT OrderID FROM `order`", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    coboOrder.Items.Clear();
                    while (reader.Read())
                    {
                        coboOrder.Items.Add(reader["OrderID"].ToString());
                    }
                    reader.Close();

                    cmd = new MySqlCommand("SELECT productID FROM product", conn);
                    reader = cmd.ExecuteReader();
                    coboProduct.Items.Clear();
                    while (reader.Read())
                    {
                        coboProduct.Items.Add(reader["productID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载参考数据失败: {ex.Message}");
            }
        }

        private void InitializeDataTableStructure()
        {
            DataTable.Columns.Add("PlanID", typeof(string));
            DataTable.Columns.Add("StartDate", typeof(DateTime));
            DataTable.Columns.Add("EndDate", typeof(DateTime));
            DataTable.Columns.Add("Status", typeof(string));
            DataTable.Columns.Add("OrderID", typeof(string));
            DataTable.Columns.Add("ProductID", typeof(string));
            DataTable.PrimaryKey = new DataColumn[] { DataTable.Columns["PlanID"] };
        }

        public ProdPlanAdd(string planId, DateTime startDate, DateTime endDate, string status, string orderId, string productId, string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;

            IDPrefix = "PLAN";
            IDTextBox = txtPlanID;
            TableName = "productionplan";
            PrimaryKey = "planID";

            PlanID = planId;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            OrderID = orderId;
            ProductID = productId;

            _isViewMode = true;
            InitializeDataTableStructure();
            LoadExistingData();
        }

        private void LoadExistingData()
        {
            if (_isViewMode)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        string query = $"SELECT * FROM {TableName} WHERE {PrimaryKey} = @planId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@planId", PlanID);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable.Clear();
                        adapter.Fill(DataTable);

                        if (DataTable.Rows.Count > 0)
                        {
                            DataRow row = DataTable.Rows[0];
                            txtPlanID.Text = row["planID"].ToString();
                            dpStartDate.Value = Convert.ToDateTime(row["startDate"]);
                            dpEndDate.Value = Convert.ToDateTime(row["endDate"]);
                            coboStatus.Text = row["status"].ToString();
                            coboOrder.Text = row["orderID"].ToString();
                            coboProduct.Text = row["productID"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载数据失败: {ex.Message}");
                }
            }
        }

        private bool ValidateInputs()
        {
            if (coboOrder.SelectedIndex < 0)
            {
                MessageBox.Show("请选择有效订单");
                return false;
            }

            if (coboProduct.SelectedIndex < 0)
            {
                MessageBox.Show("请选择有效产品");
                return false;
            }

            if (dpStartDate.Value > dpEndDate.Value)
            {
                MessageBox.Show("结束日期不能早于开始日期");
                return false;
            }

            return true;
        }

        private bool OrderExists(string orderId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `order` WHERE OrderID = @orderId", conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private bool ProductExists(string productId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM product WHERE productID = @productId", conn);
                cmd.Parameters.AddWithValue("@productId", productId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (!OrderExists(coboOrder.Text))
            {
                MessageBox.Show("订单不存在，请重新选择");
                return;
            }
            if (!ProductExists(coboProduct.Text))
            {
                MessageBox.Show("产品不存在，请重新选择");
                return;
            }

            try
            {
                PlanData["planID"] = txtPlanID.Text;
                PlanData["startDate"] = dpStartDate.Value;
                PlanData["endDate"] = dpEndDate.Value;
                PlanData["status"] = coboStatus.Text;
                PlanData["orderID"] = coboOrder.Text;
                PlanData["productID"] = coboProduct.Text;

                _isDataValid = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存数据失败: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (DialogResult == DialogResult.OK && !_isDataValid)
            {
                MessageBox.Show("请先保存数据");
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}