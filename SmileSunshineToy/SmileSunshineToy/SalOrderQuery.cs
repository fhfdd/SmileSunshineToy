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
    public partial class SalOrderQuery : BaseForm
    {
        public SalOrderQuery()
        {
            InitializeComponent();

            SetDesignSize(new Size(1792, 1126));
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {

        }

        private void btn_rd_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_inv_Click(object sender, EventArgs e)
        {

        }

        private void btn_person_Click(object sender, EventArgs e)
        {

        }

        private void btn_proc_Click(object sender, EventArgs e)
        {

        }

        private void btn_log_Click(object sender, EventArgs e)
        {

        }

        private void btn_prod_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e) =>
              FormNavigationManager.NavigateToForm(this, typeof(UserProfileForm));
    }
}
