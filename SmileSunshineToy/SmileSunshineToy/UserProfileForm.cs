using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class UserProfileForm : DataGridViewForm
    {

        public UserProfileForm()
        {
            InitializeComponent();
            InitializeUserConfig();
        }

        private void InitializeUserConfig()
        {
            // 1. 配置基类核心参数（匹配数据库）
            TableName = "user";         // 数据库表名（区分大小写）
            PrimaryKey = "UserID";      // 主键字段

            DataGridView = dataGridView1User;
            FilterComboBox = filterComboBoxUser;
            SearchTextBox = txtSearchUser;
            AddButton = btnAddUser;
            DeleteButton = btnDeleteUser;
            SaveButton = btnSaveUser;
            CancelButton = btnCancelUser;
            SearchButton = btnSearchUser;


            if (UserSession.Role != UserRole.Admin)
            {
                btnAddUser.Visible = btnDeleteUser.Visible =
                btnSaveUser.Visible = btnCancelUser.Visible = false;
                dataGridView1User.ReadOnly = true;
            }

            LoadData();
        }

            private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
