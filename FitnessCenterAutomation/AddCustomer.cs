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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        Sql connection = new Sql();

        private void button2_Click(object sender, EventArgs e)
        {
            Mainpage mainpage = new Mainpage();
            mainpage.ShowDialog();
            this.Close();   
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            //Textbox dolu mu boş mu kontrol
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Name can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerSurname.Text == "")
            {
                MessageBox.Show("Surname can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerAge.Text == "")
            {
                MessageBox.Show("Age can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerPhone.Text == "")
            {
                MessageBox.Show("Phone number can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCustomerMail.Text == "")
            {
                MessageBox.Show("Mail can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Sistemde 50 den fazla üyenin olup olmadığının kontrolü
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM customer", connection.conn());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                connection.conn().Close();
                if (count >= 50)
                {
                    MessageBox.Show("There can not be more than 50 members.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //50 den fazla üye yoksa yeni üye eklensin.
                    try
                    {

                        SqlCommand command = new SqlCommand("insert into customer (name,surname,age,phone_number,mail) values (@p1,@p2,@p3,@p4,@p5)", connection.conn());
                        command.Parameters.AddWithValue("@p1", txtCustomerName.Text);
                        command.Parameters.AddWithValue("@p2", txtCustomerSurname.Text);
                        command.Parameters.AddWithValue("@p3", txtCustomerAge.Text);
                        command.Parameters.AddWithValue("@p4", txtCustomerPhone.Text);
                        command.Parameters.AddWithValue("@p5", txtCustomerMail.Text);

                        command.ExecuteNonQuery();
                        connection.conn().Close();
                        MessageBox.Show("New Customer added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                       
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
                            MessageBox.Show("An error occurred while adding the customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                    }

                    
                }



               
            }
        }

        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerAge.Text = "";
            txtCustomerMail.Text = "";
            txtCustomerPhone.Text = "";
          
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
   }

