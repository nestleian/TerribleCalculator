using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorTest
{
    public partial class Form1 : Form
    {

        Maths maths = new Maths();

        public string numberString = "";

        public decimal firstSet;
        public decimal secondSet;

        public string OperatorChoice;

        int operatorPress = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addDigitPress(int digit)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText(digit.ToString());
                numberString += digit.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDigitPress(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDigitPress(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDigitPress(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addDigitPress(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addDigitPress(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addDigitPress(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addDigitPress(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addDigitPress(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addDigitPress(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addDigitPress(0);
        }

        private void decimalPointButton_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2 && numberString.Count() > 0)
            {
                textBox1.AppendText(".");
                numberString += ".";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstSet = 0;
            secondSet = 0;
            operatorPress = 0;
            numberString = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

            operatorPress++;
            if (operatorPress < 2)
            {
                addNumbersToSet();
                textBox1.AppendText(" + ");
            }
            else
            {
                MessageBox.Show("Can only handle two sets of numbers. Sorry, friend.");
            }
            OperatorChoice = "Add";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            operatorPress++;
            if (operatorPress < 2)
            {
                addNumbersToSet();
                textBox1.AppendText(" - ");
            }
            else
            {
                MessageBox.Show("Can only handle two sets of numbers. Sorry, friend.");
            }
            OperatorChoice = "Subtract";
        }

        public void addNumbersToSet()
        {
            if (firstSet <= 0)
            {
                firstSet = decimal.Parse(numberString);
                numberString = "";
            }

            else
            {
                secondSet = decimal.Parse(numberString);
                numberString = "";
            }

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            operatorPress++;
            if (operatorPress < 2)
            {
                addNumbersToSet();
                textBox1.AppendText(" / ");
            }
            else
            {
                MessageBox.Show("Can only handle 2 sets of numbers. Sorry, bro.");
            }
            OperatorChoice = "Division";
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            operatorPress++;
            if (operatorPress < 2)
            {
                addNumbersToSet();
                textBox1.AppendText(" * ");
            }
            else
            {
                MessageBox.Show("Can only handle 2 sets of numbers. Sorry, bro.");
            }
            OperatorChoice = "Times";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            addNumbersToSet();
            textBox1.Clear();

            if (OperatorChoice == "Subtract")
            {
                textBox1.AppendText(maths.Subtraction(firstSet, secondSet).ToString());
            }

            if (OperatorChoice == "Add")
            {
                textBox1.AppendText(maths.Addition(firstSet, secondSet).ToString());
            }

            if (OperatorChoice == "Division")
            {
                textBox1.AppendText(maths.Division(firstSet, secondSet).ToString());
            }

            if (OperatorChoice == "Times")
            {
                textBox1.AppendText(maths.Times(firstSet, secondSet).ToString());
            }
        }

    }
}
