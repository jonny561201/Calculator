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
        public string _operatorFlag;
            
        public string Combine(string p1)
        {
            TextBoxUserInput += p1;
            TextBoxUserInput = double.Parse(TextBoxUserInput).ToString();

            return TextBoxUserInput; 
        }

        public void setOperatorFlag(string operatorType)
        {
            if (TextBoxUserInput != null && TextBoxCalculatedResult == null)
            {
                _operatorFlag = operatorType;
                TextBoxCalculatedResult = TextBoxUserInput;
                TextBoxUserInput = null;
            }
            else if (TextBoxUserInput != null)
            {
                _operatorFlag = operatorType;
                TextBoxUserInput = null;
            }
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
        }
    }
}
