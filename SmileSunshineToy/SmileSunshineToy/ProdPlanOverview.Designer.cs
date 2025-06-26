
namespace SmileSunshineToy
{
    partial class ProdPlanOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdPlanOverview));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.productTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.productTableAdapter();
            this.productionplanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new SmileSunshineToy.testDataSet();
            this.productionplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionplanTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.productionplanTableAdapter();
            this.productionplanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.orderTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.export = new System.Windows.Forms.Button();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.orderSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.ComboBox();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.ComboBox();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.coboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_material = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Role = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "profile-user.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "customer.png");
            this.imageList1.Images.SetKeyName(3, "procurement.png");
            this.imageList1.Images.SetKeyName(4, "delivery-truck.png");
            this.imageList1.Images.SetKeyName(5, "production-line.png");
            this.imageList1.Images.SetKeyName(6, "deposit.png");
            this.imageList1.Images.SetKeyName(7, "analysis.png");
            this.imageList1.Images.SetKeyName(8, "product-management.png");
            this.imageList1.Images.SetKeyName(9, "order.png");
            this.imageList1.Images.SetKeyName(10, "home.png");
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productionplanBindingSource1
            // 
            this.productionplanBindingSource1.DataMember = "productionplan";
            this.productionplanBindingSource1.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productionplanBindingSource
            // 
            this.productionplanBindingSource.DataMember = "productionplan";
            this.productionplanBindingSource.DataSource = this.testDataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.testDataSet;
            // 
            // productionplanTableAdapter
            // 
            this.productionplanTableAdapter.ClearBeforeFill = true;
            // 
            // productionplanBindingSource2
            // 
            this.productionplanBindingSource2.DataMember = "productionplan";
            this.productionplanBindingSource2.DataSource = this.testDataSet;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.testDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // export
            // 
            this.export.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.export.Location = new System.Drawing.Point(1173, 834);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(204, 55);
            this.export.TabIndex = 78;
            this.export.Text = "export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.txtProd.Location = new System.Drawing.Point(691, 615);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(240, 31);
            this.txtProd.TabIndex = 77;
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.txtOrder.Location = new System.Drawing.Point(675, 438);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(228, 31);
            this.txtOrder.TabIndex = 76;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(927, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 35);
            this.button3.TabIndex = 75;
            this.button3.Text = "search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.prodsearch_Click);
            // 
            // orderSearch
            // 
            this.orderSearch.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.orderSearch.Location = new System.Drawing.Point(898, 437);
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.Size = new System.Drawing.Size(132, 35);
            this.orderSearch.TabIndex = 74;
            this.orderSearch.Text = "search";
            this.orderSearch.UseVisualStyleBackColor = true;
            this.orderSearch.Click += new System.EventHandler(this.orderSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(543, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 73;
            this.label2.Text = "Plan ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.editBtn.Location = new System.Drawing.Point(548, 834);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(149, 55);
            this.editBtn.TabIndex = 72;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToOrderColumns = true;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.productGridView.Location = new System.Drawing.Point(548, 649);
            this.productGridView.MultiSelect = false;
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 62;
            this.productGridView.RowTemplate.Height = 30;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(774, 136);
            this.productGridView.TabIndex = 71;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellContentClick);
            this.productGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productGridView_CellMouseDoubleClick);
            this.productGridView.SelectionChanged += new System.EventHandler(this.productGridView_SelectionChanged);
            this.productGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.productGridView_MouseDown);
            // 
            // productID
            // 
            this.productID.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.productID.FormattingEnabled = true;
            this.productID.Location = new System.Drawing.Point(544, 615);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(149, 32);
            this.productID.TabIndex = 70;
            this.productID.Text = "productID";
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToOrderColumns = true;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.orderGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.orderGridView.Location = new System.Drawing.Point(548, 472);
            this.orderGridView.MultiSelect = false;
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.RowHeadersVisible = false;
            this.orderGridView.RowHeadersWidth = 62;
            this.orderGridView.RowTemplate.Height = 30;
            this.orderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGridView.Size = new System.Drawing.Size(774, 134);
            this.orderGridView.TabIndex = 69;
            this.orderGridView.SelectionChanged += new System.EventHandler(this.orderGridView_SelectionChanged);
            this.orderGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.orderGridView_MouseDown);
            // 
            // orderID
            // 
            this.orderID.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.orderID.FormattingEnabled = true;
            this.orderID.Location = new System.Drawing.Point(548, 437);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(128, 32);
            this.orderID.TabIndex = 68;
            this.orderID.Text = "orderID";
            // 
            // txtPlanID
            // 
            this.txtPlanID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlanID.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold);
            this.txtPlanID.Location = new System.Drawing.Point(658, 147);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(494, 31);
            this.txtPlanID.TabIndex = 67;
            this.txtPlanID.TextChanged += new System.EventHandler(this.txtPlanID_TextChanged);
            // 
            // dpEndDate
            // 
            this.dpEndDate.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dpEndDate.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(1355, 618);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(362, 31);
            this.dpEndDate.TabIndex = 65;
            // 
            // coboStatus
            // 
            this.coboStatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.coboStatus.FormattingEnabled = true;
            this.coboStatus.Location = new System.Drawing.Point(1436, 182);
            this.coboStatus.Name = "coboStatus";
            this.coboStatus.Size = new System.Drawing.Size(231, 37);
            this.coboStatus.TabIndex = 64;
            this.coboStatus.Text = "Stutas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1351, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Plan Delivery Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1351, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Plan Signing Date: ";
            // 
            // dpStartDate
            // 
            this.dpStartDate.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dpStartDate.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(1355, 508);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(349, 31);
            this.dpStartDate.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.btn_material);
            this.panel3.Controls.Add(this.btn_product);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(341, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 805);
            this.panel3.TabIndex = 59;
            // 
            // btn_material
            // 
            this.btn_material.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_material.FlatAppearance.BorderSize = 0;
            this.btn_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_material.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_material.ForeColor = System.Drawing.Color.Black;
            this.btn_material.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_material.Location = new System.Drawing.Point(0, 76);
            this.btn_material.Name = "btn_material";
            this.btn_material.Size = new System.Drawing.Size(189, 78);
            this.btn_material.TabIndex = 2;
            this.btn_material.Text = "Inbound";
            this.btn_material.UseVisualStyleBackColor = true;
            this.btn_material.Click += new System.EventHandler(this.btn_sub2_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FlatAppearance.BorderSize = 0;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_product.ForeColor = System.Drawing.Color.Black;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(0, 0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(189, 76);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Product Plan";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_sub1_Click);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 805);
            this.panel1.TabIndex = 58;
            // 
            // btn_inv
            // 
            this.btn_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inv.FlatAppearance.BorderSize = 0;
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_inv.ForeColor = System.Drawing.Color.Black;
            this.btn_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inv.ImageKey = "product-management.png";
            this.btn_inv.ImageList = this.imageList1;
            this.btn_inv.Location = new System.Drawing.Point(0, 685);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(341, 87);
            this.btn_inv.TabIndex = 26;
            this.btn_inv.Text = "Inventory";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // btn_person
            // 
            this.btn_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_person.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_person.FlatAppearance.BorderSize = 0;
            this.btn_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_person.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_person.ForeColor = System.Drawing.Color.Black;
            this.btn_person.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_person.ImageKey = "customer.png";
            this.btn_person.ImageList = this.imageList1;
            this.btn_person.Location = new System.Drawing.Point(0, 598);
            this.btn_person.Name = "btn_person";
            this.btn_person.Size = new System.Drawing.Size(341, 87);
            this.btn_person.TabIndex = 20;
            this.btn_person.Text = "Personnel information";
            this.btn_person.UseVisualStyleBackColor = true;
            this.btn_person.Click += new System.EventHandler(this.btn_person_Click);
            // 
            // btn_proc
            // 
            this.btn_proc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_proc.FlatAppearance.BorderSize = 0;
            this.btn_proc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proc.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_proc.ForeColor = System.Drawing.Color.Black;
            this.btn_proc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proc.ImageKey = "procurement.png";
            this.btn_proc.ImageList = this.imageList1;
            this.btn_proc.Location = new System.Drawing.Point(0, 511);
            this.btn_proc.Name = "btn_proc";
            this.btn_proc.Size = new System.Drawing.Size(341, 87);
            this.btn_proc.TabIndex = 19;
            this.btn_proc.Text = "Procurement";
            this.btn_proc.UseVisualStyleBackColor = true;
            this.btn_proc.Click += new System.EventHandler(this.btn_proc_Click);
            // 
            // btn_log
            // 
            this.btn_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_log.ForeColor = System.Drawing.Color.Black;
            this.btn_log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log.ImageKey = "delivery-truck.png";
            this.btn_log.ImageList = this.imageList1;
            this.btn_log.Location = new System.Drawing.Point(0, 424);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(341, 87);
            this.btn_log.TabIndex = 18;
            this.btn_log.Text = "Logistics";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod.FlatAppearance.BorderSize = 0;
            this.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prod.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.ImageKey = "production-line.png";
            this.btn_prod.ImageList = this.imageList1;
            this.btn_prod.Location = new System.Drawing.Point(0, 337);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(341, 87);
            this.btn_prod.TabIndex = 17;
            this.btn_prod.Text = "Production";
            this.btn_prod.UseVisualStyleBackColor = false;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_fin
            // 
            this.btn_fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fin.FlatAppearance.BorderSize = 0;
            this.btn_fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fin.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_fin.ForeColor = System.Drawing.Color.Black;
            this.btn_fin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fin.ImageKey = "deposit.png";
            this.btn_fin.ImageList = this.imageList1;
            this.btn_fin.Location = new System.Drawing.Point(0, 250);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(341, 87);
            this.btn_fin.TabIndex = 15;
            this.btn_fin.Text = "Financial";
            this.btn_fin.UseVisualStyleBackColor = true;
            this.btn_fin.Click += new System.EventHandler(this.btn_fin_Click);
            // 
            // btn_rd
            // 
            this.btn_rd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rd.FlatAppearance.BorderSize = 0;
            this.btn_rd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rd.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_rd.ForeColor = System.Drawing.Color.Black;
            this.btn_rd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rd.ImageKey = "analysis.png";
            this.btn_rd.ImageList = this.imageList1;
            this.btn_rd.Location = new System.Drawing.Point(0, 163);
            this.btn_rd.Name = "btn_rd";
            this.btn_rd.Size = new System.Drawing.Size(341, 87);
            this.btn_rd.TabIndex = 13;
            this.btn_rd.Text = "R&&D";
            this.btn_rd.UseVisualStyleBackColor = true;
            this.btn_rd.Click += new System.EventHandler(this.btn_rd_Click);
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 724);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(341, 81);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // order
            // 
            this.order.Dock = System.Windows.Forms.DockStyle.Top;
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.order.ForeColor = System.Drawing.Color.Black;
            this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.ImageKey = "order.png";
            this.order.ImageList = this.imageList1;
            this.order.Location = new System.Drawing.Point(0, 76);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(341, 87);
            this.order.TabIndex = 2;
            this.order.Text = "Sale Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.ImageKey = "home.png";
            this.btn_home.ImageList = this.imageList1;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(341, 76);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1752, 140);
            this.panel2.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Controls.Add(this.Role);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1752, 140);
            this.panel4.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Bisque;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(177, 140);
            this.toolStrip1.TabIndex = 81;
            this.toolStrip1.Text = "Time;Date";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(172, 38);
            this.toolStripLabel1.Text = "Time,Date";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.Role.Location = new System.Drawing.Point(2150, 61);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(67, 29);
            this.Role.TabIndex = 79;
            this.Role.Text = "Role";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageKey = "profile-user.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(1612, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 140);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(609, 259);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(192, 37);
            this.filterComboBox.TabIndex = 56;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(798, 246);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 59);
            this.txtSearch.TabIndex = 55;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(852, 834);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 55);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1022, 834);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 55);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(703, 834);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 55);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(548, 303);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 126);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView1_CellToolTipTextNeeded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(1170, 256);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 42);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // ProdPlanOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1752, 945);
            this.Controls.Add(this.export);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.orderSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.txtPlanID);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.coboStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Name = "ProdPlanOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProOverview";
            this.Load += new System.EventHandler(this.ProdPlanOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_person;
        private System.Windows.Forms.Button btn_proc;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_fin;
        private System.Windows.Forms.Button btn_rd;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_material;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private testDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private testDataSet testDataSet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource productionplanBindingSource;
        private testDataSetTableAdapters.productionplanTableAdapter productionplanTableAdapter;
        private System.Windows.Forms.BindingSource productionplanBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.ComboBox coboStatus;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.BindingSource productionplanBindingSource2;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.ComboBox orderID;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private testDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.ComboBox productID;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button export;
    }
}