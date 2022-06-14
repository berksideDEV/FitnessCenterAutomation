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

namespace FitnessCenterAutomation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text.Length!=8)
                {
                    MessageBox.Show("Your password must be 8 character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from admin where name=@p1 and password=@p2", connection.conn());
                    cmd.Parameters.AddWithValue("@p1", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        Mainpage main = new Mainpage();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }
                    connection.conn().Close();
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
