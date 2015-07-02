using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        public string _copiedResult;
        public string _userInput;
        public string _operatorFlag;
            
        public string Combine(string p1)
        {
            _userInput += p1;
            _userInput = double.Parse(_userInput).ToString();

            return _userInput; 
        }

        public void setOperatorFlag(string operatorType)
        {
            if (_userInput != null && _copiedResult == null)
            {
                _operatorFlag = operatorType;
                _copiedResult = _userInput;
                _userInput = null;
            }
            else if (_userInput != null)
            {
                _operatorFlag = operatorType;
                _userInput = null;
            }
        }

        public void resultCalculation()
        {
            switch (_operatorFlag)
            {
                case "Add":
                {
                    _copiedResult = (double.Parse(_copiedResult) + double.Parse(_userInput)).ToString();
                    break;
                }
                case "Subtract":
                {
                    _copiedResult = (double.Parse(_copiedResult) - double.Parse(_userInput)).ToString();
                    break;
                }
                case "Divide":
                {
                    _copiedResult = (double.Parse(_copiedResult) / double.Parse(_userInput)).ToString();
                    break;
                }
                case "Multiply":
                {
                    _copiedResult = (double.Parse(_copiedResult) * double.Parse(_userInput)).ToString();
                    break;
                }
            }
        }
    }
}
