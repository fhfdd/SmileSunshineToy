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
    public partial class LoOverview : Form
    {
        public LoOverview()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void LoOverview_Load(object sender, EventArgs e)
        {

        }
        private void btn_inv_Click(object sender, EventArgs e) {
            InvMaterial I1 = new InvMaterial();
            I1.Show();
        }
        private void order_Click(object sender, EventArgs e) { new SalOrderQuery().Show(); this.Hide(); }
        private void btn_person_Click(object sender, EventArgs e) { new PerCusOverview().Show(); this.Hide(); }
        private void btn_proc_Click(object sender, EventArgs e) { new ProcOverview().Show(); this.Hide(); }
        private void btn_log_Click(object sender, EventArgs e) { new LoOverview().Show(); this.Hide(); }
        private void btn_prod_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_fin_Click(object sender, EventArgs e) { new FinPayOverview().Show(); this.Hide(); }
        private void btn_rd_Click(object sender, EventArgs e) { new RDdash().Show(); this.Hide(); }
        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { this.Close(); new Login().Show(); } }
        private void btn_home_Click(object sender, EventArgs e) {
            Dashboard D1 = new Dashboard();
            D1.Show();
        }
        private void btn_fin_Click_1(object sender, EventArgs e) { FinPayOverview finPayForm = new FinPayOverview(); finPayForm.Show(); this.Hide(); }
        private void btn_user_Click(object sender, EventArgs e) { new UserProfileForm().Show(); this.Hide(); }
        private void btn_sub1_Click(object sender, EventArgs e) { new InvProduct().Show(); this.Hide(); }
        private void btn_sub2_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void btn_sub3_Click(object sender, EventArgs e) { new InvWarehouse().Show(); this.Hide(); }

        private void btn_log_Click_1(object sender, EventArgs e)
        {
            LoOverview Lo1 = new LoOverview();
            Lo1.Show();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void order_Click_1(object sender, EventArgs e)
        {
            SalOrderQuery S1 = new SalOrderQuery();
            S1.Show();

        }

        private void btn_rd_Click_1(object sender, EventArgs e)
        {
            RDdash R1 = new RDdash();
            R1.Show();
        }

        private void btn_fin_Click_2(object sender, EventArgs e)
        {
            FinPayOverview P1 = new FinPayOverview();
            P1.Show();
        }

        private void btn_prod_Click_1(object sender, EventArgs e)
        {
            ProdInOverview P2 = new ProdInOverview();
            P2.Show();
        }

        private void btn_proc_Click_1(object sender, EventArgs e)
        {
            ProcOverview P3 = new ProcOverview();
            P3.Show();
        }

        private void btn_person_Click_1(object sender, EventArgs e)
        {
            PerCusOverview P4 = new PerCusOverview();
            P4.Show();
        }
    }
}
