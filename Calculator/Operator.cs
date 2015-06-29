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
        private string _userInput;
        public string operatorFlag;
            
        public string Combine(string p1)
        {
            _userInput += p1;
            Double userInputDouble = double.Parse(_userInput);

            return userInputDouble.ToString();
        }

        public void setOperatorFlag(string operatorType)
        {
            if (_userInput != null)
            {
                operatorFlag = operatorType;
                _copiedResult = _userInput;
            }

        }
    }
}
