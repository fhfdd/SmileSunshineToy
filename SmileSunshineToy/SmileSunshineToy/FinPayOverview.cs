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
    public partial class FinPayOverview : Form
    {
        public FinPayOverview()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FinPayOverview_Load(object sender, EventArgs e)
        {

        }

        // ------------------- 以下是按钮点击事件（跳转到对应窗体） ------------------- //
        private void btn_inv_Click(object sender, EventArgs e)
        {
            new InvMaterial().Show(); // 库存管理窗体
            this.Hide();
        }

        private void order_Click(object sender, EventArgs e)
        {
            new SalOrderQuery().Show(); // 销售订单窗体
            this.Hide();
        }

        private void btn_person_Click(object sender, EventArgs e)
        {
            new PerCusOverview().Show(); // 人事管理窗体
            this.Hide();
        }

        private void btn_proc_Click(object sender, EventArgs e)
        {
            new ProcOverview().Show(); // 采购管理窗体
            this.Hide();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            new LoOverview().Show(); // 物流管理窗体
            this.Hide();
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            new ProdInOverview().Show(); // 生产管理窗体
            this.Hide();
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {
            new FinPayOverview().Show(); // 财务管理窗体
            this.Hide();
        }

        private void btn_rd_Click(object sender, EventArgs e)
        {
            new RDdash().Show(); // 研发管理窗体
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            // 退出逻辑（同之前）
            if (MessageBox.Show("确认退出？", "退出", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
        }

        // 主页按钮点击事件：确保Dashboard始终可见并激活
        private void btn_home_Click(object sender, EventArgs e)
        {
            // 显示窗体（若被隐藏）
            this.Show();
            // 激活窗体（置于最前）
            this.Activate();
        }

        private void btn_fin_Click_1(object sender, EventArgs e)
        {
            FinPayOverview finPayForm = new FinPayOverview(); // 创建实例
            finPayForm.Show(); // 调用实例方法
            this.Hide(); ;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {

            new UserProfileForm().Show(); // 研发管理窗体
            this.Hide();

        }

        private void btn_sub3_Click(object sender, EventArgs e)
        {

        }
    }
}

