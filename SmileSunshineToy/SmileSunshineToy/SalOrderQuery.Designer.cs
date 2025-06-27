using System;
using System.Data;
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
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = _dataManager.DataTable;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
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
                FormNavigationManager.ShowError($"加载订单数据失败: {ex.Message}");
            }
        }

        #region 菜单导航事件
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
        #endregion

        #region 数据操作事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.AddRecord(true))
                {
                    dataGridView1.Refresh();
                    FormNavigationManager.ShowInformation("已添加新订单记录");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"添加订单记录失败: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                FormNavigationManager.ShowInformation("请选择要删除的订单记录");
                return;
            }

            if (FormNavigationManager.ShowConfirmation("确定要删除选中的订单记录吗?"))
            {
                try
                {
                    if (_dataManager.DeleteRecord(dataGridView1.SelectedRows) &&
                        _dataManager.SaveChanges())
                    {
                        dataGridView1.Refresh();
                        FormNavigationManager.ShowInformation("订单记录删除成功");
                    }
                }
                catch (Exception ex)
                {
                    FormNavigationManager.ShowError($"删除订单记录失败: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("订单数据保存成功");
                }
                else
                {
                    FormNavigationManager.ShowInformation("没有需要保存的更改");
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"保存订单数据失败: {ex.Message}");
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
                FormNavigationManager.ShowError($"搜索订单记录失败: {ex.Message}");
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            TextPdfExporter.ExportDataGridViewToPdf(dataGridView1);
        }
        #endregion

        private void SalOrderQuery_Load(object sender, EventArgs e) { }
    }

    partial class SalOrderQuery
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button btnDelete;

        // 菜单控件
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Button btn_person;
        private System.Windows.Forms.Button btn_proc;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_fin;
        private System.Windows.Forms.Button btn_rd;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_inv = new System.Windows.Forms.Button();
            this.btn_person = new System.Windows.Forms.Button();
            this.btn_proc = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_fin = new System.Windows.Forms.Button();
            this.btn_rd = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // dataGridView1 订单数据网格
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 500);
            this.dataGridView1.TabIndex = 0;

            // filterComboBox 搜索条件下拉框
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "OrderID", "CustomerID", "OrderDate", "Status"});
            this.filterComboBox.Location = new System.Drawing.Point(300, 150);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(150, 28);
            this.filterComboBox.TabIndex = 1;
            this.filterComboBox.SelectedIndex = 0;

            // txtSearch 搜索文本框
            this.txtSearch.Location = new System.Drawing.Point(460, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 28);
            this.txtSearch.TabIndex = 2;

            // btnCancel 取消按钮
            this.btnCancel.Location = new System.Drawing.Point(920, 750);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnSave 保存按钮
            this.btnSave.Location = new System.Drawing.Point(800, 750);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnAdd 添加按钮
            this.btnAdd.Location = new System.Drawing.Point(680, 750);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnSearch 搜索按钮
            this.btnSearch.Location = new System.Drawing.Point(780, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // export 导出按钮
            this.export.Location = new System.Drawing.Point(1040, 750);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(120, 40);
            this.export.TabIndex = 7;
            this.export.Text = "导出PDF";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);

            // btnDelete 删除按钮
            this.btnDelete.Location = new System.Drawing.Point(560, 750);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // panel1 侧边菜单面板
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btn_inv);
            this.panel1.Controls.Add(this.btn_person);
            this.panel1.Controls.Add(this.btn_proc);
            this.panel1.Controls.Add(this.btn_log);
            this.panel1.Controls.Add(this.btn_prod);
            this.panel1.Controls.Add(this.btn_fin);
            this.panel1.Controls.Add(this.btn_rd);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 900);
            this.panel1.TabIndex = 9;

            // btn_inv 库存菜单按钮
            this.btn_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inv.Location = new System.Drawing.Point(0, 630);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(250, 60);
            this.btn_inv.TabIndex = 26;
            this.btn_inv.Text = "Inventory";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);

            // btn_person 人员菜单按钮
            this.btn_person.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_person.Location = new System.Drawing.Point(0, 540);
            this.btn_person.Name = "btn_person";
            this.btn_person.Size = new System.Drawing.Size(250, 60);
            this.btn_person.TabIndex = 20;
            this.btn_person.Text = "Personnel";
            this.btn_person.UseVisualStyleBackColor = true;
            this.btn_person.Click += new System.EventHandler(this.btn_person_Click);

            // btn_proc 采购菜单按钮
            this.btn_proc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_proc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proc.Location = new System.Drawing.Point(0, 450);
            this.btn_proc.Name = "btn_proc";
            this.btn_proc.Size = new System.Drawing.Size(250, 60);
            this.btn_proc.TabIndex = 19;
            this.btn_proc.Text = "Procurement";
            this.btn_proc.UseVisualStyleBackColor = true;
            this.btn_proc.Click += new System.EventHandler(this.btn_proc_Click);

            // btn_log 物流菜单按钮
            this.btn_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Location = new System.Drawing.Point(0, 360);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(250, 60);
            this.btn_log.TabIndex = 18;
            this.btn_log.Text = "Logistics";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);

            // btn_prod 生产菜单按钮
            this.btn_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.Location = new System.Drawing.Point(0, 270);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(250, 60);
            this.btn_prod.TabIndex = 17;
            this.btn_prod.Text = "Production";
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);

            // btn_fin 财务菜单按钮
            this.btn_fin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fin.Location = new System.Drawing.Point(0, 180);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(250, 60);
            this.btn_fin.TabIndex = 15;
            this.btn_fin.Text = "Financial";
            this.btn_fin.UseVisualStyleBackColor = true;
            this.btn_fin.Click += new System.EventHandler(this.btn_fin_Click);

            // btn_rd 研发菜单按钮
            this.btn_rd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rd.Location = new System.Drawing.Point(0, 90);
            this.btn_rd.Name = "btn_rd";
            this.btn_rd.Size = new System.Drawing.Size(250, 60);
            this.btn_rd.TabIndex = 13;
            this.btn_rd.Text = "R&D";
            this.btn_rd.UseVisualStyleBackColor = true;
            this.btn_rd.Click += new System.EventHandler(this.btn_rd_Click);

            // logout 登出按钮
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(0, 840);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(250, 60);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);

            // order 订单菜单按钮
            this.order.Dock = System.Windows.Forms.DockStyle.Top;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(0, 0);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(250, 60);
            this.order.TabIndex = 2;
            this.order.Text = "Sales Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);

            // btn_home 首页按钮
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(250, 60);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);

            // panel2 顶部面板
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 100);
            this.panel2.TabIndex = 10;

            // SalOrderQuery 窗体
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.export);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalOrderQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order Query";
            this.Load += new System.EventHandler(this.SalOrderQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _dataManager.DataTable.RejectChanges();
            dataGridView1.Refresh();
        }
    }
}