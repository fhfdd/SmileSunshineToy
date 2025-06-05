using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace SmileSunshineToy
{

    public partial class Login : Form
    {
        // MySQL database connection string
        private string sqlcon1 = "Server=127.0.0.1;Database=test;Uid=root;Pwd=;";

        public Login()
        {
            InitializeComponent(); // Initialize UI components (auto-generated)
        }

        // Button click event for login attempt
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validate input completeness
            if (string.IsNullOrEmpty(userID.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please enter both User ID and Password.");
                return;
            }

            // 2. Validate User ID is a number
            int userId;
            if (!int.TryParse(userID.Text, out userId))
            {
                MessageBox.Show("User ID must be a numeric value.");
                return;
            }

            string pwd = password.Text; // Get password input

            try
            {
                // 3. Database connection and validation
                using (MySqlConnection conn = new MySqlConnection(sqlcon1))
                {
                    conn.Open(); // Open database connection

                    // SQL query with parameterization (prevents SQL injection)
                    string sql = "SELECT UserID, Name, Role FROM `User` " +
                                 "WHERE UserID = @UserID AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Password", pwd);

                    // Execute query and read results
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // If user record found
                        {
                            // 4. Populate user session data
                            UserSession.UserID = Convert.ToInt32(reader["UserID"]);
                            UserSession.UserName = reader["Name"].ToString();

                            // 5. Parse role from database to enum
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

                            // 6. Navigate to dashboard
                            MessageBox.Show("Login successful!");
                            this.Hide();
                            new Dashboard(UserSession.Role).Show();
                        }
                        else // No matching user found
                        {
                            MessageBox.Show("Invalid User ID or Password.");
                        }
                    }
                }
            }
            catch (Exception ex) // Catch any database/connection errors
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
            // 实现窗体加载逻辑
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
        //endregion
    }
}