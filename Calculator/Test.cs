using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class Test
    {

        [Test]
        public void addTwoFiguresTogetherTest()
        {
            var testResult1 = newOperatorClass("1","2");
            Assert.AreEqual("12",testResult1);
        }

        [Test]
        public void numberStartsWithZeroTest()
        {
            var testResult2  = newOperatorClass("0","1");
            Assert.AreEqual("1", testResult2);
        }

        [Test] public void numberContainsDecimalTest()
        {
            var testResult3 = newOperatorClass("1", ".1");
            Assert.AreEqual("1.1",testResult3);
        }

        private string newOperatorClass(string firstString, string secondString)
        {
            Operator testObject = new Operator();
            string updateResult = testObject.Combine(firstString);
            updateResult = testObject.Combine(secondString);
            return updateResult;
        }
    }
}
