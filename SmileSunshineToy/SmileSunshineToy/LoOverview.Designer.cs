
namespace SmileSunshineToy
{
    partial class LoOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoOverview));
            this.btn_inv = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_person = new System.Windows.Forms.Button();
            this.btn_proc = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_fin = new System.Windows.Forms.Button();
            this.btn_rd = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.productTableAdapter();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new SmileSunshineToy.testDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LogID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ShipID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inv
            // 
            this.btn_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inv.FlatAppearance.BorderSize = 0;
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inv.ForeColor = System.Drawing.Color.Black;
            this.btn_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inv.ImageKey = "product-management.png";
            this.btn_inv.ImageList = this.imageList1;
            this.btn_inv.Location = new System.Drawing.Point(0, 763);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(472, 97);
            this.btn_inv.TabIndex = 26;
            this.btn_inv.Text = "Inventory";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
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
            // btn_person
            // 
            this.btn_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_person.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_person.FlatAppearance.BorderSize = 0;
            this.btn_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_person.ForeColor = System.Drawing.Color.Black;
            this.btn_person.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_person.ImageKey = "customer.png";
            this.btn_person.ImageList = this.imageList1;
            this.btn_person.Location = new System.Drawing.Point(0, 666);
            this.btn_person.Name = "btn_person";
            this.btn_person.Size = new System.Drawing.Size(472, 97);
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
            this.btn_proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proc.ForeColor = System.Drawing.Color.Black;
            this.btn_proc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proc.ImageKey = "procurement.png";
            this.btn_proc.ImageList = this.imageList1;
            this.btn_proc.Location = new System.Drawing.Point(0, 569);
            this.btn_proc.Name = "btn_proc";
            this.btn_proc.Size = new System.Drawing.Size(472, 97);
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
            this.btn_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.Color.Black;
            this.btn_log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log.ImageKey = "delivery-truck.png";
            this.btn_log.ImageList = this.imageList1;
            this.btn_log.Location = new System.Drawing.Point(0, 472);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(472, 97);
            this.btn_log.TabIndex = 18;
            this.btn_log.Text = "Logistics";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod.FlatAppearance.BorderSize = 0;
            this.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.ImageKey = "production-line.png";
            this.btn_prod.ImageList = this.imageList1;
            this.btn_prod.Location = new System.Drawing.Point(0, 375);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(472, 97);
            this.btn_prod.TabIndex = 17;
            this.btn_prod.Text = "Production";
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_fin
            // 
            this.btn_fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fin.FlatAppearance.BorderSize = 0;
            this.btn_fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fin.ForeColor = System.Drawing.Color.Black;
            this.btn_fin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fin.ImageKey = "deposit.png";
            this.btn_fin.ImageList = this.imageList1;
            this.btn_fin.Location = new System.Drawing.Point(0, 278);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(472, 97);
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
            this.btn_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rd.ForeColor = System.Drawing.Color.Black;
            this.btn_rd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rd.ImageKey = "analysis.png";
            this.btn_rd.ImageList = this.imageList1;
            this.btn_rd.Location = new System.Drawing.Point(0, 181);
            this.btn_rd.Name = "btn_rd";
            this.btn_rd.Size = new System.Drawing.Size(472, 97);
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
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 860);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(472, 90);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            this.button1.Location = new System.Drawing.Point(1741, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 156);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // order
            // 
            this.order.Dock = System.Windows.Forms.DockStyle.Top;
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Black;
            this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.ImageKey = "order.png";
            this.order.ImageList = this.imageList1;
            this.order.Location = new System.Drawing.Point(0, 84);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(472, 97);
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
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.ImageKey = "home.png";
            this.btn_home.ImageList = this.imageList1;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(472, 84);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1881, 156);
            this.panel4.TabIndex = 17;
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
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 950);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1881, 156);
            this.panel2.TabIndex = 57;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;

            this.filterComboBox.Location = new System.Drawing.Point(1396, 231);


            this.filterComboBox.Location = new System.Drawing.Point(1377, 214);

            this.filterComboBox.Location = new System.Drawing.Point(1396, 231);


            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(130, 28);
            this.filterComboBox.TabIndex = 56;
            // 
            // txtSearch

            // 
            this.txtSearch.Location = new System.Drawing.Point(971, 231);

          
            this.txtSearch.Location = new System.Drawing.Point(952, 214);
            this.txtSearch.Location = new System.Drawing.Point(971, 231);


            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(431, 26);
            this.txtSearch.TabIndex = 55;
            // 

            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1278, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 81);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1111, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 81);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(779, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 81);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(753, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 642);
            this.dataGridView1.TabIndex = 49;
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
  
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 

            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(822, 210);

            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(951, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 81);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(841, 227);

            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 37);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // LogID
            // 
            this.LogID.AutoSize = true;
            this.LogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogID.Location = new System.Drawing.Point(537, 298);
            this.LogID.Name = "LogID";
            this.LogID.Size = new System.Drawing.Size(118, 25);
            this.LogID.TabIndex = 59;
            this.LogID.Text = "Logistics ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(662, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 30);
            this.textBox1.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1117, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 30);
            this.textBox2.TabIndex = 62;
            // 
            // ShipID
            // 
            this.ShipID.AutoSize = true;
            this.ShipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipID.Location = new System.Drawing.Point(992, 298);
            this.ShipID.Name = "ShipID";
            this.ShipID.Size = new System.Drawing.Size(125, 25);
            this.ShipID.TabIndex = 61;
            this.ShipID.Text = "Shipment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1493, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "On Time",
            "Completed",
            "Late",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(1574, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 33);
            this.comboBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 29);
            this.label2.TabIndex = 65;
            this.label2.Text = "Collect goods from: (Select warehouse location):";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(720, 435);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 30);
            this.textBox3.TabIndex = 67;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Warehouse ID:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(720, 548);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(331, 73);
            this.textBox4.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Warehouse Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Location:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Main Warehouse",
            "Branch Warehouse",
            "Branch2 Warehouse",
            "Branch3 Warehouse"});
            this.comboBox2.Location = new System.Drawing.Point(720, 487);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(331, 33);
            this.comboBox2.TabIndex = 71;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(1463, 431);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(314, 30);
            this.textBox5.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1304, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Contact Person:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(1463, 489);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(314, 30);
            this.textBox6.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1304, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Contact Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1276, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 76;
            this.label8.Text = "Delivery Schedule:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1463, 547);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 26);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(537, 664);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "Delivery Notes:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(720, 664);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(1057, 132);
            this.textBox7.TabIndex = 78;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(766, 908);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 61);
            this.button2.TabIndex = 80;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1047, 908);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 61);
            this.button3.TabIndex = 81;
            this.button3.Text = "Generate Delivery Notes";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1548, 908);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 61);
            this.button4.TabIndex = 82;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // LoOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1881, 1106);
<

            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ShipID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogID);


            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoOverview";
            this.Text = "LoOverview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoOverview_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
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
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private testDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource productBindingSource;
        private testDataSet testDataSet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label LogID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ShipID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}