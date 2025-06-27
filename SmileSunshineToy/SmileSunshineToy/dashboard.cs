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
    public partial class Dashboard : BaseForm
    {
        public Dashboard()
        {
            InitializeComponent();
            ConfigureUIByRole(UserSession.Role);
            SetDesignSize(new Size(1595, 920));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 显示当前用户信息
            user.Text = UserSession.UserName;
        }

        // 核心逻辑：根据角色显示/隐藏按钮
        private void ConfigureUIByRole(UserRole role)
        {
            // 1. 先隐藏所有功能按钮
            //btn_inv.Visible = false;
            //btn_person.Visible = false;
            //btn_proc.Visible = false;
            //btn_log.Visible = false;
            //btn_prod.Visible = false;
            //btn_fin.Visible = false;
            //btn_rd.Visible = false;
            //order.Visible = false;

            // 2. 根据角色显示对应按钮
            switch (role)
            {
                case UserRole.Admin:
                    ShowAllButtons();
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
                    order.Visible = true;
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

        // ------------------- 使用FormNavigationManager进行导航 ------------------- //
        private void btn_inv_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvMaterial));

        private void order_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(SalOrderQuery));

        private void btn_person_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(PerCusOverview));

        private void btn_proc_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProcOverview));

        private void btn_log_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(LoOverview));

        private void btn_prod_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview));

        private void btn_fin_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));

        private void btn_rd_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(RDdash));

        private void logout_Click(object sender, EventArgs e)
        {
            if (FormNavigationManager.ConfirmLogout())
            {
                // 清除用户会话
                UserSession.UserID = null;
                UserSession.UserName = null;
                UserSession.Role = UserRole.None;

                // 返回登录页面
                FormNavigationManager.NavigateToForm(this, typeof(Login), true);
            }
        }

        // 主页按钮点击事件
        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void btn_user_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));
    }
}