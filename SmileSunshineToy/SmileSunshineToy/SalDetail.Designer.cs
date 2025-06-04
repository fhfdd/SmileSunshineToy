
namespace SmileSunshineToy
{
    partial class SalDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.testDataSet = new SmileSunshineToy.testDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signDate = new System.Windows.Forms.DateTimePicker();
            this.orderID_text = new System.Windows.Forms.TextBox();
            this.saleAllFliter = new System.Windows.Forms.ComboBox();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.saleAllSearch = new System.Windows.Forms.Button();
            this.saleSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.productTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.customerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1743, 57);
            this.panel1.TabIndex = 5;
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
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.comboBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.customerGrid);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.signDate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.orderID_text);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleAllFliter);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.productGrid);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleAllSearch);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saleSearch);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1743, 819);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load_1);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 57);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1743, 819);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(998, 734);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 40);
            this.button6.TabIndex = 20;
            this.button6.Text = "Submit for Approval";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(792, 734);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 40);
            this.button5.TabIndex = 19;
            this.button5.Text = "Submit for Approval";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 734);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 40);
            this.button4.TabIndex = 18;
            this.button4.Text = "Canel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_cancel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 734);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 40);
            this.button3.TabIndex = 17;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 734);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1131, 610);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 28);
            this.textBox2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1039, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1035, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customerGrid
            // 
            this.customerGrid.AutoGenerateColumns = false;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.feedbackDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.customerGrid.DataSource = this.customerBindingSource;
            this.customerGrid.Location = new System.Drawing.Point(18, 285);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.RowHeadersWidth = 62;
            this.customerGrid.RowTemplate.Height = 30;
            this.customerGrid.Size = new System.Drawing.Size(934, 277);
            this.customerGrid.TabIndex = 12;
            this.customerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer information: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order Signing Date: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // signDate
            // 
            this.signDate.Location = new System.Drawing.Point(7, 104);
            this.signDate.Name = "signDate";
            this.signDate.Size = new System.Drawing.Size(200, 28);
            this.signDate.TabIndex = 6;
            // 
            // orderID_text
            // 
            this.orderID_text.Location = new System.Drawing.Point(117, 21);
            this.orderID_text.Name = "orderID_text";
            this.orderID_text.Size = new System.Drawing.Size(146, 28);
            this.orderID_text.TabIndex = 5;
            // 
            // saleAllFliter
            // 
            this.saleAllFliter.FormattingEnabled = true;
            this.saleAllFliter.Location = new System.Drawing.Point(377, 63);
            this.saleAllFliter.Name = "saleAllFliter";
            this.saleAllFliter.Size = new System.Drawing.Size(107, 26);
            this.saleAllFliter.TabIndex = 4;
            this.saleAllFliter.Text = "order ID";
            // 
            // productGrid
            // 
            this.productGrid.AutoGenerateColumns = false;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.productGrid.DataSource = this.productBindingSource;
            this.productGrid.Location = new System.Drawing.Point(1039, 188);
            this.productGrid.Name = "productGrid";
            this.productGrid.RowHeadersWidth = 62;
            this.productGrid.RowTemplate.Height = 30;
            this.productGrid.Size = new System.Drawing.Size(663, 374);
            this.productGrid.TabIndex = 3;
            this.productGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productionGrid);
            // 
            // saleAllSearch
            // 
            this.saleAllSearch.Location = new System.Drawing.Point(684, 61);
            this.saleAllSearch.Name = "saleAllSearch";
            this.saleAllSearch.Size = new System.Drawing.Size(87, 28);
            this.saleAllSearch.TabIndex = 2;
            this.saleAllSearch.Text = "search order ID";
            this.saleAllSearch.UseVisualStyleBackColor = true;
            // 
            // saleSearch
            // 
            this.saleSearch.Location = new System.Drawing.Point(480, 61);
            this.saleSearch.Name = "saleSearch";
            this.saleSearch.Size = new System.Drawing.Size(207, 28);
            this.saleSearch.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1043, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            this.stockQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // feedbackDataGridViewTextBoxColumn
            // 
            this.feedbackDataGridViewTextBoxColumn.DataPropertyName = "Feedback";
            this.feedbackDataGridViewTextBoxColumn.HeaderText = "Feedback";
            this.feedbackDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.feedbackDataGridViewTextBoxColumn.Name = "feedbackDataGridViewTextBoxColumn";
            this.feedbackDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 26);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "customer select";
            // 
            // SalDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 876);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalDetail";
            this.Load += new System.EventHandler(this.SalDetail_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DateTimePicker signDate;
        private System.Windows.Forms.TextBox orderID_text;
        private System.Windows.Forms.ComboBox saleAllFliter;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.Button saleAllSearch;
        private System.Windows.Forms.TextBox saleSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource productBindingSource;
        private testDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private testDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}