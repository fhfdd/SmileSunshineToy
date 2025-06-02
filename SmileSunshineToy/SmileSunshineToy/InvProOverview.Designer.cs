
namespace SmileSunshineToy
{
    partial class InvProOverview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productOutboundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialOutboundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsReceivableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsPayableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAftersalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleAllFliter = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleAllSearch = new System.Windows.Forms.Button();
            this.saleSearch = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 57);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Smile&&Sunshine Toy system";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleAllFliter);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleAllSearch);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleSearch);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Create);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(837, 587);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 57);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1106, 587);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(269, 587);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.homeToolStripMenuItem.Text = "Home(&H)";
            // 
            // saleOrderToolStripMenuItem
            // 
            this.saleOrderToolStripMenuItem.Name = "saleOrderToolStripMenuItem";
            this.saleOrderToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.saleOrderToolStripMenuItem.Text = "Sale order(&S)";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.productOutboundToolStripMenuItem,
            this.materialOutboundToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory(&I)";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.productToolStripMenuItem.Text = "product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.materialToolStripMenuItem.Text = "material";
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.warehouseToolStripMenuItem.Text = "warehouse";
            // 
            // productOutboundToolStripMenuItem
            // 
            this.productOutboundToolStripMenuItem.Name = "productOutboundToolStripMenuItem";
            this.productOutboundToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.productOutboundToolStripMenuItem.Text = "product outbound";
            // 
            // materialOutboundToolStripMenuItem
            // 
            this.materialOutboundToolStripMenuItem.Name = "materialOutboundToolStripMenuItem";
            this.materialOutboundToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.materialOutboundToolStripMenuItem.Text = "material outbound";
            // 
            // rDToolStripMenuItem
            // 
            this.rDToolStripMenuItem.Name = "rDToolStripMenuItem";
            this.rDToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.rDToolStripMenuItem.Text = "R&&D(&R)";
            // 
            // financialToolStripMenuItem
            // 
            this.financialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsReceivableToolStripMenuItem,
            this.accountsPayableToolStripMenuItem});
            this.financialToolStripMenuItem.Name = "financialToolStripMenuItem";
            this.financialToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.financialToolStripMenuItem.Text = "Financial(&F)";
            // 
            // accountsReceivableToolStripMenuItem
            // 
            this.accountsReceivableToolStripMenuItem.Name = "accountsReceivableToolStripMenuItem";
            this.accountsReceivableToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.accountsReceivableToolStripMenuItem.Text = "Accounts receivable";
            // 
            // accountsPayableToolStripMenuItem
            // 
            this.accountsPayableToolStripMenuItem.Name = "accountsPayableToolStripMenuItem";
            this.accountsPayableToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.accountsPayableToolStripMenuItem.Text = "Accounts payable";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productionPlanToolStripMenuItem,
            this.inboundToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.productionToolStripMenuItem.Text = "Production(&M)";
            // 
            // productionPlanToolStripMenuItem
            // 
            this.productionPlanToolStripMenuItem.Name = "productionPlanToolStripMenuItem";
            this.productionPlanToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.productionPlanToolStripMenuItem.Text = "Production Plan";
            // 
            // inboundToolStripMenuItem
            // 
            this.inboundToolStripMenuItem.Name = "inboundToolStripMenuItem";
            this.inboundToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.inboundToolStripMenuItem.Text = "Inbound";
            // 
            // logisticsToolStripMenuItem
            // 
            this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
            this.logisticsToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.logisticsToolStripMenuItem.Text = "Logistics(&L)";
            // 
            // procurementToolStripMenuItem
            // 
            this.procurementToolStripMenuItem.Name = "procurementToolStripMenuItem";
            this.procurementToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.procurementToolStripMenuItem.Text = "Procurement(&O)";
            // 
            // personnelInformationToolStripMenuItem
            // 
            this.personnelInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAftersalesToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.stuffToolStripMenuItem});
            this.personnelInformationToolStripMenuItem.Name = "personnelInformationToolStripMenuItem";
            this.personnelInformationToolStripMenuItem.Size = new System.Drawing.Size(260, 29);
            this.personnelInformationToolStripMenuItem.Text = "Personnel information(N)";
            // 
            // customerAftersalesToolStripMenuItem
            // 
            this.customerAftersalesToolStripMenuItem.Name = "customerAftersalesToolStripMenuItem";
            this.customerAftersalesToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.customerAftersalesToolStripMenuItem.Text = "Customer Aftersales";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.stuffToolStripMenuItem.Text = "Stuff";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.signOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.signOutToolStripMenuItem.Text = "sign out";
            // 
            // saleAllFliter
            // 
            this.saleAllFliter.FormattingEnabled = true;
            this.saleAllFliter.Location = new System.Drawing.Point(245, 19);
            this.saleAllFliter.Name = "saleAllFliter";
            this.saleAllFliter.Size = new System.Drawing.Size(107, 26);
            this.saleAllFliter.TabIndex = 9;
            this.saleAllFliter.Text = "product ID";
            this.saleAllFliter.SelectedIndexChanged += new System.EventHandler(this.saleAllFliter_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(825, 403);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saleAllSearch
            // 
            this.saleAllSearch.Location = new System.Drawing.Point(552, 17);
            this.saleAllSearch.Name = "saleAllSearch";
            this.saleAllSearch.Size = new System.Drawing.Size(87, 28);
            this.saleAllSearch.TabIndex = 7;
            this.saleAllSearch.Text = "search order ID";
            this.saleAllSearch.UseVisualStyleBackColor = true;
            this.saleAllSearch.Click += new System.EventHandler(this.saleAllSearch_Click);
            // 
            // saleSearch
            // 
            this.saleSearch.Location = new System.Drawing.Point(348, 17);
            this.saleSearch.Name = "saleSearch";
            this.saleSearch.Size = new System.Drawing.Size(207, 28);
            this.saleSearch.TabIndex = 6;
            this.saleSearch.TextChanged += new System.EventHandler(this.saleSearch_TextChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(6, 9);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(192, 40);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create Product";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvProOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 644);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvProOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvOverview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productOutboundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialOutboundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsReceivableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsPayableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerAftersalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox saleAllFliter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saleAllSearch;
        private System.Windows.Forms.TextBox saleSearch;
        private System.Windows.Forms.Button Create;
    }
}