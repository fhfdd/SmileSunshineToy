using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;

namespace SmileSunshineToy
{
    public partial class InvWarehouse : Form
    {
        // 数据库相关字段
        private MySqlConnection connection;
        private MySqlDataAdapter inventoryAdapter;
        private DataTable inventoryTable;
        private MySqlCommandBuilder commandBuilder;

        public InvWarehouse()
        {
            InitializeComponent();
            InitializeInventoryForm();
        }

        private void InitializeInventoryForm()
        {
            this.Text = "Inventory Management";
            InitializeDatabase();
            SetupDataGridView();
            BindEvents();
            LoadInventoryData();
        }

        private void InitializeDatabase()
        {
            try
            {
                string connectionString = "server=127.0.0.1;user id=root;database=test;allowuservariables=True;";
                connection = new MySqlConnection(connectionString);
                connection.Open();

                inventoryAdapter = new MySqlDataAdapter("SELECT * FROM inventory ORDER BY InventoryID", connection);
                commandBuilder = new MySqlCommandBuilder(inventoryAdapter);
                inventoryTable = new DataTable();

                // 仅加载表结构
                inventoryAdapter.FillSchema(inventoryTable, SchemaType.Source);
                // 填充数据
                inventoryAdapter.Fill(inventoryTable);

                // 设置InventoryID为自增
                if (inventoryTable.Columns["InventoryID"] != null)
                {
                    inventoryTable.Columns["InventoryID"].AutoIncrement = true;
                    long maxId = 0;
                    if (inventoryTable.Rows.Count > 0)
                    {
                        maxId = inventoryTable.AsEnumerable().Max(row => row.Field<int?>("InventoryID") ?? 0);
                    }
                    inventoryTable.Columns["InventoryID"].AutoIncrementSeed = maxId + 1;
                    inventoryTable.Columns["InventoryID"].AutoIncrementStep = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InventoryID",
                HeaderText = "InventoryID",
                Name = "InventoryID",
                ReadOnly = true,
                Width = 80
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "ProductID",
                Name = "ProductID",
                Width = 100,
                ReadOnly = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Name = "Quantity",
                Width = 100,
                ReadOnly = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Location",
                HeaderText = "Location",
                Name = "Location",
                Width = 150,
                ReadOnly = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "WarehouseID",
                HeaderText = "WarehouseID",
                Name = "WarehouseID",
                Width = 100,
                ReadOnly = false
            });

            dataGridView1.DataSource = inventoryTable;

            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("ProductID");
            filterComboBox.Items.Add("Location");
            filterComboBox.Items.Add("WarehouseID");
            filterComboBox.SelectedIndex = 0;

        }

        private void BindEvents()
        {
            btnAdd.Click += (s, e) => AddInventory();
            btnDelete.Click += (s, e) => DeleteInventory();
            btnSave.Click += (s, e) => SaveChanges();
            btnCancel.Click += (s, e) => CancelChanges();
            btnSearch.Click += (s, e) => SearchInventory();
            txtSearch.TextChanged += (s, e) => SearchInventory();
        }

        private void LoadInventoryData()
        {

            try
            {
                inventoryTable.Clear();
                inventoryAdapter.Fill(inventoryTable);
                dataGridView1.DataSource = inventoryTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchInventory()
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string filterColumn = filterComboBox.SelectedItem?.ToString() ?? "ProductID";
                if (string.IsNullOrEmpty(searchText))
                {
                    inventoryTable.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    var colType = inventoryTable.Columns[filterColumn].DataType;
                    if (colType == typeof(string))
                    {
                        inventoryTable.DefaultView.RowFilter = $"{filterColumn} LIKE '%{searchText}%'";
                    }
                    else if (colType == typeof(int) || colType == typeof(long))
                    {
                        inventoryTable.DefaultView.RowFilter = $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'";
                    }
                    else
                    {
                        inventoryTable.DefaultView.RowFilter = $"{filterColumn} = '{searchText}'";
                    }
                }
            }
            catch (Exception ex)
            {
                inventoryTable.DefaultView.RowFilter = string.Empty;
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInventory()
        {
            try
            {
                DataRow newRow = inventoryTable.NewRow();
                foreach (DataColumn col in inventoryTable.Columns)
                {
                    if (!col.AllowDBNull && !col.AutoIncrement)
                    {
                        if (col.DataType == typeof(string))
                            newRow[col] = string.Empty;
                        else if (col.DataType.IsValueType)
                            newRow[col] = Activator.CreateInstance(col.DataType);
                    }
                }
                inventoryTable.Rows.Add(newRow);
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    dataGridView1.BeginEdit(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteInventory()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete the selected row(s)? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<int> idsToDelete = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.DataBoundItem != null && row.DataBoundItem is DataRowView drv)
                    {
                        if (drv.Row["InventoryID"] != DBNull.Value)
                        {
                            idsToDelete.Add(Convert.ToInt32(drv.Row["InventoryID"]));
                        }
                    }
                }
                if (idsToDelete.Count == 0)
                {
                    MessageBox.Show("No valid row to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MySqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();
                    string deleteQuery = "DELETE FROM inventory WHERE InventoryID = @InventoryID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection, transaction))
                    {
                        command.Parameters.Add("@InventoryID", MySqlDbType.Int32);
                        int deletedCount = 0;
                        foreach (int id in idsToDelete)
                        {
                            command.Parameters["@InventoryID"].Value = id;
                            deletedCount += command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        MessageBox.Show($"Successfully deleted {deletedCount} record(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInventoryData();
                    }
                }
                catch (MySqlException ex)
                {
                    if (transaction != null) transaction.Rollback();
                    if (ex.Message.Contains("a foreign key constraint fails"))
                    {
                        MessageBox.Show("Cannot delete or update a parent row: a foreign key constraint fails. Please check related records before deleting.", "Foreign Key Constraint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChanges()
        {
            try
            {
                this.Validate();
                dataGridView1.EndEdit();
                DataTable changes = inventoryTable.GetChanges();
                if (changes == null || changes.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool hasRealChanges = false;
                foreach (DataRow row in changes.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        if (row["ProductID"] != null && !string.IsNullOrWhiteSpace(row["ProductID"].ToString()))
                        {
                            hasRealChanges = true;
                            break;
                        }
                    }
                    else if (row.RowState == DataRowState.Modified || row.RowState == DataRowState.Deleted)
                    {
                        hasRealChanges = true;
                        break;
                    }
                }
                if (!hasRealChanges)
                {
                    MessageBox.Show("No data to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData();
                    return;
                }
                int rowsAffected = inventoryAdapter.Update(changes);
                inventoryTable.AcceptChanges();
                MessageBox.Show($"Successfully saved {rowsAffected} record(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelChanges()
        {
            if (MessageBox.Show("Are you sure you want to discard all changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                inventoryTable.RejectChanges();
                LoadInventoryData();
            }
        }

        // 保留原有导航按钮事件
        private void btn_inv_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
