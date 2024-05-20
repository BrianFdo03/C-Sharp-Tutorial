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
    public partial class Form2 : Form
    {
        string Fname, Lname, username, email;
        public Form2(string Fname, string Lname, string username, string email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.username = username;
            this.email = email;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text += $"{Fname} {Lname}";
            lblUserName.Text += $"{username}";
            lblEmail.Text += $"{email}";
        }
    }
}
