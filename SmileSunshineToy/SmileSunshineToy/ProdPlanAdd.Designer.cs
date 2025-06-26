namespace SmileSunshineToy
{
    partial class ProdPlanAdd
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.ComboBox coboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PlanaddbtnSave;
        private System.Windows.Forms.ComboBox coboOrder;
        private System.Windows.Forms.ComboBox coboProduct;

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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.coboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlanaddbtnSave = new System.Windows.Forms.Button();
            this.coboOrder = new System.Windows.Forms.ComboBox();
            this.coboProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // label2 (Plan ID:)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plan ID:";

            // txtPlanID
            this.txtPlanID.Location = new System.Drawing.Point(50, 50);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(300, 25);
            this.txtPlanID.TabIndex = 1;

            // coboStatus
            this.coboStatus.FormattingEnabled = true;
            this.coboStatus.Location = new System.Drawing.Point(400, 50);
            this.coboStatus.Name = "coboStatus";
            this.coboStatus.Size = new System.Drawing.Size(200, 25);
            this.coboStatus.TabIndex = 2;
            this.coboStatus.Text = "Stutas";

            // label1 (Plan Signing Date:)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plan Signing Date:";

            // dpStartDate
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartDate.Location = new System.Drawing.Point(50, 130);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(300, 25);
            this.dpStartDate.TabIndex = 4;

            // label4 (Plan Delivery Date:)
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label4.Location = new System.Drawing.Point(50, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plan Delivery Date:";

            // dpEndDate
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEndDate.Location = new System.Drawing.Point(50, 210);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(300, 25);
            this.dpEndDate.TabIndex = 6;

            // label3 (Order ID:)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.Location = new System.Drawing.Point(50, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID:";

            // coboOrder
            this.coboOrder.FormattingEnabled = true;
            this.coboOrder.Location = new System.Drawing.Point(50, 290);
            this.coboOrder.Name = "coboOrder";
            this.coboOrder.Size = new System.Drawing.Size(300, 25);
            this.coboOrder.TabIndex = 8;
            this.coboOrder.Text = "orderID";

            // label5 (Product ID:)
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label5.Location = new System.Drawing.Point(50, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product ID:";

            // coboProduct
            this.coboProduct.FormattingEnabled = true;
            this.coboProduct.Location = new System.Drawing.Point(50, 370);
            this.coboProduct.Name = "coboProduct";
            this.coboProduct.Size = new System.Drawing.Size(300, 25);
            this.coboProduct.TabIndex = 10;
            this.coboProduct.Text = "product";

            // PlanaddbtnSave
            this.PlanaddbtnSave.Location = new System.Drawing.Point(50, 420);
            this.PlanaddbtnSave.Name = "PlanaddbtnSave";
            this.PlanaddbtnSave.Size = new System.Drawing.Size(150, 40);
            this.PlanaddbtnSave.TabIndex = 11;
            this.PlanaddbtnSave.Text = "Save";
            this.PlanaddbtnSave.UseVisualStyleBackColor = true;
            this.PlanaddbtnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(250, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ProdPlanAdd
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.PlanaddbtnSave);
            this.Controls.Add(this.coboProduct);
            this.Controls.Add(this.coboOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coboStatus);
            this.Controls.Add(this.txtPlanID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdPlanAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Production Plan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}