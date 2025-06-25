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
                MessageBox.Show("Please enter both User Name and Password.");
                return;
            }

            string Name = userName.Text;
            string pwd = password.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(sqlcon1))
                {
                    conn.Open();

                    string sql = "SELECT UserID, Name, Role FROM `user` " +
                                 "WHERE Name = @Name AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Password", pwd);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserSession.UserID = Convert.ToInt32(reader["UserID"]);
                            UserSession.UserName = reader["Name"].ToString();

                            string roleStr = reader["Role"].ToString();
                            if (Enum.TryParse(roleStr, out UserRole role))
                            {
                                UserSession.Role = role;
                            }
                            else
                            {
                                MessageBox.Show($"Failed to parse role: {roleStr}");
                                return;
                            }

                            this.Hide();
                            new Dashboard().Show();
                        }
                        else
                        {
                            MessageBox.Show($"Login failed. No records found for username: {Name}");

                            string testSql = "SELECT COUNT(*) FROM `user` WHERE Name = @Name";
                            MySqlCommand testCmd = new MySqlCommand(testSql, conn);
                            testCmd.Parameters.AddWithValue("@Name", Name);
                            int userCount = Convert.ToInt32(testCmd.ExecuteScalar());

                            if (userCount > 0)
                            {
                                MessageBox.Show("Username exists but password is incorrect.");
                            }
                            else
                            {
                                MessageBox.Show("Username does not exist.");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}");
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