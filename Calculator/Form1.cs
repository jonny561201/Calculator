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
    }
}
