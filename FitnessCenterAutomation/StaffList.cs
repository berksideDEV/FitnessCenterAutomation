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
    public partial class StaffList : Form
    {
        string cs = "Data Source=DESKTOP-C45MJKA\\SQLEXPRESS;Initial Catalog=FitnessCenterDB;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public StaffList()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();
        private void textBox1_Enter(object sender, EventArgs e)
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
                txtSearch.Text = "Enter Text";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage();
            mainpage.Show();
            this.Close();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSetList.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDataSetList.staff);

        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {

        }

        private void StaffDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStaffReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from staff where name like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            StaffDataGridView.DataSource = dt;
            con.Close();
        }
    }
}
