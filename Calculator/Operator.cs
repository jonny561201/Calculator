using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        private string userInput; 
            
        public string Combine(string p1)
        {
            userInput += p1;
            Double userInputDouble = Convert.ToDouble(userInput);

            return userInputDouble.ToString();
        }
    }
}
