
namespace SmileSunshineToy
{
    partial class UserProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_inv = new System.Windows.Forms.Button();
            this.btn_person = new System.Windows.Forms.Button();
            this.btn_proc = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_fin = new System.Windows.Forms.Button();
            this.btn_rd = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.filterComboBoxUser = new System.Windows.Forms.ComboBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.dataGridView1User = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new SmileSunshineToy.testDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new SmileSunshineToy.testDataSetTableAdapters.userTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.btn_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(472, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1434, 156);
            this.panel3.TabIndex = 14;
            // 
            // btn_user
            // 
            this.btn_user.Image = global::SmileSunshineToy.Properties.Resources.profile_user;
            this.btn_user.Location = new System.Drawing.Point(1555, 47);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(68, 66);
            this.btn_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_user.TabIndex = 28;
            this.btn_user.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "customer.png");
            this.imageList1.Images.SetKeyName(1, "procurement.png");
            this.imageList1.Images.SetKeyName(2, "delivery-truck.png");
            this.imageList1.Images.SetKeyName(3, "production-line.png");
            this.imageList1.Images.SetKeyName(4, "deposit.png");
            this.imageList1.Images.SetKeyName(5, "analysis.png");
            this.imageList1.Images.SetKeyName(6, "product-management.png");
            this.imageList1.Images.SetKeyName(7, "order.png");
            this.imageList1.Images.SetKeyName(8, "home.png");
            this.imageList1.Images.SetKeyName(9, "");
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 985);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(472, 90);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            this.panel1.Controls.Add(this.btn_sale);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 1075);
            this.panel1.TabIndex = 15;
            // 
            // btn_inv
            // 
            this.btn_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inv.FlatAppearance.BorderSize = 0;
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inv.ForeColor = System.Drawing.Color.Black;
            this.btn_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inv.ImageKey = "product-management.png";
            this.btn_inv.ImageList = this.imageList1;
            this.btn_inv.Location = new System.Drawing.Point(0, 694);
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
            this.btn_person.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_person.ForeColor = System.Drawing.Color.Black;
            this.btn_person.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_person.ImageKey = "customer.png";
            this.btn_person.ImageList = this.imageList1;
            this.btn_person.Location = new System.Drawing.Point(0, 607);
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
            this.btn_proc.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proc.ForeColor = System.Drawing.Color.Black;
            this.btn_proc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proc.ImageKey = "procurement.png";
            this.btn_proc.ImageList = this.imageList1;
            this.btn_proc.Location = new System.Drawing.Point(0, 520);
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
            this.btn_log.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.Color.Black;
            this.btn_log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log.ImageKey = "delivery-truck.png";
            this.btn_log.ImageList = this.imageList1;
            this.btn_log.Location = new System.Drawing.Point(0, 433);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(472, 87);
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
            this.btn_prod.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.ImageKey = "production-line.png";
            this.btn_prod.ImageList = this.imageList1;
            this.btn_prod.Location = new System.Drawing.Point(0, 346);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(472, 87);
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
            this.btn_fin.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fin.ForeColor = System.Drawing.Color.Black;
            this.btn_fin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fin.ImageKey = "deposit.png";
            this.btn_fin.ImageList = this.imageList1;
            this.btn_fin.Location = new System.Drawing.Point(0, 259);
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
            this.btn_rd.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rd.ForeColor = System.Drawing.Color.Black;
            this.btn_rd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rd.ImageKey = "analysis.png";
            this.btn_rd.ImageList = this.imageList1;
            this.btn_rd.Location = new System.Drawing.Point(0, 172);
            this.btn_rd.Name = "btn_rd";
            this.btn_rd.Size = new System.Drawing.Size(472, 87);
            this.btn_rd.TabIndex = 13;
            this.btn_rd.Text = "R&&D";
            this.btn_rd.UseVisualStyleBackColor = true;
            this.btn_rd.Click += new System.EventHandler(this.btn_rd_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sale.FlatAppearance.BorderSize = 0;
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sale.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sale.ForeColor = System.Drawing.Color.Black;
            this.btn_sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sale.ImageKey = "order.png";
            this.btn_sale.ImageList = this.imageList1;
            this.btn_sale.Location = new System.Drawing.Point(0, 85);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sale.Size = new System.Drawing.Size(472, 87);
            this.btn_sale.TabIndex = 2;
            this.btn_sale.Text = "Sale Order";
            this.btn_sale.UseVisualStyleBackColor = true;
            this.btn_sale.Click += new System.EventHandler(this.order_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.ImageKey = "home.png";
            this.btn_home.ImageList = this.imageList1;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(472, 85);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // filterComboBoxUser
            // 
            this.filterComboBoxUser.FormattingEnabled = true;
            this.filterComboBoxUser.Location = new System.Drawing.Point(1169, 204);
            this.filterComboBoxUser.Name = "filterComboBoxUser";
            this.filterComboBoxUser.Size = new System.Drawing.Size(130, 26);
            this.filterComboBoxUser.TabIndex = 30;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(744, 204);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(431, 28);
            this.txtSearchUser.TabIndex = 29;
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Location = new System.Drawing.Point(1051, 315);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(124, 73);
            this.btnCancelUser.TabIndex = 28;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(884, 315);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(124, 73);
            this.btnSaveUser.TabIndex = 27;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(724, 315);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(124, 73);
            this.btnDeleteUser.TabIndex = 26;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(552, 315);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(124, 73);
            this.btnAddUser.TabIndex = 25;
            this.btnAddUser.Text = "ADD";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(614, 199);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(134, 33);
            this.btnSearchUser.TabIndex = 24;
            this.btnSearchUser.Text = "search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // dataGridView1User
            // 
            this.dataGridView1User.AllowUserToOrderColumns = true;
            this.dataGridView1User.AutoGenerateColumns = false;
            this.dataGridView1User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1User.DataSource = this.userBindingSource;
            this.dataGridView1User.Location = new System.Drawing.Point(525, 398);
            this.dataGridView1User.Name = "dataGridView1User";
            this.dataGridView1User.RowHeadersWidth = 62;
            this.dataGridView1User.RowTemplate.Height = 30;
            this.dataGridView1User.Size = new System.Drawing.Size(1257, 642);
            this.dataGridView1User.TabIndex = 23;
            this.dataGridView1User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.testDataSet;
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
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1075);
            this.Controls.Add(this.filterComboBoxUser);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.dataGridView1User);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfileForm";
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btn_user;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Button btn_person;
        private System.Windows.Forms.Button btn_proc;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_fin;
        private System.Windows.Forms.Button btn_rd;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filterComboBoxUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.DataGridView dataGridView1User;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private testDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}