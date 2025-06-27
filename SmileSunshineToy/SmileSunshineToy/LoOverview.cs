using SmileSunshineToy.Logistics;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class LoOverview : Form
    {
        private DataGridManager _logisticsManager;
        private DeliveryManager _deliveryManager;
        private string _currentLogisticsId = string.Empty;

        public LoOverview()
        {
            InitializeComponent();
            InitializeLogisticsSystem();
        }

        private void InitializeLogisticsSystem()
        {
            _logisticsManager = new DataGridManager("logistics", "logisticsID", "LOG");
            _deliveryManager = new DeliveryManager();
            SetupDataGridColumns();
        }

        private void SetupDataGridColumns()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("LogisticsID", "物流ID");
            dataGridView1.Columns.Add("ShipmentID", "发货ID");
            dataGridView1.Columns.Add("Status", "状态");
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string logisticsId = dataGridView1.SelectedRows[0].Cells["LogisticsID"].Value?.ToString();
                LoadLogisticsDetails(logisticsId);
            }
        }

        private void LoOverview_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLogisticsData();
                comboBox1.SelectedIndex = 0;
                filterComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"系统初始化失败: {ex.Message}");
            }
        }

        private void LoadLogisticsData()
        {
            DataTable data = _logisticsManager.LoadData();
            dataGridView1.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                FormNavigationManager.ShowInformation("请输入搜索内容");
                return;
            }

            string filterColumn = filterComboBox.SelectedItem.ToString();
            DataTable result = _logisticsManager.SearchRecords(txtSearch.Text, filterColumn);
            dataGridView1.DataSource = result;
        }

        private void LoadLogisticsDetails(string logisticsId)
        {
            if (string.IsNullOrEmpty(logisticsId)) return;

            DataTable data = _logisticsManager.LoadGridData("logistics", "logisticsID", logisticsId);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                textBox1.Text = row["logisticsID"].ToString();
                textBox2.Text = row["ShipmentID"].ToString();
                comboBox1.Text = row["status"].ToString();
                _currentLogisticsId = logisticsId;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                FormNavigationManager.ShowInformation("物流ID和发货ID不能为空");
                return;
            }

            try
            {
                DataTable logisticsTable = _logisticsManager.DataTable;
                DataRow logRow;

                if (string.IsNullOrEmpty(_currentLogisticsId))
                {
                    logRow = logisticsTable.NewRow();
                    logRow["logisticsID"] = textBox1.Text;
                    logisticsTable.Rows.Add(logRow);
                }
                else
                {
                    logRow = logisticsTable.Rows.Find(_currentLogisticsId);
                    if (logRow == null) throw new Exception("记录不存在");
                }

                logRow["ShipmentID"] = textBox2.Text;
                logRow["status"] = comboBox1.Text;

                if (_logisticsManager.SaveChanges())
                {
                    FormNavigationManager.ShowInformation("保存成功");
                    LoadLogisticsData();
                }
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"保存失败: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                FormNavigationManager.ShowInformation("请先选择物流记录");
                return;
            }

            try
            {
                string deliveryPath = _deliveryManager.GenerateDeliveryNote(textBox1.Text);
                FormNavigationManager.ShowInformation($"送货单已生成: {deliveryPath}");
            }
            catch (Exception ex)
            {
                FormNavigationManager.ShowError($"生成失败: {ex.Message}");
            }
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            _currentLogisticsId = string.Empty;
        }

        // 导航按钮事件
        private void btn_home_Click(object sender, EventArgs e) =>
              FormNavigationManager.NavigateToForm(this, typeof(Dashboard));

        private void order_Click_1(object sender, EventArgs e) =>
            FormNavigationManager.NavigateToForm(this, typeof(Form), true);

        private void btn_log_Click_1(object sender, EventArgs e) { /* 当前页面 */ }

 private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { new Login().Show(); this.Hide(); } }
        private void ProdPlanOverview_Load(object sender, EventArgs e) { }
        //private void logout_Click(object sender, EventArgs e) { if (MessageBox.Show("Confirm logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes) { new Login().Show(); this.Hide(); } }
        private void btn_sub2_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_sub1_Click(object sender, EventArgs e) { new ProdPlanOverview().Show(); this.Hide(); }
        private void btn_user_Click(object sender, EventArgs e) { new UserProfileForm().Show(); this.Hide(); }
        private void btn_inv_Click(object sender, EventArgs e) { new InvMaterial().Show(); this.Hide(); }
        private void btn_person_Click(object sender, EventArgs e) { new PerCusOverview().Show(); this.Hide(); }
        private void btn_proc_Click(object sender, EventArgs e) { new ProcOverview().Show(); this.Hide(); }
        private void btn_log_Click(object sender, EventArgs e) { new LoOverview().Show(); this.Hide(); }
        private void btn_prod_Click(object sender, EventArgs e) { new ProdInOverview().Show(); this.Hide(); }
        private void btn_fin_Click(object sender, EventArgs e) { new FinPayOverview().Show(); this.Hide(); }
        private void btn_rd_Click(object sender, EventArgs e) { new RDdash().Show(); this.Hide(); }
        private void order_Click(object sender, EventArgs e) { new SalOrderQuery().Show(); this.Hide(); }
       //private void btn_home_Click(object sender, EventArgs e) { this.Show(); this.Activate(); }
        private void cancelBtn_Click(object sender, EventArgs e) { LoadData(); }

        private void LoadData()
        {
            throw new NotImplementedException();
        }

        private void addBtn_Click(object sender, EventArgs e) { AddRecord(); }

        private void AddRecord()
        {
            throw new NotImplementedException();
        }

        private void searchBtn_Click(object sender, EventArgs e) { SearchRecords(); }

        private void SearchRecords()
        {
            throw new NotImplementedException();
        }

        private void txtPlanID_TextChanged(object sender, EventArgs e) { }
        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void btn_prod_Click_1(object sender, EventArgs e)
        {
            new ProdInOverview().Show(); this.Hide();
        }

        //private void saveBtn_Click(object sender, EventArgs e)
    }
}