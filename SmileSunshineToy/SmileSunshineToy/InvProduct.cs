using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;

namespace SmileSunshineToy
{
    public partial class InvProduct : Form
    {
        // 数据库相关字段
        private MySqlConnection connection;
        private MySqlDataAdapter productAdapter;
        private DataTable productTable;
        private MySqlCommandBuilder commandBuilder;

        public InvProduct()
        {
            InitializeComponent();
            InitializeProductForm();
        }

        private void InitializeProductForm()
        {
            this.Text = "Product Management";
            InitializeDatabase();
            SetupDataGridView();
            BindEvents();
            LoadProductData();
        }

        private void InitializeDatabase()
        {
            try
            {
                string connectionString = "server=127.0.0.1;user id=root;database=test;allowuservariables=True;";
                connection = new MySqlConnection(connectionString);
                connection.Open();

                productAdapter = new MySqlDataAdapter("SELECT * FROM product ORDER BY ProductID", connection);
                commandBuilder = new MySqlCommandBuilder(productAdapter);
                productTable = new DataTable();

                // 仅加载表结构
                productAdapter.FillSchema(productTable, SchemaType.Source);
                // 填充数据
                productAdapter.Fill(productTable);

                // 设置ProductID为自增
                if (productTable.Columns["ProductID"] != null)
                {
                    productTable.Columns["ProductID"].AutoIncrement = true;
                    long maxId = 0;
                    if (productTable.Rows.Count > 0)
                    {
                        maxId = productTable.AsEnumerable().Max(row => row.Field<int?>("ProductID") ?? 0);
                    }
                    productTable.Columns["ProductID"].AutoIncrementSeed = maxId + 1;
                    productTable.Columns["ProductID"].AutoIncrementStep = 1;
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
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "ProductID",
                Name = "ProductID",
                ReadOnly = true,
                Width = 80
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "Name",
                Width = 150,
                ReadOnly = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Name = "Description",
                Width = 200,
                ReadOnly = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                Name = "Price",
                Width = 100,
                ReadOnly = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockQuantity",
                HeaderText = "StockQuantity",
                Name = "StockQuantity",
                Width = 100,
                ReadOnly = false
            });

            dataGridView1.DataSource = productTable;

            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("Name");
            filterComboBox.Items.Add("Description");
            filterComboBox.SelectedIndex = 0;
        }

        private void BindEvents()
        {
            btnAdd.Click += (s, e) => AddProduct();
            btnDelete.Click += (s, e) => DeleteProduct();
            btnSave.Click += (s, e) => SaveChanges();
            btnCancel.Click += (s, e) => CancelChanges();
            btnSearch.Click += (s, e) => SearchProducts();
            txtSearch.TextChanged += (s, e) => SearchProducts();
        }

        private void LoadProductData()
        {
            try
            {
                productTable.Clear();
                productAdapter.Fill(productTable);
                dataGridView1.DataSource = productTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchProducts()
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string filterColumn = filterComboBox.SelectedItem?.ToString() ?? "Name";
                if (string.IsNullOrEmpty(searchText))
                {
                    productTable.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    productTable.DefaultView.RowFilter = $"{filterColumn} LIKE '%{searchText}%'";
                }
            }
            catch (Exception ex)
            {
                productTable.DefaultView.RowFilter = string.Empty;
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProduct()
        {
            try
            {
                DataRow newRow = productTable.NewRow();
                foreach (DataColumn col in productTable.Columns)
                {
                    if (!col.AllowDBNull && !col.AutoIncrement)
                    {
                        if (col.DataType == typeof(string))
                            newRow[col] = string.Empty;
                        else if (col.DataType.IsValueType)
                            newRow[col] = Activator.CreateInstance(col.DataType);
                    }
                }
                productTable.Rows.Add(newRow);
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

        private void DeleteProduct()
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
                        if (drv.Row["ProductID"] != DBNull.Value)
                        {
                            idsToDelete.Add(Convert.ToInt32(drv.Row["ProductID"]));
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
                    string deleteQuery = "DELETE FROM product WHERE ProductID = @ProductID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection, transaction))
                    {
                        command.Parameters.Add("@ProductID", MySqlDbType.Int32);
                        int deletedCount = 0;
                        foreach (int id in idsToDelete)
                        {
                            command.Parameters["@ProductID"].Value = id;
                            deletedCount += command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        MessageBox.Show($"Successfully deleted {deletedCount} record(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductData();
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
                DataTable changes = productTable.GetChanges();
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
                        if (row["Name"] != null && !string.IsNullOrWhiteSpace(row["Name"].ToString()))
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
                    LoadProductData();
                    return;
                }
                int rowsAffected = productAdapter.Update(changes);
                productTable.AcceptChanges();
                MessageBox.Show($"Successfully saved {rowsAffected} record(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductData();
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
                productTable.RejectChanges();
                LoadProductData();
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
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void InvProduct_Load(object sender, EventArgs e) { }
    }
}
