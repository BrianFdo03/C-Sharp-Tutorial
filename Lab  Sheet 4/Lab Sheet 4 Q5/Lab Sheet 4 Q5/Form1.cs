using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet_4_Q5
{
    public partial class Form1 : Form
    {
        double? Num1, Num2, outcomeStore;
        bool calculateComplete;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "9";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "9";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "9";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "8";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "8";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "8";
                lblOperationStore.Text = "0";
                calculateComplete = false;

            }
            else
            {
                txtBoxInput.Text += "8";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "7";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "7";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "7";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "7";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "6";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "6";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "6";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "5";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "5";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "5";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "4";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "4";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "4";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "4";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "3";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "3";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "3";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "2";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "2";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "2";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "1";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "1";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "1";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "1";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text == "0")
            {
                txtBoxInput.Text = "0";
            }
            else if (txtBoxInput.Text == "0" && calculateComplete == false)
            {
                txtBoxInput.Text = "0";
            }
            else if (calculateComplete == true)
            {
                txtBoxInput.Text = "0";
                lblOperationStore.Text = "0";
                calculateComplete = false;
            }
            else
            {
                txtBoxInput.Text += "0";
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (lblOperationStore.Text == "0")
            {
                Num1 = Convert.ToDouble(txtBoxInput.Text);

                lblOperationStore.Text = $"{Num1} -";
                txtBoxInput.Clear();
                txtBoxInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                MessageBox.Show("Enter an input to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                Num2 = double.Parse(txtBoxInput.Text);
                outcomeStore = Num1 - Num2;

                lblOperationStore.Text = $"{outcomeStore} -";
                txtBoxInput.Clear();
                txtBoxInput.Focus();

                Num1 = outcomeStore;
                Num2 = null;
                outcomeStore = null;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (lblOperationStore.Text == "0")
            {
                Num1 = Convert.ToDouble(txtBoxInput.Text);

                lblOperationStore.Text = $"{Num1} *";
                txtBoxInput.Clear();
                txtBoxInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                MessageBox.Show("Enter an input to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                Num2 = double.Parse(txtBoxInput.Text);
                outcomeStore = Num1 * Num2;

                lblOperationStore.Text = $"{outcomeStore} *";
                txtBoxInput.Clear();
                txtBoxInput.Focus();

                Num1 = outcomeStore;
                Num2 = null;
                outcomeStore = null;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (lblOperationStore.Text == "0")
            {
                Num1 = Convert.ToDouble(txtBoxInput.Text);

                lblOperationStore.Text = $"{Num1} /";
                txtBoxInput.Clear();
                txtBoxInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                MessageBox.Show("Enter an input to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                Num2 = double.Parse(txtBoxInput.Text);
                outcomeStore = Num1 / Num2;

                lblOperationStore.Text = $"{outcomeStore} /";
                txtBoxInput.Clear();
                txtBoxInput.Focus();

                Num1 = outcomeStore;
                Num2 = null;
                outcomeStore = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblOperationStore.Text == "0")
            {
                Num1 = Convert.ToDouble(txtBoxInput.Text);

                lblOperationStore.Text = $"{Num1} +";
                txtBoxInput.Clear();
                txtBoxInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                MessageBox.Show("Enter an input to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                Num2 = double.Parse(txtBoxInput.Text);
                outcomeStore = Num1 + Num2;

                lblOperationStore.Text = $"{outcomeStore} +";
                txtBoxInput.Clear();
                txtBoxInput.Focus();

                Num1 = outcomeStore;
                Num2 = null;
                outcomeStore = null;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (Num1 == null || string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                MessageBox.Show("Should enter 2 inputs to calculate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (lblOperationStore.Text.Contains("+"))
            {
                Num2 = Convert.ToDouble(txtBoxInput.Text);
                outcomeStore = Num1 + Num2;

                lblOperationStore.Text = $"{Num1} + {Num2} = {outcomeStore}";
                txtBoxInput.Clear();
                calculateComplete = true;

                Num1 = null;
                Num2 = null;
                outcomeStore = null;
            }
            else if (lblOperationStore.Text.Contains("-"))
            {
                Num2 = Convert.ToDouble(txtBoxInput.Text);
                outcomeStore = Num1 - Num2;

                lblOperationStore.Text = $"{Num1} - {Num2} = {outcomeStore}";
                txtBoxInput.Clear();
                calculateComplete = true;

                Num1 = null;
                Num2 = null;
                outcomeStore = null;
            }
            else if (lblOperationStore.Text.Contains("*"))
            {
                Num2 = Convert.ToDouble(txtBoxInput.Text);
                outcomeStore = Num1 * Num2;

                lblOperationStore.Text = $"{Num1} * {Num2} = {outcomeStore}";
                txtBoxInput.Clear();
                calculateComplete = true;

                Num1 = null;
                Num2 = null;
                outcomeStore = null;
            }
            else
            {
                Num2 = Convert.ToDouble(txtBoxInput.Text);
                outcomeStore = Num1 / Num2;

                lblOperationStore.Text = $"{Num1} / {Num2} = {outcomeStore}";
                txtBoxInput.Clear();
                calculateComplete = true;

                Num1 = null;
                Num2 = null;
                outcomeStore = null;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text.Length > 0)
            {
                txtBoxInput.Text = txtBoxInput.Text.Remove( (txtBoxInput.Text.Length) - 1 , 1);
            }

            if (txtBoxInput.Text == "")
            {
                txtBoxInput.Text = "0";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
            lblOperationStore.Text = "0";
            Num1 = null;
            Num2 = null;
            outcomeStore = null;
            calculateComplete = false;
        }

        private void btnClearTextbox_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text.Contains("."))
            {
                MessageBox.Show("Cannot enter 2 decimal points", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtBoxInput.Text += ".";
            }
        }

        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxInput.Text))
            {
                return;
            }
            else
            {
                double currentValue = Convert.ToDouble(txtBoxInput.Text);
                txtBoxInput.Text = Convert.ToString(currentValue * -1);
            }
        }

    }
}
