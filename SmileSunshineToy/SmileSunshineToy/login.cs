using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace SmileSunshineToy
{

    public partial class Login : Form
    {
        private string sqlcon1 = "Server=127.0.0.1;Database=test;Uid=root;Pwd=;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("请输入用户名和密码");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(sqlcon1))
                {
                    conn.Open();

                    // 使用参数化查询防止SQL注入
                    string sql = @"SELECT UserID, Name, Role FROM user 
                         WHERE Name = @Name AND Password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", userName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", password.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 关键修复：直接使用字符串UserID
                                UserSession.UserID = reader["UserID"].ToString();
                                UserSession.UserName = reader["Name"].ToString();

                                // 处理角色（保持原有逻辑）
                                if (Enum.TryParse(reader["Role"].ToString(), true, out UserRole role))
                                {
                                    UserSession.Role = role;
                                    this.Hide();
                                    new Dashboard().Show();
                                }
                                else
                                {
                                    MessageBox.Show("无效的用户权限");
                                }
                            }
                            else
                            {
                                MessageBox.Show("用户名或密码错误", "登录失败",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"登录错误: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Test database connection (for debugging)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con1 = new MySqlConnection(sqlcon1))
                {
                    con1.Open();
                    MessageBox.Show("Database connection test successful!");
                    con1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }

        private void NavigationBaseForm_Load(object sender, EventArgs e)
        {
        }

        //region Auto-generated event stubs (no logic needed)
        private void login() { /* Obsolete method - kept for legacy */ }
        private void button3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void login_Load(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void login_Load_1(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        //endregion
    }
}