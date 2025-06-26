using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class ProdPlanAdd : Form
    {
        private string _connectionString;
        public DataRow PlanData { get; private set; }
        public string PlanID { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Status { get; private set; }
        public string OrderID { get; private set; }
        public string ProductID { get; private set; }

        public ProdPlanAdd(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            InitializeForm();
        }

        private void InitializeForm()
        {
            // 初始化状态下拉框
            coboStatus.Items.AddRange(new[] { "Pending", "Processing", "Completed" });
            coboStatus.SelectedIndex = 0;

            // 设置默认日期
            dpStartDate.Value = DateTime.Now;
            dpEndDate.Value = DateTime.Now.AddDays(7);

            // 生成PlanID
            txtPlanID.Text = GeneratePlanID();
            txtPlanID.ReadOnly = true;

            // 加载订单和产品数据
            LoadReferenceData();
        }

        private string GeneratePlanID()
        {
            return "PLAN-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void LoadReferenceData()
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    // 加载订单
                    var cmd = new MySqlCommand("SELECT OrderID FROM `order`", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coboOrder.Items.Add(reader["OrderID"].ToString());
                        }
                    }

                    // 加载产品
                    cmd = new MySqlCommand("SELECT productID FROM product", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coboProduct.Items.Add(reader["productID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载数据失败: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(coboOrder.Text) || coboOrder.Text == "orderID")
            {
                MessageBox.Show("请选择有效的订单");
                return false;
            }

            if (string.IsNullOrEmpty(coboProduct.Text) || coboProduct.Text == "product")
            {
                MessageBox.Show("请选择有效的产品");
                return false;
            }

            if (dpStartDate.Value > dpEndDate.Value)
            {
                MessageBox.Show("结束日期不能早于开始日期");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                // 创建数据行
                DataTable dt = new DataTable();
                dt.Columns.Add("PlanID", typeof(string));
                dt.Columns.Add("StartDate", typeof(DateTime));
                dt.Columns.Add("EndDate", typeof(DateTime));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("OrderID", typeof(string));
                dt.Columns.Add("ProductID", typeof(string));

                PlanData = dt.NewRow();
                PlanData["PlanID"] = txtPlanID.Text;
                PlanData["StartDate"] = dpStartDate.Value;
                PlanData["EndDate"] = dpEndDate.Value;
                PlanData["Status"] = coboStatus.Text;
                PlanData["OrderID"] = coboOrder.Text;
                PlanData["ProductID"] = coboProduct.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}