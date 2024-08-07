using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICalculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonOne.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonTwo.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonThree.Text;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonFour.Text;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonFive.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonSix.Text;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonSeven.Text;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonEight.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonNine.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + buttonZero.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBoxDisplay.Text);
            operation = "+";
            labelOperator.Text = textBoxDisplay.Text + "" + operation;
            textBoxDisplay.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBoxDisplay.Text);
            operation = "-";
            labelOperator.Text = textBoxDisplay.Text + "" + operation;
            textBoxDisplay.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBoxDisplay.Text);
            operation = "*";
            labelOperator.Text = textBoxDisplay.Text + "" + operation;
            textBoxDisplay.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBoxDisplay.Text);
            operation = "/";
            labelOperator.Text = textBoxDisplay.Text + "" + operation;
            textBoxDisplay.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBoxDisplay.Text);
            firstNumber = firstNumber / 100;
            textBoxDisplay.Text = Convert.ToString(firstNumber);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + ".";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double secondNumber;
            //double result;

            secondNumber = Double.Parse(textBoxDisplay.Text);
            labelOperator.ResetText();

            if (operation == "+")
            {
                //result = (firstNumber + secondNumber);
                //textBoxDisplay.Text = Convert.ToString(result);
                //firstNumber = result;
                Math add = new Math();
                textBoxDisplay.Text = Convert.ToString(add.Add(firstNumber, secondNumber));
            }

            if (operation == "-")
            {
                //result = (firstNumber - secondNumber);
                //textBoxDisplay.Text = Convert.ToString(result);
                //firstNumber = result;
                Math subtract = new Math();
                textBoxDisplay.Text = Convert.ToString(subtract.Subtract(firstNumber, secondNumber));
            }

            if (operation == "*")
            {
                //result = (firstNumber * secondNumber);
                //textBoxDisplay.Text = Convert.ToString(result);
                //firstNumber = result;
                Math multiply = new Math();
                textBoxDisplay.Text = Convert.ToString(multiply.Multiply(firstNumber, secondNumber));
            }

            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBoxDisplay.Text = "Divide by zero error";
                }
                else
                {
                    //result = (firstNumber / secondNumber);
                    //textBoxDisplay.Text = Convert.ToString(result);
                    //firstNumber = result;
                    Math divide = new Math();
                    textBoxDisplay.Text = Convert.ToString(divide.Divide(firstNumber, secondNumber));
                }
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = Convert.ToString(-1 * Double.Parse(textBoxDisplay.Text));
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            try { textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1); }
            catch { textBoxDisplay.Text = "Error"; }
        }

        public interface ICalculator
        {
            double Add(double firstNumber, double secondNumber);
            double Subtract(double firstNumber, double secondNumber);
            double Multiply(double firstNumber, double secondNumber);
            double Divide(double firstNumber, double secondNumber);
        }

        public class Math : ICalculator
        {
            public double Add(double firstNumber, double secondNumber)
            {
                return firstNumber + secondNumber;
            }
            public double Subtract(double firstNumber, double secondNumber)
            {
                return firstNumber - secondNumber;
            }
            public double Multiply(double firstNumber, double secondNumber)
            {
                return firstNumber * secondNumber;
            }
            public double Divide(double firstNumber, double secondNumber)
            {
                return firstNumber / secondNumber;
            }


        }
    }
}
