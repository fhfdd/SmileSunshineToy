using System;
using System.Drawing;

namespace SmileSunshineToy
{
    partial class ProdPlanOverview1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSaleOrder;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnFinancial;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnLogistics;
        private System.Windows.Forms.Button btnProcurement;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.ComboBox coboStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView1;

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
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.coboStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // panelNav
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(150, 768);
            this.panelNav.TabIndex = 0;

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblDateTime);
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.txtPlanID);
            this.panelMain.Controls.Add(this.coboStatus);
            this.panelMain.Controls.Add(this.btnSearch);
            this.panelMain.Controls.Add(this.txtOrderID);
            this.panelMain.Controls.Add(this.btnOrderSearch);
            this.panelMain.Controls.Add(this.dpStartDate);
            this.panelMain.Controls.Add(this.dpEndDate);
            this.panelMain.Controls.Add(this.txtProductID);
            this.panelMain.Controls.Add(this.btnProductSearch);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.btnExport);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(150, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(874, 768);
            this.panelMain.TabIndex = 1;

            // lblDateTime
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDateTime.Location = new System.Drawing.Point(20, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(200, 20);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = DateTime.Now.ToString("HH:mm:ss, yyyy-MM-dd");

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(700, 400);
            this.dataGridView1.TabIndex = 1;

            // txtPlanID
            this.txtPlanID.Location = new System.Drawing.Point(20, 50);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(150, 25);
            this.txtPlanID.TabIndex = 2;

            // coboStatus
            this.coboStatus.FormattingEnabled = true;
            this.coboStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Completed"});
            this.coboStatus.Location = new System.Drawing.Point(200, 50);
            this.coboStatus.Name = "coboStatus";
            this.coboStatus.Size = new System.Drawing.Size(150, 25);
            this.coboStatus.TabIndex = 3;

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.Location = new System.Drawing.Point(370, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // txtOrderID
            this.txtOrderID.Location = new System.Drawing.Point(20, 100);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(150, 25);
            this.txtOrderID.TabIndex = 5;

            // btnOrderSearch
            this.btnOrderSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnOrderSearch.Location = new System.Drawing.Point(180, 100);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(80, 25);
            this.btnOrderSearch.TabIndex = 6;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = false;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);

            // dpStartDate
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartDate.Location = new System.Drawing.Point(20, 150);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(150, 25);
            this.dpStartDate.TabIndex = 7;

            // dpEndDate
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEndDate.Location = new System.Drawing.Point(200, 150);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(150, 25);
            this.dpEndDate.TabIndex = 8;

            // txtProductID
            this.txtProductID.Location = new System.Drawing.Point(20, 200);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(150, 25);
            this.txtProductID.TabIndex = 9;

            // btnProductSearch
            this.btnProductSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnProductSearch.Location = new System.Drawing.Point(180, 200);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(80, 25);
            this.btnProductSearch.TabIndex = 10;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(20, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(120, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Location = new System.Drawing.Point(220, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);


            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelete.Location = new System.Drawing.Point(420, 250); // 在Save按钮右侧
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = Color.FromArgb(255, 100, 100); // 红色警示色
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.panelMain.Controls.Add(this.btnDelete);

            // btnExport
            this.btnExport.BackColor = System.Drawing.Color.LightGray;
            this.btnExport.Location = new System.Drawing.Point(320, 250);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 30);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // ProdPlanOverview1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNav);
            this.Name = "ProdPlanOverview1";
            this.Text = "Production Plan Overview";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("HH:mm:ss, yyyy-MM-dd");
        }
    }
}