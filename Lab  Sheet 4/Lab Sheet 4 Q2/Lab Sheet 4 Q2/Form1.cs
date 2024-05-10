using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet_4_Q2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);
            int input2 = Convert.ToInt32(txtBoxInput2.Text);

            int sum = input1 + input2;

            lblOutput.Text = $"{input1} + {input2} = {sum}";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);
            int input2 = Convert.ToInt32(txtBoxInput2.Text);

            int substract = input2 - input1;

            lblOutput.Text = $"{input2} - {input1} = {substract}";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);
            int input2 = Convert.ToInt32(txtBoxInput2.Text);

            int multiply = input2 * input1;

            lblOutput.Text = $"{input2} * {input1} = {multiply}";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(txtBoxInput1.Text);
            int input2 = Convert.ToInt32(txtBoxInput2.Text);

            int divide = input1 / input2;

            lblOutput.Text = $"{input1} / {input2} = {divide}";
        }
    }
}
