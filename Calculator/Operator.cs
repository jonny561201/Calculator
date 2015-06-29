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
            _userInput = double.Parse(_userInput).ToString();

            return _userInput; 
        }

        public void setOperatorFlag(string operatorType)
        {
            if (_userInput != null)
            {
                operatorFlag = operatorType;
                _copiedResult = _userInput;
                _userInput = null;
            }
        }

        public void resultCalculation()
        {
            _copiedResult = (double.Parse(_copiedResult) + double.Parse(_userInput)).ToString();
        }
    }
}
