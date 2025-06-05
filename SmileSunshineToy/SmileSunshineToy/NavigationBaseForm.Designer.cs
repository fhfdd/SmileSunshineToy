
namespace SmileSunshineToy
{
    partial class NavigationBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationBaseForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_inv = new System.Windows.Forms.Button();
            this.btn_person = new System.Windows.Forms.Button();
            this.btn_proc = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_fin = new System.Windows.Forms.Button();
            this.btn_rd = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.btn_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(472, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1772, 156);
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
            // 
            // logout
            // 
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 1029);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(472, 90);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(472, 1119);
            this.panel1.TabIndex = 15;
            // 
            // NavigationBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2244, 1119);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NavigationBaseForm";
            this.Text = "NavigationBaseForm";
            this.Load += new System.EventHandler(this.NavigationBaseForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}