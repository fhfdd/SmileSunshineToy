using System;

namespace WindowsFormsApp1
{
    partial class RD2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchDevelopmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewPrototype = new System.Windows.Forms.DataGridView();
            this.materialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outboundWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAttachment = new System.Windows.Forms.TextBox();
            this.labelAttachment = new System.Windows.Forms.Label();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxRequirement = new System.Windows.Forms.TextBox();
            this.labelRequirement = new System.Windows.Forms.Label();
            this.comboBoxTestResult = new System.Windows.Forms.ComboBox();
            this.labelTestResult = new System.Windows.Forms.Label();
            this.textBoxSchemeName = new System.Windows.Forms.TextBox();
            this.labelSchemeName = new System.Windows.Forms.Label();
            this.textBoxSchemeID = new System.Windows.Forms.TextBox();
            this.labelSchemeID = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelSchemeInfo = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.labelProjectID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrototype)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 69);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1220, 19);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(112, 32);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(450, 22);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(298, 28);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "S&S TOY";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.saleOrderToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.researchDevelopmentToolStripMenuItem,
            this.financialToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.logisticsToolStripMenuItem,
            this.procurementToolStripMenuItem,
            this.personnelInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // saleOrderToolStripMenuItem
            // 
            this.saleOrderToolStripMenuItem.Name = "saleOrderToolStripMenuItem";
            this.saleOrderToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.saleOrderToolStripMenuItem.Text = "Sale Order";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // researchDevelopmentToolStripMenuItem
            // 
            this.researchDevelopmentToolStripMenuItem.Name = "researchDevelopmentToolStripMenuItem";
            this.researchDevelopmentToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.researchDevelopmentToolStripMenuItem.Text = "Research & Development";
            // 
            // financialToolStripMenuItem
            // 
            this.financialToolStripMenuItem.Name = "financialToolStripMenuItem";
            this.financialToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.financialToolStripMenuItem.Text = "Financial";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // logisticsToolStripMenuItem
            // 
            this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
            this.logisticsToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.logisticsToolStripMenuItem.Text = "Logistics";
            // 
            // procurementToolStripMenuItem
            // 
            this.procurementToolStripMenuItem.Name = "procurementToolStripMenuItem";
            this.procurementToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.procurementToolStripMenuItem.Text = "Procurement";
            // 
            // personnelInformationToolStripMenuItem
            // 
            this.personnelInformationToolStripMenuItem.Name = "personnelInformationToolStripMenuItem";
            this.personnelInformationToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.personnelInformationToolStripMenuItem.Text = "Personnel Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCreateReport);
            this.panel2.Controls.Add(this.buttonSubmit);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonExport);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.dataGridViewPrototype);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.textBoxAmount);
            this.panel2.Controls.Add(this.labelAmount);
            this.panel2.Controls.Add(this.textBoxAttachment);
            this.panel2.Controls.Add(this.labelAttachment);
            this.panel2.Controls.Add(this.textBoxRemark);
            this.panel2.Controls.Add(this.labelRemark);
            this.panel2.Controls.Add(this.textBoxDescription);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.textBoxRequirement);
            this.panel2.Controls.Add(this.labelRequirement);
            this.panel2.Controls.Add(this.comboBoxTestResult);
            this.panel2.Controls.Add(this.labelTestResult);
            this.panel2.Controls.Add(this.textBoxSchemeName);
            this.panel2.Controls.Add(this.labelSchemeName);
            this.panel2.Controls.Add(this.textBoxSchemeID);
            this.panel2.Controls.Add(this.labelSchemeID);
            this.panel2.Controls.Add(this.comboBoxCustomer);
            this.panel2.Controls.Add(this.labelSchemeInfo);
            this.panel2.Controls.Add(this.dateTimePickerEnd);
            this.panel2.Controls.Add(this.labelEndDate);
            this.panel2.Controls.Add(this.textBoxStatus);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.dateTimePickerStart);
            this.panel2.Controls.Add(this.labelStartDate);
            this.panel2.Controls.Add(this.comboBoxManager);
            this.panel2.Controls.Add(this.labelManager);
            this.panel2.Controls.Add(this.textBoxProjectID);
            this.panel2.Controls.Add(this.labelProjectID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 730);
            this.panel2.TabIndex = 2;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(1188, 367);
            this.buttonCreateReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(144, 32);
            this.buttonCreateReport.TabIndex = 39;
            this.buttonCreateReport.Text = "Create Report";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(1188, 313);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(144, 32);
            this.buttonSubmit.TabIndex = 38;
            this.buttonSubmit.Text = "Submit for Approval";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1188, 259);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(144, 32);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(1188, 205);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(144, 32);
            this.buttonExport.TabIndex = 36;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1188, 151);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(144, 32);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewPrototype
            // 
            this.dataGridViewPrototype.AllowUserToAddRows = false;
            this.dataGridViewPrototype.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewPrototype.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPrototype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrototype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialName,
            this.materialID,
            this.AvailableStock,
            this.qty,
            this.Price,
            this.outboundWarehouse,
            this.version});
            this.dataGridViewPrototype.Location = new System.Drawing.Point(22, 313);
            this.dataGridViewPrototype.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrototype.Name = "dataGridViewPrototype";
            this.dataGridViewPrototype.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrototype.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPrototype.RowHeadersVisible = false;
            this.dataGridViewPrototype.RowHeadersWidth = 62;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPrototype.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPrototype.RowTemplate.Height = 23;
            this.dataGridViewPrototype.Size = new System.Drawing.Size(1145, 292);
            this.dataGridViewPrototype.TabIndex = 34;
            this.dataGridViewPrototype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrototype_CellContentClick);
            // 
            // materialName
            // 
            this.materialName.HeaderText = "materialName";
            this.materialName.MinimumWidth = 8;
            this.materialName.Name = "materialName";
            this.materialName.ReadOnly = true;
            this.materialName.Width = 180;
            // 
            // materialID
            // 
            this.materialID.HeaderText = "materialID";
            this.materialID.MinimumWidth = 8;
            this.materialID.Name = "materialID";
            this.materialID.ReadOnly = true;
            this.materialID.Width = 180;
            // 
            // AvailableStock
            // 
            this.AvailableStock.HeaderText = "AvailableStock";
            this.AvailableStock.MinimumWidth = 8;
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.ReadOnly = true;
            this.AvailableStock.Width = 180;
            // 
            // qty
            // 
            this.qty.HeaderText = "qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 140;
            // 
            // outboundWarehouse
            // 
            this.outboundWarehouse.HeaderText = "outboundWarehouse";
            this.outboundWarehouse.MinimumWidth = 8;
            this.outboundWarehouse.Name = "outboundWarehouse";
            this.outboundWarehouse.ReadOnly = true;
            this.outboundWarehouse.Width = 200;
            // 
            // version
            // 
            this.version.HeaderText = "version";
            this.version.MinimumWidth = 8;
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Width = 140;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1030, 259);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 32);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Add Prototype";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(189, 259);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(148, 28);
            this.textBoxAmount.TabIndex = 32;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(124, 263);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 18);
            this.labelAmount.TabIndex = 31;
            this.labelAmount.Text = "Amount:";
            // 
            // textBoxAttachment
            // 
            this.textBoxAttachment.Location = new System.Drawing.Point(189, 223);
            this.textBoxAttachment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAttachment.Name = "textBoxAttachment";
            this.textBoxAttachment.Size = new System.Drawing.Size(529, 28);
            this.textBoxAttachment.TabIndex = 30;
            // 
            // labelAttachment
            // 
            this.labelAttachment.AutoSize = true;
            this.labelAttachment.Location = new System.Drawing.Point(78, 227);
            this.labelAttachment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAttachment.Name = "labelAttachment";
            this.labelAttachment.Size = new System.Drawing.Size(107, 18);
            this.labelAttachment.TabIndex = 29;
            this.labelAttachment.Text = "Attachment:";
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(189, 187);
            this.textBoxRemark.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(529, 28);
            this.textBoxRemark.TabIndex = 28;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Location = new System.Drawing.Point(100, 191);
            this.labelRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(71, 18);
            this.labelRemark.TabIndex = 27;
            this.labelRemark.Text = "Remark:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(189, 151);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(529, 28);
            this.textBoxDescription.TabIndex = 26;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(70, 155);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(116, 18);
            this.labelDescription.TabIndex = 25;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxRequirement
            // 
            this.textBoxRequirement.Location = new System.Drawing.Point(189, 115);
            this.textBoxRequirement.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRequirement.Name = "textBoxRequirement";
            this.textBoxRequirement.Size = new System.Drawing.Size(529, 28);
            this.textBoxRequirement.TabIndex = 24;
            // 
            // labelRequirement
            // 
            this.labelRequirement.AutoSize = true;
            this.labelRequirement.Location = new System.Drawing.Point(48, 119);
            this.labelRequirement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequirement.Name = "labelRequirement";
            this.labelRequirement.Size = new System.Drawing.Size(152, 18);
            this.labelRequirement.TabIndex = 23;
            this.labelRequirement.Text = "Product Require:";
            // 
            // comboBoxTestResult
            // 
            this.comboBoxTestResult.FormattingEnabled = true;
            this.comboBoxTestResult.Location = new System.Drawing.Point(1030, 115);
            this.comboBoxTestResult.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTestResult.Name = "comboBoxTestResult";
            this.comboBoxTestResult.Size = new System.Drawing.Size(180, 26);
            this.comboBoxTestResult.TabIndex = 22;
            // 
            // labelTestResult
            // 
            this.labelTestResult.AutoSize = true;
            this.labelTestResult.Location = new System.Drawing.Point(918, 119);
            this.labelTestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestResult.Name = "labelTestResult";
            this.labelTestResult.Size = new System.Drawing.Size(116, 18);
            this.labelTestResult.TabIndex = 21;
            this.labelTestResult.Text = "Test Result:";
            // 
            // textBoxSchemeName
            // 
            this.textBoxSchemeName.Location = new System.Drawing.Point(1030, 79);
            this.textBoxSchemeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSchemeName.Name = "textBoxSchemeName";
            this.textBoxSchemeName.Size = new System.Drawing.Size(180, 28);
            this.textBoxSchemeName.TabIndex = 20;
            // 
            // labelSchemeName
            // 
            this.labelSchemeName.AutoSize = true;
            this.labelSchemeName.Location = new System.Drawing.Point(902, 83);
            this.labelSchemeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSchemeName.Name = "labelSchemeName";
            this.labelSchemeName.Size = new System.Drawing.Size(116, 18);
            this.labelSchemeName.TabIndex = 19;
            this.labelSchemeName.Text = "Scheme Name:";
            // 
            // textBoxSchemeID
            // 
            this.textBoxSchemeID.Location = new System.Drawing.Point(1030, 43);
            this.textBoxSchemeID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSchemeID.Name = "textBoxSchemeID";
            this.textBoxSchemeID.Size = new System.Drawing.Size(180, 28);
            this.textBoxSchemeID.TabIndex = 18;
            // 
            // labelSchemeID
            // 
            this.labelSchemeID.AutoSize = true;
            this.labelSchemeID.Location = new System.Drawing.Point(910, 47);
            this.labelSchemeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSchemeID.Name = "labelSchemeID";
            this.labelSchemeID.Size = new System.Drawing.Size(98, 18);
            this.labelSchemeID.TabIndex = 17;
            this.labelSchemeID.Text = "Scheme ID:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(189, 79);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(180, 26);
            this.comboBoxCustomer.TabIndex = 16;
            // 
            // labelSchemeInfo
            // 
            this.labelSchemeInfo.AutoSize = true;
            this.labelSchemeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchemeInfo.Location = new System.Drawing.Point(18, 43);
            this.labelSchemeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSchemeInfo.Name = "labelSchemeInfo";
            this.labelSchemeInfo.Size = new System.Drawing.Size(119, 20);
            this.labelSchemeInfo.TabIndex = 15;
            this.labelSchemeInfo.Text = "Scheme Info:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(600, 43);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(298, 28);
            this.dateTimePickerEnd.TabIndex = 14;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(519, 47);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(89, 18);
            this.labelEndDate.TabIndex = 13;
            this.labelEndDate.Text = "End Date:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(600, 79);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(148, 28);
            this.textBoxStatus.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(536, 83);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(71, 18);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(600, 7);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(298, 28);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(510, 11);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(107, 18);
            this.labelStartDate.TabIndex = 9;
            this.labelStartDate.Text = "Start Date:";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(189, 43);
            this.comboBoxManager.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(180, 26);
            this.comboBoxManager.TabIndex = 8;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(100, 47);
            this.labelManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(80, 18);
            this.labelManager.TabIndex = 7;
            this.labelManager.Text = "Manager:";
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.Location = new System.Drawing.Point(189, 7);
            this.textBoxProjectID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.Size = new System.Drawing.Size(180, 28);
            this.textBoxProjectID.TabIndex = 6;
            this.textBoxProjectID.Text = "202504050001";
            // 
            // labelProjectID
            // 
            this.labelProjectID.AutoSize = true;
            this.labelProjectID.Location = new System.Drawing.Point(100, 11);
            this.labelProjectID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjectID.Name = "labelProjectID";
            this.labelProjectID.Size = new System.Drawing.Size(107, 18);
            this.labelProjectID.TabIndex = 5;
            this.labelProjectID.Text = "Project ID:";
            // 
            // RD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 831);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RD2";
            this.Text = "S&S Toy - Research & Development";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrototype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchDevelopmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelInformationToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.Label labelProjectID;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelSchemeInfo;
        private System.Windows.Forms.TextBox textBoxSchemeID;
        private System.Windows.Forms.Label labelSchemeID;
        private System.Windows.Forms.TextBox textBoxSchemeName;
        private System.Windows.Forms.Label labelSchemeName;
        private System.Windows.Forms.ComboBox comboBoxTestResult;
        private System.Windows.Forms.Label labelTestResult;
        private System.Windows.Forms.TextBox textBoxRequirement;
        private System.Windows.Forms.Label labelRequirement;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox textBoxAttachment;
        private System.Windows.Forms.Label labelAttachment;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewPrototype;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn outboundWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
    }
}