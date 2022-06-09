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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-C45MJKA\SQLEXPRESS;Initial Catalog=FitnessCenterDB;Integrated Security=True");
        private void fillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CONCAT(name,' ',surname) as s from Customer", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(rdr);
            cbxname.ValueMember = "s";
            cbxname.DataSource = dt;
            Con.Close();
        }
        private void Populate()
        {
            Con.Open();
            string query = "select * from payment";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage();
            mainpage.Show();
            this.Close();
        }
    
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxname.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                string payperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                Con.Open();
              
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from payment where p_member = '" + cbxname.SelectedValue.ToString() + "' and p_month='" + payperiode + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already paid for this month");
                }
                else
                {
                    string query = "insert into payment (p_month,p_member,p_amount) values ('"+payperiode+ "','" + cbxname.SelectedValue.ToString() + "','" + txtAmount.Text + "')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount paid succesfully!");
                }
                Con.Close();
                Populate();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1);
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            
            fillName();
            Populate();
        }

        private void Periode_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
