//About: Credits
//Made by Thomas Landry
//9/8/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tlandry_cs4800_Assignment1
{
    public partial class Form1 : Form
    {
        //String: nextOp
        //Holds the idicator for the next operation to perform
        string nextOp = "";

        //Float: operand
        //Holds the number to be operated on
        float operand = 0;


        public Form1()
        {
            InitializeComponent();
        }
        //Function: ZeroButton_Click
        //Adds the number 0 to the calculator display
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        //Function: OneButton_Click
        //Adds the number 1 to the calculator display       
        private void OneButton_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        //Function: TwoButton_Click
        //Adds the number 2 to the calculator display
        private void TwoButton_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        //Function: ThreeButton_Click
        //Adds the number 3 to the calculator display
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        //Function: FourButton_Click
        //Adds the number 4 to the calculator display
        private void FourButton_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        //Function: FiveButton_Click
        //Adds the number 5 to the calculator display
        private void FiveButton_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        //Function: SixButton_Click
        //Adds the number 6 to the calculator display
        private void SixButton_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        //Function: SevenButton_Click
        //Adds the number 7 to the calculator display
        private void SevenButton_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        //Function: EightButton_Click
        //Adds the number 8 to the calculator display
        private void EightButton_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        //Function: NineButton_Click
        //Adds the number 9 to the calculator display
        private void NineButton_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        //Function: DecimalButton_Click
        //Adds the decimal point to the calculator display and then disables the button
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
            DecimalButton.Enabled = false;
        }

        //Function: ClearButton_click
        //Clears the Operand, Display, and nextOp
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            OperandText.Text = "";
            nextOp = "";
            operand = 0;
            enableAll();
        }

        //Function: MultiplicaitonButton_Click
        //If there is not an already queued operation, puts the number in the Display
        //into the OperandText label and operand float, sets nextOp to "mult".
        //
        //Otherwise, it evaluates the currently queued operation and then exicutes the above
        private void MultiplicaitonButton_Click(object sender, EventArgs e)
        {
            if (operand == 0)
            {
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " *";
                nextOp = "mult";
            }
            else
            {
                evaluate();
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " *";
                nextOp = "mult";
            }

            Display.Text = "";
            DecimalButton.Enabled = true;

        }

        //Function: DivisionButton_Click
        //If there is not an already queued operation, puts the number in the Display
        //into the OperandText label and operand float, sets nextOp to "div".
        //
        //Otherwise, it evaluates the currently queued operation and then exicutes the above.
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (operand == 0)
            {
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " /";
                nextOp = "div";
            }
            else
            {
                evaluate();
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " /";
                nextOp = "div";
            }

            Display.Text = "";
            DecimalButton.Enabled = true;
        }

        //Function: SubtractionButton_Click
        //If there is not an already queued operation, puts the number in the Display
        //into the OperandText label and operand float, sets nextOp to "sub".
        //
        //Otherwise, it evaluates the currently queued operation and then exicutes the above.
        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            if (operand == 0)
            {
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " -";
                nextOp = "sub";
            }
            else
            {
                evaluate();
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " -";
                nextOp = "sub";
            }

            Display.Text = "";
            DecimalButton.Enabled = true;
        }

        //Function: AdditionButton_Click
        //If there is not an already queued operation, puts the number in the Display
        //into the OperandText label and operand float, sets nextOp to "div".
        //
        //Otherwise, it evaluates the currently queued operation and then exicutes the above.
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (operand == 0)
            {
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " +";
                nextOp = "add";
            }
            else
            {
                evaluate();
                operand = float.Parse(Display.Text);
                OperandText.Text = operand + " +";
                nextOp = "add";
            }

            Display.Text = "";
            DecimalButton.Enabled = true;
        }

        //Function: EqualsButton_Click
        //Calls the evaluate function
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            evaluate();
        }

        //Function: evaluate
        //Evaluates the current contents of the calculator based on the contents of operand
        //the Display and nextOp.
        private void evaluate()
        {

            if (Display.Text != "")
            {
                if (operand != 0)
                {
                    if (nextOp == "mult")
                    {
                        float num = operand * float.Parse(Display.Text);
                        Display.Text = num.ToString();
                        nextOp = "";
                        OperandText.Text = "";
                        DecimalButton.Enabled = true;

                    }
                    else if (nextOp == "div")
                    {
                        if (Display.Text != "0")
                        {
                            float num = operand / float.Parse(Display.Text);
                            Display.Text = num.ToString();
                            nextOp = "";
                            OperandText.Text = "";
                            DecimalButton.Enabled = true;

                        }
                        else
                        {
                            Display.Text = "ERROR";
                            disableAll();
                        }

                    }
                    else if (nextOp == "sub")
                    {
                        float num = operand - float.Parse(Display.Text);
                        Display.Text = num.ToString();
                        nextOp = "";
                        OperandText.Text = "";
                        DecimalButton.Enabled = true;

                    }
                    else if (nextOp == "add")
                    {
                        float num = operand + float.Parse(Display.Text);
                        Display.Text = num.ToString();
                        nextOp = "";
                        OperandText.Text = "";
                        DecimalButton.Enabled = true;

                    }
                }
            }
            else
            {
                Display.Text = operand.ToString();
                nextOp = "";
                OperandText.Text = "";
                DecimalButton.Enabled = true;
            }
        }

        //Function: disableAll
        //Disables all the buttons except for the ClearButton
        private void disableAll()
        {
            foreach (Control con in this.Controls)
            {
                if (con is Button)
                {
                    con.Enabled = false;
                }
            }

            ClearButton.Enabled = true;
        }

        //Function: enableAll
        //Enables all of the buttons.
        private void enableAll()
        {
            foreach (Control con in this.Controls)
            {
                if (con is Button)
                {
                    con.Enabled = true;
                }
            }
        }
    }
}
