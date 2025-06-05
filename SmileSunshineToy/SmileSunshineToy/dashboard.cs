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
    public partial class Dashboard : Form
    {
        public Dashboard(UserRole userRole)
        {
            InitializeComponent();
            // 根据角色配置 UI
            ConfigureUIByRole(userRole);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        // 核心逻辑：根据角色显示/隐藏按钮
        private void ConfigureUIByRole(UserRole role)
        {
            // 1. 先隐藏所有功能按钮（注销和主页默认显示，需确保设计器中已设为可见）
            btn_inv.Visible = false;
            btn_person.Visible = false;
            btn_proc.Visible = false;
            btn_log.Visible = false;
            btn_prod.Visible = false;
            btn_fin.Visible = false;
            btn_rd.Visible = false;
            order.Visible = false; // 销售订单按钮

            // 2. 根据角色显示对应按钮
            switch (role)
            {
                case UserRole.Admin:
                    ShowAllButtons(); // 管理员显示所有按钮
                    break;
                case UserRole.Inventory:
                    btn_inv.Visible = true;
                    break;
                case UserRole.Finance:
                    btn_fin.Visible = true;
                    break;
                case UserRole.Production:
                    btn_prod.Visible = true;
                    break;
                case UserRole.Logistics:
                    btn_log.Visible = true;
                    break;
                case UserRole.Procurement:
                    btn_proc.Visible = true;
                    break;
                case UserRole.Personnel:
                    btn_person.Visible = true;
                    break;
                case UserRole.RD:
                    btn_rd.Visible = true;
                    break;
                case UserRole.Sales:
                    order.Visible = true; // 销售订单按钮
                    break;
            }
        }

        // 辅助方法：管理员显示所有按钮
        private void ShowAllButtons()
        {
            btn_inv.Visible = true;
            btn_person.Visible = true;
            btn_proc.Visible = true;
            btn_log.Visible = true;
            btn_prod.Visible = true;
            btn_fin.Visible = true;
            btn_rd.Visible = true;
            order.Visible = true;
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
    }
}

