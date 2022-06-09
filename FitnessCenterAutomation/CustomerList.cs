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
    public partial class CustomerList : Form
    {
        string cs = "Data Source=DESKTOP-C45MJKA\\SQLEXPRESS;Initial Catalog=FitnessCenterDB;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public CustomerList()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search by name")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search by name";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage(); 
            mainpage.Show();
            this.Close();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'customerDataSetList.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSetList.customer);

        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from customer where name like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            CustomerDataGridView.DataSource = dt;
            con.Close();
        }
    }
}
