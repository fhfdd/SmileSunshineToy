namespace SmileSunshineToy
{
    partial class SalOrderQuery
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn_fin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_rd;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button orderSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.ComboBox coboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.ComboBox productID;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.ComboBox orderID;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_material;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Button btn_person;
        private System.Windows.Forms.Button btn_proc;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private testDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productionplanBindingSource1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource productionplanBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private testDataSetTableAdapters.productionplanTableAdapter productionplanTableAdapter;
        private System.Windows.Forms.BindingSource productionplanBindingSource2;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private testDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDelete;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalOrderQuery));

            // All your original control initialization and layout code remains here...

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.export.Click += new System.EventHandler(this.export_Click);
            this.btn_fin.Click += new System.EventHandler(this.btn_fin_Click);
            this.btn_rd.Click += new System.EventHandler(this.btn_rd_Click);
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.order.Click += new System.EventHandler(this.order_Click);
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            this.btn_person.Click += new System.EventHandler(this.btn_person_Click);
            this.btn_proc.Click += new System.EventHandler(this.btn_proc_Click);
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}