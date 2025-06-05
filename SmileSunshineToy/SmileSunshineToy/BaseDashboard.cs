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


    public partial class BaseDashboard : Form
    {

        protected Button[] functionButtons;
        protected Button logoutBtn, homeBtn; // 公共按钮
        protected Panel menuPanel; // 菜单容器

        public BaseDashboard(UserRole role)
        {
            InitializeMenuPanel(); // 初始化菜单面板
            ConfigureMenuByRole(role); // 按角色显示菜单
            InitializeCommonButtons(); // 添加公共按钮（注销、主页）
        }

        private void InitializeMenuPanel()
        {
            menuPanel = new Panel();
            menuPanel.Dock = DockStyle.Left;
            menuPanel.BackColor = Color.Bisque;
            Controls.Add(menuPanel);
        }

        protected virtual void ConfigureMenuByRole(UserRole role)
        {
            // 隐藏所有功能按钮（公共按钮默认显示）
            foreach (var btn in functionButtons)
            {
                btn.Visible = false;
            }

            // 根据角色显示对应按钮（简化条件判断）
            switch (role)
            {
                case UserRole.Admin:
                    ShowAllButtons(); // 显示所有按钮
                    break;
                case UserRole.None:
                    functionButtons[0].Visible = true; 
                    break;
                case UserRole.Sales:
                    functionButtons[1].Visible = true;
                    break;
                case UserRole.RD:
                    functionButtons[2].Visible = true; 
                    break;
                case UserRole.Finance:
                    functionButtons[4].Visible = true;
                    break;
                case UserRole.Production:
                    functionButtons[5].Visible = true;
                    break;
                case UserRole.Logistics:
                    functionButtons[6].Visible = true;
                    break;
                case UserRole.Procurement:
                    functionButtons[7].Visible = true;
                    break;
                case UserRole.Personnel:
                    functionButtons[8].Visible = true;
                    break;
                case UserRole.Inventory:
                    functionButtons[9].Visible = true;
                    break;
            }
        }

        private void InitializeCommonButtons()
        {
            // 主页按钮（需在子类中绑定设计器中的按钮）
            homeBtn = new Button();
            homeBtn.Dock = DockStyle.Top;
            homeBtn.Text = "Home";
            homeBtn.Click += HomeBtn_Click;
            menuPanel.Controls.Add(homeBtn);

            // 注销按钮（需在子类中绑定设计器中的按钮）
            logoutBtn = new Button();
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.Text = "Logout";
            logoutBtn.Click += LogoutBtn_Click;
            menuPanel.Controls.Add(logoutBtn);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Show(); // 显示当前窗体
            this.Activate(); // 激活窗体
        }

        protected void NavigateToForm(Type formType)
        {
            if (formType != null)
            {
                Form newForm = (Form)Activator.CreateInstance(formType);
                newForm.Show();
                this.Hide();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "退出", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Login().Show(); // 假设存在Login窗体
            }
        }

        protected void ShowAllButtons()
        {
            foreach (var btn in functionButtons)
            {
                btn.Visible = true;
            }
        }
        public BaseDashboard()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            using (UserProfileForm profileForm = new UserProfileForm())
            {
                DialogResult result = profileForm.ShowDialog();
            }
        }

        private void BaseDashboaed_Load(object sender, EventArgs e)
        {

        }
    }
}
