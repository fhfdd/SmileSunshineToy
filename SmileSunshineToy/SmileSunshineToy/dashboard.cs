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
            this.Hide();
            new RD().Show();
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

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InvProOverview().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_Click(object sender, EventArgs e)
        {

        }

        private void BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void procurementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personnelInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InvMaOverview().Show();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InvWaOverview().Show();
        }

        private void productOutboundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InvPoutOverview().Show();
        }

        private void materialOutboundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InvMoutOverview().Show();
        }

        private void accountsReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FinReOverview().Show();
        }

        private void accountsPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FinPayOverview().Show();
        }

        private void productionPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProdPlanOverview().Show();
        }

        private void inboundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProdInOverview().Show();
        }

        private void customerAftersalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PerCusOverview().Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PerSupOverview().Show();
        }

        private void stuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PerStuOverview().Show();
        }
    }
}
