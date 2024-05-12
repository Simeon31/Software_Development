using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3._0
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void zerobutton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void num01_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num02_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num03_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num04_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num05_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num06_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num07_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num08_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;

        }

        private void num09_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";

        }

        private void devidebutton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '/')
            {
                result = firstNum / secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }


        }

        private void decimalbutton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
