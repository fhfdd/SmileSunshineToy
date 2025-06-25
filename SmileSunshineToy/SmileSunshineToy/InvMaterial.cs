using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SmileSunshineToy
{
    public partial class InvMaterial : DataGridViewForm
    {
        // 数据库相关字段
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private MySql.Data.MySqlClient.MySqlDataAdapter materialAdapter;
        private System.Data.DataTable materialTable;
        private MySql.Data.MySqlClient.MySqlCommandBuilder commandBuilder;

        public InvMaterial() : base()
        {
            InitializeComponent();
            InitializeMaterialForm();

            base.TableName = "material";
            base.PrimaryKey = "MaterialID";
            base.DataGridView = dataGridView1;

            LoadData();
        }

        private void InitializeMaterialForm()
        {
            // 设置窗体标题
            this.Text = "Material Inventory Management";

            // 初始化数据库连接
            InitializeDatabase();

            // 设置DataGridView
            SetupDataGridView();

            // 绑定事件
            BindEvents();

            // 加载数据
            LoadMaterialData();
        }

        private void InitializeDatabase()
        {
            try
            {
                string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=123456;SslMode=none;AllowPublicKeyRetrieval=true;";
                connection = new MySqlConnection(connectionString);
                connection.Open();

                materialAdapter = new MySqlDataAdapter("SELECT * FROM material ORDER BY MaterialID", connection);
                commandBuilder = new MySqlCommandBuilder(materialAdapter);
                materialTable = new DataTable();

                // 1. 仅加载表结构
                materialAdapter.FillSchema(materialTable, SchemaType.Source);

                // 3. 填充数据
                materialAdapter.Fill(materialTable);

                // 2. 在客户端的DataTable中，为MaterialID列也设置自动递增
                if (materialTable.Columns["MaterialID"] != null)
                {
                    materialTable.Columns["MaterialID"].AutoIncrement = true;

                    // 找出当前ID的最大值，并设置下一种子
                    long maxId = 0;
                    if (materialTable.Rows.Count > 0)
                    {
                        // 使用LINQ来安全地获取最大值
                        maxId = materialTable.AsEnumerable().Max(row => row.Field<int?>("MaterialID") ?? 0);
                    }
                    materialTable.Columns["MaterialID"].AutoIncrementSeed = maxId + 1;
                    materialTable.Columns["MaterialID"].AutoIncrementStep = 1;
                }


            }
            catch (Exception ex)
            {

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
                DataPropertyName = "MaterialID",
                HeaderText = "MaterialID",
                Name = "MaterialID",
                ReadOnly = true,
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaterialName",
                HeaderText = "MaterialName",
                Name = "MaterialName",
                Width = 150,
                ReadOnly = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Specification",
                HeaderText = "Specification",
                Name = "Specification",
                Width = 200,
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

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SupplierID",
                HeaderText = "SupplierID",
                Name = "SupplierID",
                Width = 100,
                ReadOnly = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Unit",
                HeaderText = "Unit",
                Name = "Unit",
                Width = 80,
                ReadOnly = false
            });

            // 设置数据源
            dataGridView1.DataSource = materialTable;

            // 设置筛选选项
            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("MaterialName");
            filterComboBox.Items.Add("Specification");
            filterComboBox.Items.Add("Unit");
            filterComboBox.SelectedIndex = 0;
        }

        private void BindEvents()
        {
            // 绑定按钮事件
            btnAdd.Click += (s, e) => AddMaterial();
            btnDelete.Click += (s, e) => DeleteMaterial();
            btnSave.Click += (s, e) => SaveChanges();
            btnCancel.Click += (s, e) => CancelChanges();
            btnSearch.Click += (s, e) => SearchMaterials();
        }

        private void LoadMaterialData()
        {
            try
            {
                //materialTable.Clear();
                //materialAdapter.Fill(materialTable);
                dataGridView1.DataSource = materialTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 搜索材料
        private void SearchMaterials()
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string filterColumn = filterComboBox.SelectedItem?.ToString() ?? "MaterialName";

                if (string.IsNullOrEmpty(searchText))
                {
                    materialTable.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    // 使用DataTable的RowFilter进行前端筛选
                    // 这避免了重新查询数据库，也保留了DataTable的完整结构（包括主键）
                    // LIKE '%%' is needed for string columns
                    materialTable.DefaultView.RowFilter = $"{filterColumn} LIKE '%{searchText}%'";
                }
            }
            catch (Exception ex)
            {
                // 如果筛选出错，显示错误信息并清除筛选
                materialTable.DefaultView.RowFilter = string.Empty;
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 添加材料
        private void AddMaterial()
        {
            try
            {
                DataRow newRow = materialTable.NewRow();

                // 为所有非自增的 NOT NULL 列提供默认值，以避免"不允许nulls"错误
                foreach (DataColumn col in materialTable.Columns)
                {
                    if (!col.AllowDBNull && !col.AutoIncrement)
                    {
                        if (col.DataType == typeof(string))
                        {
                            newRow[col] = string.Empty;
                        }
                        else if (col.DataType.IsValueType)
                        {
                            newRow[col] = Activator.CreateInstance(col.DataType);
                        }
                    }
                }

                materialTable.Rows.Add(newRow);

                // 将滚动条滚动到底部并设置新行为当前行
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    dataGridView1.BeginEdit(true); // 强制进入编辑模式
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add new row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 删除材料
        private void DeleteMaterial()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected rows? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<int> idsToDelete = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.DataBoundItem != null && row.DataBoundItem is DataRowView drv)
                    {
                        if (drv.Row["MaterialID"] != DBNull.Value)
                        {
                            idsToDelete.Add(Convert.ToInt32(drv.Row["MaterialID"]));
                        }
                    }
                }

                if (idsToDelete.Count == 0)
                {
                    MessageBox.Show("No valid rows selected for deletion (perhaps you selected a new, unsaved row?).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MySqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();

                    string deleteQuery = "DELETE FROM material WHERE MaterialID = @MaterialID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection, transaction))
                    {
                        command.Parameters.Add("@MaterialID", MySqlDbType.Int32);

                        int deletedCount = 0;
                        foreach (int id in idsToDelete)
                        {
                            command.Parameters["@MaterialID"].Value = id;
                            deletedCount += command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"Successfully deleted {deletedCount} records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadMaterialData();
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 保存更改
        private new void SaveChanges()
        {
            try
            {
                // 确保焦点离开当前单元格，以提交任何挂起的编辑
                this.Validate();
                dataGridView1.EndEdit();

                DataTable changes = materialTable.GetChanges();

                if (changes == null || changes.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 进一步验证，确保新增的行不是完全空的
                bool hasRealChanges = false;
                foreach (DataRow row in changes.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        // 假设MaterialName是必填的核心字段
                        if (row["MaterialName"] != null && !string.IsNullOrWhiteSpace(row["MaterialName"].ToString()))
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
                    MessageBox.Show("No data to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 如果所有"新增"的行都是空的，则撤销这些空行
                    LoadMaterialData();
                    return;
                }

                int rowsAffected = materialAdapter.Update(changes);
                materialTable.AcceptChanges();

                MessageBox.Show($"Successfully saved {rowsAffected} records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMaterialData(); // 重新加载数据
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 取消更改
        private new void CancelChanges()
        {
            if (MessageBox.Show("Are you sure you want to discard all changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                materialTable.RejectChanges();
                LoadMaterialData();
            }
        }

        // 事件处理方法
        private void btn_inv_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void btn_person_Click(object sender, EventArgs e) { new PerCusOverview().Show(); this.Hide(); }
        private void btn_proc_Click(object sender, EventArgs e) { new ProcOverview().Show(); this.Hide(); }
        private void btn_log_Click(object sender, EventArgs e) { new LoOverview().Show(); this.Hide(); }
        private void btn_prod_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_fin_Click(object sender, EventArgs e) { new FinPayOverview().Show(); this.Hide(); }
        private void btn_rd_Click(object sender, EventArgs e) { new RDdash().Show(); this.Hide(); }
        private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { this.Close(); new Login().Show(); } }
        private void btn_home_Click(object sender, EventArgs e) { this.Show(); this.Activate(); }
        private void btn_fin_Click_1(object sender, EventArgs e) { FinPayOverview finPayForm = new FinPayOverview(); finPayForm.Show(); this.Hide(); }
        private void btn_user_Click(object sender, EventArgs e) { new UserProfileForm().Show(); this.Hide(); }
        private void btn_sub1_Click(object sender, EventArgs e) { new InvProduct().Show(); this.Hide(); }
        private void btn_sub2_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void btn_sub3_Click(object sender, EventArgs e) { new InvWarehouse().Show(); this.Hide(); }

        // 其他事件处理方法
        private void order_Click(object sender, EventArgs e) { /* 订单相关功能 */ }
        private void panel1_Paint(object sender, PaintEventArgs e) { /* Panel1绘制事件 */ }
        private void panel3_Paint(object sender, PaintEventArgs e) { /* Panel3绘制事件 */ }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { /* ComboBox选择改变事件 */ }

        // 窗体加载事件
        private void InvMaterial_Load(object sender, EventArgs e)
        {
            // 窗体加载时的初始化
        }

        // 窗体关闭事件
        private void InvMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        // 添加缺失的txtSearch_TextChanged方法
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // 当搜索框文本改变时，自动执行搜索
            SearchMaterials();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}