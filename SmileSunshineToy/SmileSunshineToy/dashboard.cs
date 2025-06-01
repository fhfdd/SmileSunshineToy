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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void rDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SalOrderQuery().Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Are you sure to sign out?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)){
                this.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
