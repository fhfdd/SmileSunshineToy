using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy
{
    public partial class Login : Form
    {
        private string sqlcon1 = "Server=127.0.0.1;Database=test;Uid=root;Pwd=;";
        public Login()
        {
            InitializeComponent();
        }

        //user information
        public static int UserID;
        public static string UserName;


          //1.获取账号
        private void login() {
            int id = int.Parse(userID.Text);
            string pwd = password.Text;

            //2.不同用户不同界面


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
            if (string.IsNullOrEmpty(userID.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("please enter you id and password");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(sqlcon1))
                {
                    conn.Open();
                    string sql = "SELECT UserID, Name, Role FROM `User` WHERE UserID = @UserID AND Password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", int.Parse(userID.Text));
                        cmd.Parameters.AddWithValue("@Password", password.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserID = Convert.ToInt32(reader["UserID"]);
                                UserName = reader["Name"].ToString();
                                MessageBox.Show("Login successful");
                                this.Hide();
                                new Dashboard().Show();
                            }
                            else
                            {
                                MessageBox.Show("account or password discorrect");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con1 = new MySqlConnection(sqlcon1);
            con1.Open();
            MessageBox.Show("求你成功吧");
            con1.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}