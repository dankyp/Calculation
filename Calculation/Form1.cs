using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Form1 : Form
    {
        Double resultValue;
        String operatorCalled = " ";
        bool isOperatorCalled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperatorCalled))
                textBox_Result.Clear();

            isOperatorCalled = false;
            Button button = (Button) sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button_Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEquals.PerformClick();
            }
                operatorCalled = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCalculation.Text = resultValue + " " + operatorCalled;
                isOperatorCalled = true;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCalculation.Text = "0";
        }

        private void btn_Equals(object sender, EventArgs e)
        {
            switch (operatorCalled)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
