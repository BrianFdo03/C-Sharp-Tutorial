using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet_4_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool canCalculate = false;
        decimal output, tempNum = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal input1 = decimal.Parse(txtBoxInput1.Text);

            if (tempNum == 0)
            {
                lblOutput.Text = $"{input1} + ";
                tempNum = input1;
                txtBoxInput1.Clear();
                txtBoxInput1.Focus();
            }
            else if (tempNum != 0 && canCalculate == false)
            {
                lblOutput.Text += input1.ToString() + " ";
                canCalculate = true;
                
            }
            else
            {
                MessageBox.Show("2 inputs already added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);

            if (tempNum == 0)
            {
                lblOutput.Text = $"{input1} - ";
                tempNum = input1;
                txtBoxInput1.Clear();
                txtBoxInput1.Focus();
            }
            else if (tempNum != 0 && canCalculate == false)
            {
                lblOutput.Text += input1.ToString() + " ";
                canCalculate = true;
            }
            else
            {
                MessageBox.Show("2 inputs already added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);

            if (tempNum == 0)
            {
                lblOutput.Text = $"{input1} * ";
                tempNum = input1;
                txtBoxInput1.Clear();
                txtBoxInput1.Focus();
            }
            else if (tempNum != 0 && canCalculate == false)
            {
                lblOutput.Text += input1.ToString() + " ";
                canCalculate = true;
            }
            else
            {
                MessageBox.Show("2 inputs already added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);

            if (tempNum == 0)
            {
                lblOutput.Text = $"{input1} / ";
                tempNum = input1;
                txtBoxInput1.Clear();
                txtBoxInput1.Focus();
            }
            else if (tempNum != 0 && canCalculate == false)
            {
                lblOutput.Text += input1.ToString() + " ";
                canCalculate = true;
            }
            else
            {
                MessageBox.Show("2 inputs already added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (canCalculate != true)
            {
                MessageBox.Show("2 inputs should be inserted to calculate", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblOutput.Text.Contains("+"))
            {
                output = tempNum + Convert.ToInt32(txtBoxInput1.Text);
                tempNum = 0;
                canCalculate = false;
                txtBoxInput1.Clear();
            }
            else if (lblOutput.Text.Contains("-"))
            {
                output = Convert.ToInt32(txtBoxInput1.Text) - tempNum;
                tempNum = 0;
                canCalculate = false;
                txtBoxInput1.Clear();
            }
            else if (lblOutput.Text.Contains("*"))
            {
                output = tempNum * Convert.ToInt32(txtBoxInput1.Text);
                tempNum = 0;
                canCalculate = false;
                txtBoxInput1.Clear();
            }
            else
            {
                output = tempNum / Convert.ToDecimal(txtBoxInput1.Text);
                tempNum = 0;
                canCalculate = false;
                txtBoxInput1.Clear();
            }

            lblOutput.Text += "= " + output;
        }
    }
}
