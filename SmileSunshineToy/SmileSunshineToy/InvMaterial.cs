using System.Windows.Forms;
using System;

namespace SmileSunshineToy
{
    public partial class InvMaterial : DataGridViewForm
    {
        public InvMaterial() : base()
        {
            InitializeComponent();

            base.TableName = "product";
            base.PrimaryKey = "ProductID";
            base.DataGridView = dataGridView1;
            base.FilterComboBox = filterComboBox;
            base.SearchTextBox = txtSearch;
            base.AddButton = btnAdd;
            base.DeleteButton = btnDelete;
            base.SaveButton = btnSave;
            base.CancelButton = btnSave;
            base.SearchButton = btnSearch;


            filterComboBox.Items.Add("ProductID");
            filterComboBox.Items.Add("name");
            filterComboBox.Items.Add("price");
            filterComboBox.SelectedIndex = 0;

            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void InvMaterial_Load(object sender, EventArgs e) { }


        private void addBtn_Click(object sender, EventArgs e) => AddRecord();
        private void deleteBtn_Click(object sender, EventArgs e) => DeleteRecord();
        private void saveBtn_Click(object sender, EventArgs e) => SaveChanges();
        private void cancelBtn_Click(object sender, EventArgs e) => CancelChanges();
        private void searchBtn_Click(object sender, EventArgs e) => SearchRecords();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}