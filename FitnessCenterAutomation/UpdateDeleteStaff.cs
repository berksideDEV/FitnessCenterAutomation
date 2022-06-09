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
    public partial class UpdateDeleteStaff : Form
    {
        public UpdateDeleteStaff()
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

        private void UpdateDeleteStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDataSet.staff);

        }

        private void StaffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;
            string id,name, surname, age, phone, mail, salary;
            selected = StaffDataGridView.SelectedCells[0].RowIndex;
            id = StaffDataGridView.Rows[selected].Cells[0].Value.ToString();
            name = StaffDataGridView.Rows[selected].Cells[1].Value.ToString();
            surname = StaffDataGridView.Rows[selected].Cells[2].Value.ToString();
            age = StaffDataGridView.Rows[selected].Cells[3].Value.ToString();
            phone = StaffDataGridView.Rows[selected].Cells[4].Value.ToString();
            mail = StaffDataGridView.Rows[selected].Cells[5].Value.ToString();
            salary = StaffDataGridView.Rows[selected].Cells[6].Value.ToString();

            txtStaffId.Text = id;
            txtStaffName.Text = name;
            txtStaffSurname.Text = surname;
            txtStaffAge.Text = age;
            txtStaffPhone.Text = phone;
            txtStaffMail.Text = mail;
            txtStaffSalary.Text = salary;
        }

        private void btnStaffReset_Click(object sender, EventArgs e)
        {
            txtStaffId.Text = "";
            txtStaffName.Text = "";
            txtStaffSurname.Text = "";
            txtStaffAge.Text = "";
            txtStaffPhone.Text = "";
            txtStaffMail.Text = "";
            txtStaffSalary.Text = "";
        }

        private void btnStaffUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("update staff set name = @p1,surname = @p2, age= @p3 ,mail=@p4 ,phone_number=@p5,salary=@p6 where id = @p7", connection.conn());
                cmd2.Parameters.AddWithValue("@p1", txtStaffName.Text);
                cmd2.Parameters.AddWithValue("@p2", txtStaffSurname.Text);
                cmd2.Parameters.AddWithValue("@p3", txtStaffAge.Text);
                cmd2.Parameters.AddWithValue("@p4", txtStaffMail.Text);
                cmd2.Parameters.AddWithValue("@p5", txtStaffPhone.Text);
                cmd2.Parameters.AddWithValue("@p6", txtStaffSalary.Text);
                cmd2.Parameters.AddWithValue("@p7", txtStaffId.Text);
                cmd2.ExecuteNonQuery();
                connection.conn().Close();
                MessageBox.Show("Staff updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.staffTableAdapter.Fill(this.staffDataSet.staff);

            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while updating staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("delete from staff where id=@p1", connection.conn());
                cmd1.Parameters.AddWithValue("@p1", txtStaffId.Text);
                cmd1.ExecuteNonQuery();
                connection.conn().Close();
                MessageBox.Show("Staff deleted succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.staffTableAdapter.Fill(this.staffDataSet.staff);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while deleting staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
