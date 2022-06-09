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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();
        private void button1_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage();
            mainpage.Show();
            this.Close();
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM staff", connection.conn());
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
             lblTotalStaff.Text = dr[0].ToString();
            }
            connection.conn().Close();

            SqlCommand command1 = new SqlCommand("SELECT COUNT (*) FROM customer", connection.conn());
            SqlDataReader dr1 = command1.ExecuteReader();
            if (dr1.Read())
            {
                lblTotalMember.Text = dr1[0].ToString();
            }
            connection.conn().Close();

            SqlCommand command2 = new SqlCommand("SELECT SUM (p_amount) FROM payment", connection.conn());
            SqlDataReader dr2 = command2.ExecuteReader();
            if (dr2.Read())
            {
                lblTotalEarnings.Text = dr2[0].ToString() + " $";
            }
            connection.conn().Close();

            // lblPara.Text = oku[0].ToString() + " TL"; (Total Earnings)


            DateTime dateTime = DateTime.Today;
            lblDashboardDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    }

