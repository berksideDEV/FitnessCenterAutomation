using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenterAutomation
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.Show();
            this.Close();
           
        }

        private void btnUpdateDeleteStaff_Click(object sender, EventArgs e)
        {
            UpdateDeleteStaff updateDelete = new UpdateDeleteStaff();
            updateDelete.Show();
            this.Close();
        }

        private void btnStaffList_Click(object sender, EventArgs e)
        {
            StaffList stafflist = new StaffList();
            stafflist.Show();
            this.Close();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.Show();
            this.Close();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            UpdateDeleteCustomer updatedeletedustomer = new UpdateDeleteCustomer();
            updatedeletedustomer.Show();
            this.Close();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerlist = new CustomerList();
            customerlist.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
           
        }
    }
}
