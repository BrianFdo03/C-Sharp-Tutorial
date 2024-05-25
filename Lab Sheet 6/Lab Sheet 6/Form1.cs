using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterEmployeeDetails_Click(object sender, EventArgs e)
        {
            Employee_Details employee_Details = new Employee_Details();
            employee_Details.Show();
            this.Hide();
            //this.Close();
        }

        private void btnEnterContactDetails_Click(object sender, EventArgs e)
        {
            Contact_Details contact_Details = new Contact_Details();
            contact_Details.Show();
            this.Hide();
            //this.Close();
        }

        private void btnDisplayEmployeeDetails_Click(object sender, EventArgs e)
        {
            Display_Details display_Details = new Display_Details();
            display_Details.Show();
            this.Hide();
            //this.Close();
        }
    }
}
