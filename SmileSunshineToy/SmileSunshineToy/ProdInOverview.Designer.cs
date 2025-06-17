
namespace SmileSunshineToy
{
    partial class ProdInOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdInOverview));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.productTableAdapter();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new SmileSunshineToy.testDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageKey = "profile-user.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(1946, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 140);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2086, 140);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2086, 140);
            this.panel2.TabIndex = 57;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(1396, 208);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(130, 26);
            this.filterComboBox.TabIndex = 56;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(971, 208);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(431, 28);
            this.txtSearch.TabIndex = 55;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1278, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 73);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1111, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 73);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(779, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 73);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(951, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 73);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(841, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 33);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.btn_material);
            this.panel3.Controls.Add(this.btn_product);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(472, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 955);
            this.panel3.TabIndex = 60;
            // 
            // btn_material
            // 
            this.btn_material.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_material.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_material.FlatAppearance.BorderSize = 0;
            this.btn_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_material.ForeColor = System.Drawing.Color.Black;
            this.btn_material.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_material.Location = new System.Drawing.Point(0, 76);
            this.btn_material.Name = "btn_material";
            this.btn_material.Size = new System.Drawing.Size(262, 78);
            this.btn_material.TabIndex = 2;
            this.btn_material.Text = "Inbound";
            this.btn_material.UseVisualStyleBackColor = false;
            this.btn_material.Click += new System.EventHandler(this.btn_sub1_Click);
            // 
            // btn_product
            // 
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FlatAppearance.BorderSize = 0;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.Color.Black;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(0, 0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(262, 76);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Product Plan";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_sub2_Click);
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
            this.panel1.Size = new System.Drawing.Size(472, 955);
            this.panel1.TabIndex = 58;
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
            this.btn_inv.Location = new System.Drawing.Point(0, 685);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(472, 87);
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
            this.btn_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_person.ForeColor = System.Drawing.Color.Black;
            this.btn_person.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_person.ImageKey = "customer.png";
            this.btn_person.ImageList = this.imageList1;
            this.btn_person.Location = new System.Drawing.Point(0, 598);
            this.btn_person.Name = "btn_person";
            this.btn_person.Size = new System.Drawing.Size(472, 87);
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
            this.btn_proc.Location = new System.Drawing.Point(0, 511);
            this.btn_proc.Name = "btn_proc";
            this.btn_proc.Size = new System.Drawing.Size(472, 87);
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
            this.btn_log.Location = new System.Drawing.Point(0, 424);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(472, 87);
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
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.ImageKey = "production-line.png";
            this.btn_prod.ImageList = this.imageList1;
            this.btn_prod.Location = new System.Drawing.Point(0, 337);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(472, 87);
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
            this.btn_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fin.ForeColor = System.Drawing.Color.Black;
            this.btn_fin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fin.ImageKey = "deposit.png";
            this.btn_fin.ImageList = this.imageList1;
            this.btn_fin.Location = new System.Drawing.Point(0, 250);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(472, 87);
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
            this.btn_rd.Location = new System.Drawing.Point(0, 163);
            this.btn_rd.Name = "btn_rd";
            this.btn_rd.Size = new System.Drawing.Size(472, 87);
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
            this.logout.Location = new System.Drawing.Point(0, 874);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(472, 81);
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
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Black;
            this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.ImageKey = "order.png";
            this.order.ImageList = this.imageList1;
            this.order.Location = new System.Drawing.Point(0, 76);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(472, 87);
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
            this.btn_home.Size = new System.Drawing.Size(472, 76);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(749, 477);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 528);
            this.dataGridView1.TabIndex = 61;
            // 
            // ProdInOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2086, 1095);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdInOverview";
            this.Text = "ProdInOverview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProdInOverview_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private testDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource productBindingSource;
        private testDataSet testDataSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_material;
        private System.Windows.Forms.Button btn_product;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}