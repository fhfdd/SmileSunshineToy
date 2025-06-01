namespace SmileSunshineToy
{
    partial class dashboard
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStrip1.Size = new System.Drawing.Size(227, 448);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // saleOrderToolStripMenuItem
            // 
            this.saleOrderToolStripMenuItem.Name = "saleOrderToolStripMenuItem";
            this.saleOrderToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.saleOrderToolStripMenuItem.Text = "Sale order";
            this.saleOrderToolStripMenuItem.Click += new System.EventHandler(this.saleOrderToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // rDToolStripMenuItem
            // 
            this.rDToolStripMenuItem.Name = "rDToolStripMenuItem";
            this.rDToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.rDToolStripMenuItem.Text = "R&D";
            this.rDToolStripMenuItem.Click += new System.EventHandler(this.rDToolStripMenuItem_Click);
            // 
            // financialToolStripMenuItem
            // 
            this.financialToolStripMenuItem.Name = "financialToolStripMenuItem";
            this.financialToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.financialToolStripMenuItem.Text = "Financial";
            this.financialToolStripMenuItem.Click += new System.EventHandler(this.financialToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // logisticsToolStripMenuItem
            // 
            this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
            this.logisticsToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.logisticsToolStripMenuItem.Text = "Logistics";
            // 
            // procurementToolStripMenuItem
            // 
            this.procurementToolStripMenuItem.Name = "procurementToolStripMenuItem";
            this.procurementToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.procurementToolStripMenuItem.Text = "Procurement";
            // 
            // personnelInformationToolStripMenuItem
            // 
            this.personnelInformationToolStripMenuItem.Name = "personnelInformationToolStripMenuItem";
            this.personnelInformationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.personnelInformationToolStripMenuItem.Text = "Personnel information";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.signOutToolStripMenuItem.Text = "sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 448);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}