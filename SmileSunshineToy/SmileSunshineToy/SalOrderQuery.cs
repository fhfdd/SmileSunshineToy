using System;
using System.Drawing;
using System.Windows.Forms;
using SmileSunshineToy;

namespace SmileSunshineToy
{
    public partial class SalOrderQuery : BaseForm
    {
        private readonly DataGridManager _dataManager;

        public SalOrderQuery()
        {
            InitializeComponent();

            _dataManager = new DataGridManager("order", "OrderID", "ORD");
            _dataManager.SetConnectionString(Configuration.ConnectionString);

            SetDesignSize(new Size(1792, 1126));
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = _dataManager.DataTable;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void LoadData()
        {
            try
            {
                _dataManager.LoadData();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to load sales order data: {ex.Message}");
            }
        }

        private void btn_fin_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(FinPayOverview));

        private void btn_rd_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(RDdash));

        private void logout_Click(object sender, EventArgs e)
        {
            if (FormNavigationManager.ConfirmLogout())
            {
                UserSession.UserID = null;
                UserSession.UserName = null;
                UserSession.Role = UserRole.None;
                FormNavigationManager.NavigateToForm(this, typeof(Login), true);
            }
        }

        private void order_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(SalOrderQuery));

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void btn_inv_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(InvMaterial));

        private void btn_person_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(PerCusOverview));

        private void btn_proc_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProcOverview));

        private void btn_log_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(LoOverview));

        private void btn_prod_Click(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(ProdInOverview));

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.AddRecord(true))
                {
                    dataGridView1.Refresh();
                    FormNavigationManager.ShowInformation("New sales order record added");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to add sales order record: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowInformation("Please select a sales order record to delete");
                return;
            }

            if (FormNavigationManager.ShowConfirmation("Are you sure you want to delete the selected sales order record?"))
            {
                try
                {
                    if (_dataManager.DeleteRecord(dataGridView1.SelectedRows) &&
                        _dataManager.SaveChanges())
                    {
                        dataGridView1.Refresh();
                        FormNavigationManager.ShowInformation("Sales order record deleted successfully");
                    }
                }
                catch (Exception ex)
                {
                    FormNavigationManager.ShowError($"Failed to delete sales order record: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("Sales order data saved successfully");
                }
                else
                {
                    FormNavigationManager.ShowInformation("No sales order changes to save");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to save sales order data: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadData();
                return;
            }

            try
            {
                dataGridView1.DataSource = _dataManager.SearchRecords(
                    txtSearch.Text,
                    filterComboBox.SelectedItem?.ToString() ?? "OrderID"
                );
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"Failed to search sales order records: {ex.Message}");
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void SalOrderQuery_Load(object sender, EventArgs e) { }
    }
}