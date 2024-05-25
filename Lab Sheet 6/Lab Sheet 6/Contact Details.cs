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
    public partial class Contact_Details : Form
    {
        public Contact_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Tutorial Codes\Lab Sheet 6\Lab Sheet 6\Lab Sheet 6 Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxSearch.Clear();
            txtBoxContact.Clear();
            txtBoxAddress.Clear();
            txtBoxEmail.Clear();
        }

        private void Contact_Details_Load(object sender, EventArgs e)
        {
            fillDatagrid();
        }

        void fillDatagrid()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Contact",con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtBoxSearch.Text;
            if(! string.IsNullOrWhiteSpace(search))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Contact WHERE Username LIKE '{search}%' ",con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else 
            {
                fillDatagrid();
            }
        }

        int selectedId;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Username"].Value);
                selectedId = id;

                con.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM Contact WHERE Username = '{selectedId}'", con);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if(dataReader.Read())
                {
                    txtBoxContact.Text = dataReader["Contact_no"].ToString();
                    txtBoxAddress.Text = dataReader["Address"].ToString();
                    txtBoxEmail.Text = dataReader["Email"].ToString();
                    txtBoxSearch.Text = dataReader["Username"].ToString();
                }
                dataReader.Close();

                con.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand("UPDATE Contact SET Contact_no = @Contact_no, Email = @Email, Address  = @Address WHERE Username = @Username ",con);
                cmd.Parameters.AddWithValue("@Contact_no",txtBoxContact);
                cmd.Parameters.AddWithValue("@Email",txtBoxEmail);
                cmd.Parameters.AddWithValue("@Address",txtBoxAddress);
                cmd.Parameters.AddWithValue("@Username",selectedId);
                
                cmd.ExecuteNonQuery();
                btnReset_Click(this, null);

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
        }

        bool validation()
        {
            if(string.IsNullOrWhiteSpace(txtBoxContact.Text) || string.IsNullOrWhiteSpace(txtBoxAddress.Text) || string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if(long.TryParse(txtBoxContact.Text, out _) == false)
            {
                MessageBox.Show("Contact No should have numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if(txtBoxContact.Text.Length != 10)
            {
                MessageBox.Show("Contact No should be 10 digits");

                return false;
            }
            else if(txtBoxEmail.Text.Contains(".com") && txtBoxEmail.Text.Contains("@")) 
            {
                MessageBox.Show("Enter valid email. @ and .com should be included", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else 
            {
                return true;
            }
        }

    }
}
