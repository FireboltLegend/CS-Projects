using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        /* the following variable are class variables because they have
        been initialized in the class meaning they
        can be used anywhere in the class
        */
        int firstNum = 0; /* integer variable firstNum is
        initialized and assigned the integer value 0
        */
        int result = 0; /* integer variable result is initialized
        and assigned the integer value 0
        */
        bool addButtonFlag = false; /* boolean variable addButtonFlag is
        initialized and assigned the boolean value false
        */
        bool subtractButtonFlag = false; /* boolean variable subtractButtonFlag is
        initialized and assigned the boolean value false
        */
        bool multiplyButtonFlag = false; /* boolean variable multiplyButtonFlag is
        initialized and assigned the boolean value false
        */
        bool divideButtonFlag = false; /* boolean variable divideButtonFlag is
        initialized and assigned the boolean value false
        */
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* When button1 is clicked, "1" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* When button2 is clicked, "2" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* When button3 is clicked, "3" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* When button4 is clicked, "4" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* When button5 is clicked, "5" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* When button6 is clicked, "6" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /* When button7 is clicked, "7" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /* When button8 is clicked, "8" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /* When button9 is clicked, "9" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            /* When button0 is clicked, "0" is added
            in the label NumberLabel in the text property
            */
            NumberLabel.Text += "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = int.Parse(NumberLabel.Text);  // int.Parse() converts a string to an integer
                NumberLabel.Text = "";
                addButtonFlag = true;
            }
            else
            {
                // Pop up box tells user to enter a number
                MessageBox.Show("You must enter a number!");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = int.Parse(NumberLabel.Text);  // int.Parse() converts a string to an integer
                NumberLabel.Text = "";
                subtractButtonFlag = true;
            }
            else
            {
                // Pop up box tells user to enter a number
                MessageBox.Show("You must enter a number!");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // the following code empties the variables and sets the booleans to false
            result = 0;
            firstNum = 0;
            NumberLabel.Text = "";
            addButtonFlag = false;
            subtractButtonFlag = false;
            multiplyButtonFlag = false;
            divideButtonFlag = false;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                int secondNum = int.Parse(NumberLabel.Text);
                if (addButtonFlag == true)
                {
                    // if addButtonFlag is true, secondNum is added to firstNum and stored in result
                    result = firstNum + secondNum;
                }
                else if (subtractButtonFlag == true)
                {
                    // if subtractButtonFlag is true, secondNum is subtracted from firstNum and stored in result
                    result = firstNum - secondNum;
                }
                else if (multiplyButtonFlag == true)
                {
                    // if multiplyButtonFlag is true, firstNum is multiplied by secondNum and stored in result
                    result = firstNum * secondNum;
                }
                else if (divideButtonFlag == true)
                {
                    // if divideButtonFlag is true, firstNum is divided by secondNum and stored in result
                    result = firstNum / secondNum;
                }
                // variable NumberLabel's text property is assigned result in string format
                NumberLabel.Text = result.ToString();
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = int.Parse(NumberLabel.Text);  // int.Parse() converts a string to an integer
                NumberLabel.Text = "";
                multiplyButtonFlag = true;
            }
            else
            {
                // Pop up box tells user to enter a number
                MessageBox.Show("You must enter a number!");
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = int.Parse(NumberLabel.Text);  // int.Parse() converts a string to an integer
                NumberLabel.Text = "";
                divideButtonFlag = true;
            }
            else
            {
                // Pop up box tells user to enter a number
                MessageBox.Show("You must enter a number!");
            }
        }
    }
}
