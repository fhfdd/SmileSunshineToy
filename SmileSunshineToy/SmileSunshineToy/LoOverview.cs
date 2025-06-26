using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace SmileSunshineToy
{
    public partial class LoOverview : Form
    {
        private SqlConnection connection;
        private string connectionString = "Server=localhost; Database=test; Uid=root;Pwd="; 

        public LoOverview()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadData();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM logistics"; // Adjust query as needed
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table; // Assuming your DataGridView is named dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void btn_home_Click(object sender, EventArgs e) { this.Show(); this.Activate(); }
        private void btn_fin_Click_1(object sender, EventArgs e) { FinPayOverview finPayForm = new FinPayOverview(); finPayForm.Show(); this.Hide(); }
        private void btn_user_Click(object sender, EventArgs e) { new UserProfileForm().Show(); this.Hide(); }
        private void btn_sub1_Click(object sender, EventArgs e) { new InvProduct().Show(); this.Hide(); }
        private void btn_sub2_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void btn_sub3_Click(object sender, EventArgs e) { new InvWarehouse().Show(); this.Hide(); }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Status_Click(object sender, EventArgs e)
        {

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
            FinPayOverview F1 = new FinPayOverview();
            F1.Show();
        }

        private void btn_prod_Click_1(object sender, EventArgs e)
        {
            ProdInOverview P1 = new ProdInOverview();
            P1.Show();

        }

        private void btn_log_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btn_proc_Click_1(object sender, EventArgs e)
        {
            ProcOverview P2 = new ProcOverview();
            P2.Show();
        }

        private void btn_person_Click_1(object sender, EventArgs e)
        {
            PerCusOverview P3 = new PerCusOverview();
            P3.Show();
        }

        //private void btnGeneratePdf_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Create a SaveFileDialog to let user choose where to save
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
        //        saveFileDialog.FileName = "LogisticsDetails.pdf";
        //        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            // Create a new PDF document
        //            PdfDocument document = new PdfDocument();
        //            document.Info.Title = "Logistics Details";

        //            // Add a page
        //            PdfPage page = document.AddPage();
        //            XGraphics gfx = XGraphics.FromPdfPage(page);
        //            XFont fontTitle = new XFont("Arial", 16, XFontStyle.Bold);
        //            XFont fontHeader = new XFont("Arial", 12, XFontStyle.Bold);
        //            XFont fontText = new XFont("Arial", 10);

        //            // Draw title
        //            gfx.DrawString("Logistics Details Report", fontTitle, XBrushes.Black,
        //                new XRect(0, 40, page.Width, page.Height), XStringFormats.TopCenter);

        //            // Draw current date
        //            gfx.DrawString($"Generated on: {DateTime.Now.ToString("yyyy-MM-dd HH:mm")}", fontText, XBrushes.Black,
        //                new XRect(40, 80, page.Width - 80, page.Height), XStringFormats.TopLeft);

        //            // Create a table-like structure for the data
        //            int yPos = 120;

        //            // Add logistics information
        //            if (dataGridView1.CurrentRow != null)
        //            {
        //                DataGridViewRow row = dataGridView1.CurrentRow;

        //                gfx.DrawString("Logistics Information:", fontHeader, XBrushes.Black,
        //                    new XRect(40, yPos, page.Width, page.Height), XStringFormats.TopLeft);
        //                yPos += 20;

        //                foreach (DataGridViewCell cell in row.Cells)
        //                {
        //                    if (cell.Value != null)
        //                    {
        //                        gfx.DrawString($"{cell.OwningColumn.HeaderText}: {cell.Value}", fontText, XBrushes.Black,
        //                            new XRect(50, yPos, page.Width, page.Height), XStringFormats.TopLeft);
        //                        yPos += 15;
        //                    }
        //                }
        //            }

        //            // Save the document
        //            document.Save(saveFileDialog.FileName);
        //            document.Close();

        //            MessageBox.Show($"PDF successfully saved to:\n{saveFileDialog.FileName}", "Success",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Optional: Open the PDF after creation
        //            // System.Diagnostics.Process.Start(saveFileDialog.FileName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// Make sure to close the connection when the form closes
        //private void LoOverview_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (connection != null && connection.State == ConnectionState.Open)
        //    {
        //        connection.Close();
        //    }
        //}
    }
}