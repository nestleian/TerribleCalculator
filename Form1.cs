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
        public List<int> numbers = new List<int>();

        public int firstSet;
        public int secondSet;
        string tempSet;

        public string OperatorChoice;

        int operatorPress = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("1");
                numbers.Add(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("2");
                numbers.Add(2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("3");
                numbers.Add(3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("4");
                numbers.Add(4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("5");
                numbers.Add(5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("6");
                numbers.Add(6);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("7");
                numbers.Add(7);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("8");
                numbers.Add(8);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("9");
                numbers.Add(9);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operatorPress < 2)
            {
                textBox1.AppendText("0");
                numbers.Add(0);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numbers.Clear();
            firstSet = 0;
            secondSet = 0;
            operatorPress = 0;
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
            numbers.Clear();
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
            numbers.Clear();
            OperatorChoice = "Subtract";
        }

        public void addNumbersToSet()
        {
            if (firstSet <= 0)
            {
                foreach (int temp in numbers)
                {
                    tempSet += temp.ToString();
                }

                firstSet = int.Parse(tempSet);
                tempSet = "";
            }

            else
            {
                foreach (int temp in numbers)
                {
                    tempSet += temp.ToString();
                }
                secondSet = int.Parse(tempSet);
                tempSet = "";
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
            numbers.Clear();
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
            numbers.Clear();
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
                textBox1.AppendText(maths.Subtraction(firstSet, secondSet).ToString());
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
