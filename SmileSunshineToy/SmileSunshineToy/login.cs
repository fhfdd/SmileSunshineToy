using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmileSunshineToy
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        //user information
        public static int UserID;
        public static string UserName;

        //1.不同用户不同界面


        //2.获取账号
        private void Login() {
            int id = int.Parse(userID.Text);
            string pwd = password.Text;

            //获取数据库

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 验证输入是否为空
            if (string.IsNullOrEmpty(userID.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please input username or password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 数据库连接字符串
            string connectionString = "Server=.;Database=test;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT UserID, Name, Role FROM [User] WHERE UserID = @UserID AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                        int userId;
                        if (!int.TryParse(userID.Text, out userId))
                        {
                            MessageBox.Show("userid have to be interger", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Password", password.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 提取用户信息
                                UserID = (int)reader["UserID"];
                                UserName = reader["Name"].ToString();
                                string role = reader["Role"].ToString();

                                // 根据角色跳转界面（需先创建对应的窗体：AdminForm 和 SalesForm）
                                switch (role)
                                {
                                    case "Admin":
                                        new dashboard().Show(); // 管理员界面（需存在该窗体）
                                        break;
                                    case "Sales":
                                        new dashboard().Show(); // 销售界面（需存在该窗体）
                                        break;
                                    default:
                                        MessageBox.Show("该角色无访问权限", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }
                                this.Hide(); // 隐藏登录窗口
                            }
                            else
                            {
                                MessageBox.Show("account or password wrong", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库操作失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}