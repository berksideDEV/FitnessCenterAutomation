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
    public partial class UpdateDeleteCustomer : Form
    {
        public UpdateDeleteCustomer()
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

        private void UpdateDeleteCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessCenterDBDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter3.Fill(this.fitnessCenterDBDataSet2.customer);
            // TODO: Bu kod satırı 'fitnessCenterDBDataSet1.customer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("update customer set name = @p1,surname = @p2, age= @p3 ,mail=@p4 ,phone_number=@p5 where id = @p6", connection.conn());
                cmd2.Parameters.AddWithValue("@p1", txtCustomerName.Text);
                cmd2.Parameters.AddWithValue("@p2", txtCustomerSurname.Text);
                cmd2.Parameters.AddWithValue("@p3", txtCustomerAge.Text);
                cmd2.Parameters.AddWithValue("@p4", txtCustomerMail.Text);
                cmd2.Parameters.AddWithValue("@p5", txtCustomerPhone.Text);
                cmd2.Parameters.AddWithValue("@p6", txtCustomerId.Text);
                cmd2.ExecuteNonQuery();
                connection.conn().Close();
                MessageBox.Show("Customer updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.customerTableAdapter3.Fill(this.fitnessCenterDBDataSet2.customer);

            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while updating Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerAge.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerMail.Text = "";
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("delete from customer where id=@p1", connection.conn());
                cmd1.Parameters.AddWithValue("@p1", txtCustomerId.Text);
                cmd1.ExecuteNonQuery();
                connection.conn().Close();
                MessageBox.Show("Customer deleted succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.customerTableAdapter3.Fill(this.fitnessCenterDBDataSet2.customer);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while deleting customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;
            string id, name, surname, age, phone, mail;
            selected = CustomerDataGridView.SelectedCells[0].RowIndex;
            id = CustomerDataGridView.Rows[selected].Cells[0].Value.ToString();
            name = CustomerDataGridView.Rows[selected].Cells[1].Value.ToString();
            surname = CustomerDataGridView.Rows[selected].Cells[2].Value.ToString();
            age = CustomerDataGridView.Rows[selected].Cells[3].Value.ToString();
            mail = CustomerDataGridView.Rows[selected].Cells[4].Value.ToString();
            phone = CustomerDataGridView.Rows[selected].Cells[5].Value.ToString();
           

            txtCustomerId.Text = id;
            txtCustomerName.Text = name;
            txtCustomerSurname.Text = surname;
            txtCustomerAge.Text = age;
            txtCustomerPhone.Text = phone;
            txtCustomerMail.Text = mail;
        }
    }
}
