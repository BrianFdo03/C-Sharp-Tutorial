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
    public partial class Display_Details : Form
    {
        public Display_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Tutorial Codes\Lab Sheet 6\Lab Sheet 6\Lab Sheet 6 Database.mdf;Integrated Security=True;Connect Timeout=30");

        void fillDataGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer",con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void Display_Details_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(! string.IsNullOrWhiteSpace(txtBoxSearch.Text))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * Contact WHERE Username LIKE '@Username' %",con);
                cmd.Parameters.AddWithValue("@Username", txtBoxSearch.Text);

                con.Close();
            }
            else
            {
                fillDataGrid();
            }
        }
    }
}
