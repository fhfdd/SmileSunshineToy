using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class SalOrderQuery : Form
    {
        public SalOrderQuery()
        {
            InitializeComponent();
        }

        private void SalOrderQuery_Load(object sender, EventArgs e)
        {
            // 初始化数据
            LoadOrderData();

            // 更新时间显示
            UpdateTimeDisplay();
        }

        private void LoadOrderData()
        {
            try
            {
                // 这里应该使用您的数据访问方法
                // DataTable orders = DataAccess.GetDataTable("SELECT * FROM orders WHERE status = 'Active'");

                // 临时创建示例数据
                DataTable orders = new DataTable();
                orders.Columns.Add("OrderID");
                orders.Columns.Add("CustomerName");
                orders.Columns.Add("OrderDate");
                orders.Columns.Add("Status");
                orders.Columns.Add("TotalAmount");

                orders.Rows.Add("ORD-001", "Customer A", DateTime.Now.ToString(), "Active", "1000");
                orders.Rows.Add("ORD-002", "Customer B", DateTime.Now.ToString(), "Active", "2000");

                // 绑定到DataGridView
                dataGridView1.DataSource = orders;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载订单数据失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTimeDisplay()
        {
            // 更新时间和日期显示
            toolStripLabel1.Text = $"{DateTime.Now.ToString("HH:mm")}\n{DateTime.Now.ToString("yyyy-MM-dd")}";
        }

        // 导航按钮事件处理
        private void btn_home_Click(object sender, EventArgs e)
        {
            // 这里应该使用您的导航方法
            // FormManager.OpenForm<MainDashboard>();
            // this.Close();

            MessageBox.Show("导航到主页");
        }

        private void order_Click(object sender, EventArgs e)
        {
            // 已经是当前页面，无需操作
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到库存管理");
        }

        private void btn_person_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到人员信息");
        }

        private void btn_proc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到采购管理");
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到物流管理");
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到生产管理");
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到财务管理");
        }

        private void btn_rd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到研发管理");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销吗?", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // 这里应该使用您的注销方法
                // UserSession.Logout();
                // FormManager.OpenForm<Login>();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导航到用户资料");
        }
    }
}