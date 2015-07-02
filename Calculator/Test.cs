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

        [Test]
        public void whenOperatorSetCopyVariableToResult()
        {
            var testResult4 = new Operator();
            testResult4.Combine("14");
            testResult4.setOperatorFlag("Divide");

            Assert.IsNotNullOrEmpty(testResult4._copiedResult);
        }

        [Test]
        public void userIsAbleToSetOperatorFlag()
        {
            string operation = "Divide";
            var testResult5 = new Operator();
            testResult5.Combine("12");
            testResult5.setOperatorFlag(operation);

            Assert.AreEqual(testResult5._operatorFlag,operation);
        }

        [Test]
        public void ifResultIsPopulatedDontCopyOverResultWhenOperatorSet()
        {
            Operator testResult10 = new Operator();
            testResult10._copiedResult = "10";
            testResult10._userInput = "2";
            testResult10.setOperatorFlag("Add");

            Assert.AreEqual("10",testResult10._copiedResult);
        }

        [Test]
        public void addTwoNumbersTogether()
        {
            Operator testResult7 = new Operator();
            testResult7.Combine("12");
            testResult7.setOperatorFlag("Add");
            testResult7.Combine("2");
            testResult7.resultCalculation();

            Assert.AreEqual("14",testResult7._copiedResult);

        }

        [Test]
        public void divideTwoNumbers()
        {
            Operator testResult9 = new Operator();
            testResult9.Combine("12");
            testResult9.setOperatorFlag("Divide");
            testResult9.Combine("2");
            testResult9.resultCalculation();

            Assert.AreEqual("6", testResult9._copiedResult);
        }

        [Test]
        public void whenResultCopiedValueDoesntStartWithZero()
        {
            Operator testResult8 = new Operator();
            testResult8.Combine("012");
            testResult8.setOperatorFlag("Add");

            Assert.AreEqual(testResult8._copiedResult,"12");
        }

        [Test]
        public void cantSetOperatorPriortoUserInput()
        {
            Operator testResult6 = new Operator();
            testResult6.setOperatorFlag("Multiply");

            Assert.IsNullOrEmpty(testResult6._operatorFlag);
        }

        [Test]

        private string newOperatorClass(string firstString, string secondString)
        {
            Operator testObject = new Operator();
            string updateResult = testObject.Combine(firstString);
            updateResult = testObject.Combine(secondString);
            return updateResult;
        }
    }
}
