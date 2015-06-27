using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        private static string userInput;

        internal static string Combine(string p1)
        {
            userInput += p1;

            return userInput;
        }
    }
}
