using System;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class NavigationBaseForm : Form
    {
        public NavigationBaseForm()
        {
            InitializeComponent();
            BindNavButtons();      // 绑定按钮事件
            InitializePermissions(); // 权限控制
        }

        #region 按钮绑定与导航逻辑
        private void BindNavButtons()
        {
            // 确保按钮名称与设计器完全一致！
            btn_home.Click += NavButton_Click;
            btn_sale.Click += NavButton_Click;
            btn_rd.Click += NavButton_Click;
            btn_fin.Click += NavButton_Click;
            btn_prod.Click += NavButton_Click;
            btn_log.Click += NavButton_Click;
            btn_proc.Click += NavButton_Click;
            btn_person.Click += NavButton_Click;
            btn_inv.Click += NavButton_Click;
            logout.Click += Logout_Click;
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            Type targetForm = GetTargetForm(btn.Name);
            if (targetForm != null) NavigateTo(targetForm);
        }

        private Type GetTargetForm(string btnName)
        {
            switch (btnName)
            {
                case "btn_home":
                    return typeof(Dashboard);
                case "btn_sale":
                    return typeof(SalOrderQuery);
                case "btn_rd":
                    return typeof(RDoverview);
                case "btn_fin":
                    return typeof(FinPayOverview);
                case "btn_prod":
                    return typeof(ProdInOverview);
                case "btn_log":
                    return typeof(LoOverview);
                case "btn_proc":
                    return typeof(ProcOverview);
                case "btn_person":
                    return typeof(PerCusOverview);
                case "btn_inv":
                    return typeof(InvMaterial);
                default:
                    return null;
            }
        }

        protected void NavigateTo(Type formType)
        {
            Form form = Application.OpenForms.OfType<Form>()
                .FirstOrDefault(f => f.GetType() == formType);

            if (form == null)
                form = Activator.CreateInstance(formType) as Form;

            form.Show();
            form.Activate();

            if (this != form) this.Hide();
        }
        #endregion

        #region 权限控制
        private void InitializePermissions()
        {
            if (UserSession.Role == UserRole.Admin) return;

            HideButton(btn_inv, UserRole.Inventory);
            HideButton(btn_fin, UserRole.Finance);
            HideButton(btn_prod, UserRole.Production);
            HideButton(btn_log, UserRole.Logistics);
            HideButton(btn_proc, UserRole.Procurement);
            HideButton(btn_person, UserRole.Personnel);
            HideButton(btn_rd, UserRole.RD);
            HideButton(btn_sale, UserRole.Sales);
        }

        private void HideButton(Button btn, UserRole role)
        {
            if (btn != null && !UserSession.HasPermission(role))
                btn.Visible = false;
        }
        #endregion

        #region 登出逻辑
        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
        }
        #endregion
    }

}