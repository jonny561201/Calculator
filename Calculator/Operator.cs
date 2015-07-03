using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        public string TextBoxCalculatedResult { get; private set; }
        public string TextBoxUserInput { get; private set ; }
        private string _operatorFlag;
            
        public string Combine(string p1)
        {
            TextBoxUserInput += p1;
            TextBoxUserInput = double.Parse(TextBoxUserInput).ToString();

            return TextBoxUserInput; 
        }

        public void Remove()
        {
            TextBoxUserInput = TextBoxUserInput.Remove(TextBoxUserInput.Length - 1);
        }

        public void setOperatorFlag(string operatorType)
        {
            _operatorFlag = operatorType;

            if (!string.IsNullOrEmpty(TextBoxUserInput))
            {
                TextBoxCalculatedResult = TextBoxUserInput;
            }
            TextBoxUserInput = null;
        }

        public void resultCalculation()
        {
            switch (_operatorFlag)
            {
                case "Add":
                {
                    TextBoxCalculatedResult = (double.Parse(TextBoxCalculatedResult) + double.Parse(TextBoxUserInput)).ToString();
                    break;
                }
                case "Subtract":
                {
                    TextBoxCalculatedResult = (double.Parse(TextBoxCalculatedResult) - double.Parse(TextBoxUserInput)).ToString();
                    break;
                }
                case "Divide":
                {
                    TextBoxCalculatedResult = (double.Parse(TextBoxCalculatedResult) / double.Parse(TextBoxUserInput)).ToString();
                    break;
                }
                case "Multiply":
                {
                    TextBoxCalculatedResult = (double.Parse(TextBoxCalculatedResult) * double.Parse(TextBoxUserInput)).ToString();
                    break;
                }
            }
            TextBoxUserInput = "";
        }
    }
}
