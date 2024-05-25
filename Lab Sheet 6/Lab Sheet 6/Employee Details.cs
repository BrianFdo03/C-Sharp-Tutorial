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

namespace Lab_Sheet_6
{
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Tutorial Codes\Lab Sheet 6\Lab Sheet 6\Lab Sheet 6 Database.mdf;Integrated Security=True;Connect Timeout=30");

        bool validation()
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) || string.IsNullOrWhiteSpace(txtBoxDOB.Text) || string.IsNullOrWhiteSpace(txtBoxUsername.Text) || string.IsNullOrWhiteSpace(txtBoxPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
            {                
                MessageBox.Show("Fill all fields before submitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password are not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool validationsDone = validation();

            if (validationsDone == true)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [Employee] (Name, DOB, Username, Password) VALUES (@Name, @DOB, @Username, @Password)",con);

                cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                cmd.Parameters.AddWithValue("@DOB", txtBoxDOB.Text);
                cmd.Parameters.AddWithValue("@Username", txtBoxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtBoxName.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if(rowsAffected > 0)
                {
                    MessageBox.Show("Employee Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Entering to Contact Table as well
                SqlCommand command = new SqlCommand("INSERT INTO [Contact] (Username) VALUES (@Username)", con);
                cmd.Parameters.AddWithValue("@Username", txtBoxUsername.Text);
                rowsAffected = command.ExecuteNonQuery();

                if (! (rowsAffected > 0))
                {
                    MessageBox.Show("Couldn't update the Contact Table", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxDOB.Clear();
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
        }
    }
}
