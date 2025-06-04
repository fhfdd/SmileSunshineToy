namespace SmileSunshineToy
{
    partial class SalOrderQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saleAllSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.saleAllFliter = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new SmileSunshineToy.testDataSet();
            this.saleSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.orderTableAdapter();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delect_col = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saleAllSearch
            // 
            this.saleAllSearch.Location = new System.Drawing.Point(578, 37);
            this.saleAllSearch.Name = "saleAllSearch";
            this.saleAllSearch.Size = new System.Drawing.Size(87, 28);
            this.saleAllSearch.TabIndex = 2;
            this.saleAllSearch.Text = "search order ID";
            this.saleAllSearch.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Table";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Smile Sunshine Toy system";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.delect_col);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleAllFliter);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleAllSearch);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleSearch);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1277, 787);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 57);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1517, 787);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // saleAllFliter
            // 
            this.saleAllFliter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saleAllFliter.FormattingEnabled = true;
            this.saleAllFliter.Location = new System.Drawing.Point(271, 39);
            this.saleAllFliter.Name = "saleAllFliter";
            this.saleAllFliter.Size = new System.Drawing.Size(107, 26);
            this.saleAllFliter.TabIndex = 4;
            this.saleAllFliter.SelectedIndexChanged += new System.EventHandler(this.saleAllFliter_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 551);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleSearch
            // 
            this.saleSearch.Location = new System.Drawing.Point(374, 37);
            this.saleSearch.Name = "saleSearch";
            this.saleSearch.Size = new System.Drawing.Size(207, 28);
            this.saleSearch.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.saleOrderToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.rDToolStripMenuItem,
            this.financialToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.logisticsToolStripMenuItem,
            this.procurementToolStripMenuItem,
            this.personnelInformationToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 30, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(240, 787);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // saleOrderToolStripMenuItem
            // 
            this.saleOrderToolStripMenuItem.Name = "saleOrderToolStripMenuItem";
            this.saleOrderToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.saleOrderToolStripMenuItem.Text = "Sale order";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // rDToolStripMenuItem
            // 
            this.rDToolStripMenuItem.Name = "rDToolStripMenuItem";
            this.rDToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.rDToolStripMenuItem.Text = "R&D";
            // 
            // financialToolStripMenuItem
            // 
            this.financialToolStripMenuItem.Name = "financialToolStripMenuItem";
            this.financialToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.financialToolStripMenuItem.Text = "Financial";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // logisticsToolStripMenuItem
            // 
            this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
            this.logisticsToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.logisticsToolStripMenuItem.Text = "Logistics";
            // 
            // procurementToolStripMenuItem
            // 
            this.procurementToolStripMenuItem.Name = "procurementToolStripMenuItem";
            this.procurementToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.procurementToolStripMenuItem.Text = "Procurement";
            // 
            // personnelInformationToolStripMenuItem
            // 
            this.personnelInformationToolStripMenuItem.Name = "personnelInformationToolStripMenuItem";
            this.personnelInformationToolStripMenuItem.Size = new System.Drawing.Size(231, 29);
            this.personnelInformationToolStripMenuItem.Text = "Personnel information";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.signOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.signOutToolStripMenuItem.Text = "sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1517, 57);
            this.panel1.TabIndex = 4;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "order";
            this.orderBindingSource1.DataSource = this.testDataSetBindingSource;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 107;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Detail.HeaderText = "detail";
            this.Detail.MinimumWidth = 8;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "Detail";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 68;
            // 
            // delect_col
            // 
            this.delect_col.Location = new System.Drawing.Point(32, 115);
            this.delect_col.Name = "delect_col";
            this.delect_col.Size = new System.Drawing.Size(192, 40);
            this.delect_col.TabIndex = 5;
            this.delect_col.Text = "Delect";
            this.delect_col.UseVisualStyleBackColor = true;
            this.delect_col.Click += new System.EventHandler(this.delect_col_Click);
            // 
            // SalOrderQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 844);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalOrderQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sale_order";
            this.Load += new System.EventHandler(this.SalOrderQuery_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saleAllSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox saleSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox saleAllFliter;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private testDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delect_col;
    }
}