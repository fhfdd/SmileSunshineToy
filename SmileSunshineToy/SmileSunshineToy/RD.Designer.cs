namespace SmileSunshineToy
{
    partial class RD
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.signOutLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Controls.Add(this.searchButton);
            this.topPanel.Controls.Add(this.createProjectButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(213, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1542, 50);
            this.topPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTextBox.Location = new System.Drawing.Point(150, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 28);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchButton.Location = new System.Drawing.Point(75, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 50);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            // 
            // createProjectButton
            // 
            this.createProjectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createProjectButton.Location = new System.Drawing.Point(0, 0);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(75, 50);
            this.createProjectButton.TabIndex = 2;
            this.createProjectButton.Text = "Create project";
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 34;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectID,
            this.colProjectName,
            this.colStartDate,
            this.colEndDate,
            this.colManagerID,
            this.colManagerName,
            this.colRequirement,
            this.colStatus,
            this.colDetailButton,
            this.colDeleteButton});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(213, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(1542, 665);
            this.dataGridView.TabIndex = 0;
            // 
            // colProjectID
            // 
            this.colProjectID.HeaderText = "project ID";
            this.colProjectID.MinimumWidth = 8;
            this.colProjectID.Name = "colProjectID";
            this.colProjectID.Width = 150;
            // 
            // colProjectName
            // 
            this.colProjectName.HeaderText = "project name";
            this.colProjectName.MinimumWidth = 8;
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Width = 150;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "start date";
            this.colStartDate.MinimumWidth = 8;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Width = 150;
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "end Date";
            this.colEndDate.MinimumWidth = 8;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Width = 150;
            // 
            // colManagerID
            // 
            this.colManagerID.HeaderText = "manager ID";
            this.colManagerID.MinimumWidth = 8;
            this.colManagerID.Name = "colManagerID";
            this.colManagerID.Width = 150;
            // 
            // colManagerName
            // 
            this.colManagerName.HeaderText = "manager name";
            this.colManagerName.MinimumWidth = 8;
            this.colManagerName.Name = "colManagerName";
            this.colManagerName.Width = 150;
            // 
            // colRequirement
            // 
            this.colRequirement.HeaderText = "requirement";
            this.colRequirement.MinimumWidth = 8;
            this.colRequirement.Name = "colRequirement";
            this.colRequirement.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colDetailButton
            // 
            this.colDetailButton.MinimumWidth = 8;
            this.colDetailButton.Name = "colDetailButton";
            this.colDetailButton.Text = "Detail";
            this.colDetailButton.UseColumnTextForButtonValue = true;
            this.colDetailButton.Width = 150;
            // 
            // colDeleteButton
            // 
            this.colDeleteButton.MinimumWidth = 8;
            this.colDeleteButton.Name = "colDeleteButton";
            this.colDeleteButton.Text = "Delete";
            this.colDeleteButton.UseColumnTextForButtonValue = true;
            this.colDeleteButton.Width = 150;
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.ForeColor = System.Drawing.Color.Red;
            this.signOutLabel.Location = new System.Drawing.Point(10, 190);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(80, 18);
            this.signOutLabel.TabIndex = 9;
            this.signOutLabel.Text = "sign out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Personnel information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Procurement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Logistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Production";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Financial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Research & Development";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale order";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.signOutLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(213, 715);
            this.leftPanel.TabIndex = 2;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // RD
            // 
            this.ClientSize = new System.Drawing.Size(1755, 715);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "RD";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colDetailButton;
        private System.Windows.Forms.DataGridViewButtonColumn colDeleteButton;
        private System.Windows.Forms.Label signOutLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftPanel;
    }
}