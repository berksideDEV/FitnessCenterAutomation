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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();
        private void button2_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage();
            mainpage.Show();
            this.Close();

        }

        private void btnStaffReset_Click(object sender, EventArgs e)
        {
            txtStaffName.Clear();
            txtStaffAge.Clear();
            txtStaffMail.Clear();
            txtStaffPhone.Clear();
            txtStaffSalary.Clear();
            txtStaffSurname.Clear();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            txtStaffPhone.MaxLength = 10;
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Name can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStaffSurname.Text == "")
            {
                MessageBox.Show("Surname can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStaffAge.Text == "")
            {
                MessageBox.Show("Age can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStaffPhone.Text == "")
            {
                MessageBox.Show("Phone number can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStaffMail.Text == "")
            {
                MessageBox.Show("Mail can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStaffSalary.Text == "")
            {
                MessageBox.Show("Salary can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {

                    SqlCommand command = new SqlCommand("insert into staff (name,surname,age,phone_number,mail,salary) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection.conn());
                    command.Parameters.AddWithValue("@p1", txtStaffName.Text);
                    command.Parameters.AddWithValue("@p2", txtStaffSurname.Text);
                    command.Parameters.AddWithValue("@p3", txtStaffAge.Text);
                    command.Parameters.AddWithValue("@p4", txtStaffPhone.Text);
                    command.Parameters.AddWithValue("@p5", txtStaffMail.Text);
                    command.Parameters.AddWithValue("@p6", txtStaffSalary.Text);
                    command.ExecuteNonQuery();
                    connection.conn().Close();
                    MessageBox.Show("New Staff added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                }
              
                catch (SqlException ex)
                {
                    if (ex.Number == 2601)
                    {
                        MessageBox.Show("Phone number or e-mail is already registered in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
