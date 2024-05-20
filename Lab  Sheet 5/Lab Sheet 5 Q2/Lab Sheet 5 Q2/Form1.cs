using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet_5_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Fname, Lname, DOB, Email, userName, Pass, confirmPass;

        private void assignToVariables()
        {
            //string Fname, Lname, DOB, Email, userName, Pass, confirmPass;

            Fname = txtBoxFirstName.Text;
            Lname = txtBoxLastName.Text;
            DOB = txtBoxDOB.Text;
            Email = txtBoxEmail.Text;
            userName = txtBoxUsername.Text;
            Pass = txtBoxPass.Text;
            confirmPass = txtBoxConfirmPass.Text;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            assignToVariables();

            if ( string.IsNullOrWhiteSpace(Fname) || string.IsNullOrWhiteSpace(Lname) || 
                string.IsNullOrWhiteSpace(DOB) || string.IsNullOrWhiteSpace(Email) || 
                string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(Pass) || 
                string.IsNullOrWhiteSpace(confirmPass) )
            {
                MessageBox.Show("Please fill all fields", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!(AreAllFieldsStrings(Fname, Lname, DOB, Email, userName, Pass, confirmPass)))
            {
                MessageBox.Show("All inputs should be strings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Pass != confirmPass)
            {
                MessageBox.Show("Password and Confirm password not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2 form2 = new Form2(Fname, Lname, userName, Email);
                form2.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxConfirmPass.Clear();
            txtBoxPass.Clear();
            txtBoxDOB.Clear();
            txtBoxEmail.Clear();
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxUsername.Clear();
        }

        static bool AreAllFieldsStrings(params string[] fields)
        {
            foreach (string field in fields)
            {
                if (!IsString(field))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsString(string input)
        {
            bool check = true;

            foreach (char c in input)
            {
                if ( !(char.IsLetterOrDigit(c) || char.IsSymbol(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c)) )
                {
                    check = false;
                    return check;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
