using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorMain : Form
    {
        private Operator _newOperator;

        public CalculatorMain()
        {
            InitializeComponent();
            _newOperator = new Operator();
        }

        private void CalculatorMain_Load(object sender, EventArgs e)
        {
            
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(sevenButton.Text);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(eightButton.Text);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(nineButton.Text);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(fourButton.Text);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(fiveButton.Text);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(sixButton.Text);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(oneButton.Text);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(twoButton.Text);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(threeButton.Text);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(zeroButton.Text);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            createStringAndDisplayOnScreen(decimalButton.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            _newOperator.setOperatorFlag("Divide");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _newOperator.setOperatorFlag("Multiply");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            _newOperator.setOperatorFlag("Subtract");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _newOperator.setOperatorFlag("Add");
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            _newOperator.resultCalculation();
            resultBox.Text = _newOperator.TextBoxCalculatedResult;
        }






        private void createStringAndDisplayOnScreen(string numberText)
        {
            _newOperator.Combine(numberText);
            resultBox.Text = _newOperator.TextBoxUserInput;
        }

        private void CalculatorMain_KeyDown(object sender, KeyEventArgs e)
        {
            string test = e.KeyCode.ToString();

            switch (test)
            {
                case "NumPad1":
                {
                    createStringAndDisplayOnScreen(oneButton.Text);
                    break;
                }
                case "NumPad2":
                {
                    createStringAndDisplayOnScreen(twoButton.Text);
                    break;
                }
                case "NumPad3":
                {
                    createStringAndDisplayOnScreen(threeButton.Text);
                    break;
                }
                case "NumPad4":
                {
                    createStringAndDisplayOnScreen(fourButton.Text);
                    break;
                }
                case "NumPad5":
                {
                    createStringAndDisplayOnScreen(fiveButton.Text);
                    break;
                }
                case "NumPad6":
                {
                    createStringAndDisplayOnScreen(sixButton.Text);
                    break;
                }
                case "NumPad7":
                {
                    createStringAndDisplayOnScreen(sevenButton.Text);
                    break;
                }
                case "NumPad8":
                {
                    createStringAndDisplayOnScreen(eightButton.Text);
                    break;
                }
                case "NumPad9":
                {
                    createStringAndDisplayOnScreen(nineButton.Text);
                    break;
                }
                case "NumPad0":
                {
                    createStringAndDisplayOnScreen(zeroButton.Text);
                    break;
                }
                case "Add":
                {
                    _newOperator.setOperatorFlag("Add");
                    break;
                }
                case "Subtract":
                {
                    _newOperator.setOperatorFlag("Subtract");
                    break;
                }
                case "Multiply":
                {
                    _newOperator.setOperatorFlag("Multiply");
                    break;
                }
                case "Divide":
                {
                    _newOperator.setOperatorFlag("Divide");
                    break;
                }
                case "Back":
                {
                    _newOperator.Remove();
                    resultBox.Text = _newOperator.TextBoxUserInput;
                    break;
                }
            }
        }
    }
}
