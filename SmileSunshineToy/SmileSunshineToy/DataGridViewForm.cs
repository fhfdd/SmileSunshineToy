using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    // Base form for data grid operations (CRUD + search), reusable by child forms.
    public class DataGridViewForm : Form
    {
        // Database connection string (override in child forms if needed).
        protected string ConnectionString { get; set; } = "Server=localhost;Database=test;Uid=root;Pwd=;";

        // DataTable to hold database records (bound to DataGridView).
        protected DataTable DataTable { get; set; } = new DataTable();

        // Data adapter for DB operations (fill/update).
        protected MySqlDataAdapter DataAdapter { get; set; }

        // Name of the database table (set in child forms, e.g., "product").
        protected string TableName { get; set; }

        // Primary key column name (set in child forms, e.g., "id").
        protected string PrimaryKey { get; set; }

        // DataGridView control in the form (assigned from child form's UI).
        protected DataGridView DataGridView { get; set; }

        // ComboBox for filter options (assigned from child form's UI).
        protected ComboBox FilterComboBox { get; set; }

        // TextBox for search input (assigned from child form's UI).
        protected TextBox SearchTextBox { get; set; }

        // Button to trigger add record action (assigned from child form's UI).
        protected Button AddButton { get; set; }

        // Button to trigger delete record action (assigned from child form's UI).
        protected Button DeleteButton { get; set; }

        // Button to trigger save changes action (assigned from child form's UI).
        protected Button SaveButton { get; set; }

        // Button to trigger cancel changes action (assigned from child form's UI).
        protected Button CancelButton { get; set; }

        // Button to trigger search action (assigned from child form's UI).
        protected Button SearchButton { get; set; }

        protected virtual void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DataGridViewForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "DataGridViewForm";
            this.Load += new System.EventHandler(this.DataGridViewForm_Load_1);
            this.ResumeLayout(false);

        }

        // Load data from DB into DataGridView.
        public virtual void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    DataAdapter = new MySqlDataAdapter($"SELECT * FROM `{TableName}`", conn);
                    DataTable.Clear();
                    DataAdapter.Fill(DataTable);
                    DataGridView.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data load failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add new record (temporarily to DataTable, saved on SaveChanges).
        public virtual void AddRecord()
        {
            try
            {
                DataRow newRow = DataTable.NewRow();
                DataTable.Rows.Add(newRow);
                // Set focus to the first editable column of the new row
                if (DataGridView.Rows.Count > 0 && DataGridView.Columns.Count > 1)
                {
                    DataGridView.CurrentCell = DataGridView.Rows[DataGridView.Rows.Count - 1].Cells[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mark rows for deletion (deleted on SaveChanges).
        public virtual void DeleteRecord()
        {
            if (DataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select rows to delete", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Confirm delete selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in DataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            DataTable.Rows[row.Index].Delete();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Save changes (add, update, delete) using transactions.
        public virtual void SaveChanges()
        {
            try
            {
                // Check if primary key column exists
                if (!DataTable.Columns.Contains(PrimaryKey))
                {
                    MessageBox.Show($"Column {PrimaryKey} not found in table {TableName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get changes from DataTable
                DataTable changes = DataTable.GetChanges();
                if (changes == null)
                {
                    MessageBox.Show("No changes to save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // Configure DataAdapter commands with transaction
                            DataAdapter.SelectCommand.Transaction = trans;

                            MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(DataAdapter);
                            DataAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                            DataAdapter.InsertCommand.Transaction = trans;

                            DataAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                            DataAdapter.UpdateCommand.Transaction = trans;

                            DataAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                            DataAdapter.DeleteCommand.Transaction = trans;

                            // Execute updates
                            int rowsAffected = DataAdapter.Update(changes);

                            // Commit transaction if successful
                            trans.Commit();

                            // Accept changes to original DataTable
                            DataTable.AcceptChanges();

                            MessageBox.Show($"Successfully saved {rowsAffected} changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh data from database
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show($"Save failed: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel changes (reload data).
        public virtual void CancelChanges()
        {
            if (MessageBox.Show("Discard all changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadData(); // Reload data from database
            }
        }

        // Search records using selected filter and search text.
        public virtual void SearchRecords()
        {
            string searchText = SearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText) || FilterComboBox.SelectedIndex < 0)
            {
                LoadData(); // If search is empty, load all records
                return;
            }

            string selectedColumn = FilterComboBox.SelectedItem.ToString();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {TableName} WHERE {selectedColumn} LIKE @search";
                    DataAdapter = new MySqlDataAdapter(query, conn);
                    DataAdapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchText}%");

                    DataTable.Clear();
                    DataAdapter.Fill(DataTable);
                    DataGridView.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            // Initialize data when form loads
            if (!DesignMode)
            {
                LoadData();
            }
        }

        private void DataGridViewForm_Load_1(object sender, EventArgs e)
        {

        }

        protected void LoadGridData(DataGridView targetGrid,
                            string tableName,
                            string idColumn = null,
                            object idValue = null)
        {
            try
            {
                string query = $"SELECT * FROM `{tableName}`";

                if (!string.IsNullOrEmpty(idColumn) && idValue != null)
                {
                    query += $" WHERE {idColumn} = @id";
                }

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

  
                    if (!string.IsNullOrEmpty(idColumn) && idValue != null)
                    {
                        cmd.Parameters.AddWithValue("@id", idValue);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    targetGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load{tableName}Fail: {ex.Message}", "Mistake");
            }
        }


        public string FormatDateForMySQL(object dateValue)
        {
            if (dateValue is DateTime date)
            {
                return date.ToString("yyyy-MM-dd");
            }

            if (dateValue is string dateStr)
            {
                if (DateTime.TryParse(dateStr, out DateTime parsedDate))
                {
                    return parsedDate.ToString("yyyy-MM-dd");
                }
            }
            return string.Empty;
        }


    }
}