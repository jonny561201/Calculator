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
        public void ShouldConcatenateNumbersBeforeOperator()
        {
            var testResult1 = ConcatenateUsingObject("1","2");
            Assert.AreEqual("12",testResult1);
        }

        [Test]
        public void ShouldNotIncludePrependedZero()
        {
            var testResult2  = ConcatenateUsingObject("0","1");
            Assert.AreEqual("1", testResult2);
        }

        [Test] public void ShouldConcatenateDecimal()
        {
            var testResult3 = ConcatenateUsingObject("1", ".1");
            Assert.AreEqual("1.1",testResult3);
        }

        //[Test]
        //public void whenOperatorSetCopyVariableToResult()
        //{
        //    var testResult4 = new Operator();
        //    testResult4.Combine("14");
        //    testResult4.setOperatorFlag("Divide");

        //    Assert.IsNotNullOrEmpty(testResult4._copiedResult);
        //}

        //[Test]
        //public void userIsAbleToSetOperatorFlag()
        //{
        //    string operation = "Divide";
        //    var testResult5 = new Operator();
        //    testResult5.Combine("12");
        //    testResult5.setOperatorFlag(operation);

        //    Assert.AreEqual(testResult5._operatorFlag,operation);
        //}

        //[Test]
        //public void ifResultIsPopulatedDontCopyOverResultWhenOperatorSet()
        //{
        //    Operator testResult10 = new Operator();
        //    testResult10._copiedResult = "10";
        //    testResult10._userInput = "2";
        //    testResult10.setOperatorFlag("Add");

        //    Assert.AreEqual("10",testResult10._copiedResult);
        //}

        [Test]
        public void addTwoNumbersTogether()
        {
            Operator testOperatorClass = new Operator();
            testOperatorClass.Combine("12");
            testOperatorClass.setOperatorFlag("Add");
            testOperatorClass.Combine("2");
            testOperatorClass.resultCalculation();

            Assert.AreEqual("14",testOperatorClass.TextBoxCalculatedResult);

        }

        [Test]
        public void divideTwoNumbers()
        {
            Operator testOperatorClass = new Operator();
            testOperatorClass.Combine("12");
            testOperatorClass.setOperatorFlag("Divide");
            testOperatorClass.Combine("2");
            testOperatorClass.resultCalculation();

            Assert.AreEqual("6", testOperatorClass.TextBoxCalculatedResult);
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            Operator testOperatorClass = new Operator();
            testOperatorClass.Combine("12");
            testOperatorClass.setOperatorFlag("Multiply");
            testOperatorClass.Combine("2");
            testOperatorClass.resultCalculation();

            Assert.AreEqual("24", testOperatorClass.TextBoxCalculatedResult);
        }

        [Test]
        public void SubtractTwoNumbers()
        {
            Operator testOperatorClass = new Operator();
            testOperatorClass.Combine("12");
            testOperatorClass.setOperatorFlag("Subtract");
            testOperatorClass.Combine("2");
            testOperatorClass.resultCalculation();
                
            Assert.AreEqual("10", testOperatorClass.TextBoxCalculatedResult);
        }

        //[Test]
        //public void whenResultCopiedValueDoesntStartWithZero()
        //{
        //    Operator testResult8 = new Operator();
        //    testResult8.Combine("012");
        //    testResult8.setOperatorFlag("Add");

        //    Assert.AreEqual(testResult8._copiedResult,"12");
        //}

        [Test]
        public void cantSetOperatorPriortoUserInput()
        {
            Operator testOperatorClass = new Operator();
            testOperatorClass.setOperatorFlag("Multiply");
            testOperatorClass.Combine("3");
            testOperatorClass.setOperatorFlag("Add");
            testOperatorClass.Combine("3");
            testOperatorClass.resultCalculation();

            Assert.AreEqual("6", testOperatorClass.TextBoxCalculatedResult);
        }

        [Test]
        public void ShouldPerformSubsequentOperation()
        {
            Operator testOperatorClass = new Operator();
            testOperatorClass.Combine("12");
            testOperatorClass.setOperatorFlag("Add");
            testOperatorClass.Combine("2");
            testOperatorClass.resultCalculation();
            testOperatorClass.setOperatorFlag("Multiply");
            testOperatorClass.Combine("2");
            testOperatorClass.resultCalculation();

            Assert.AreEqual("28",testOperatorClass.TextBoxCalculatedResult);
        }


        private string ConcatenateUsingObject(string firstString, string secondString)
        {
            Operator testObject = new Operator();
            testObject.Combine(firstString);
            testObject.Combine(secondString);

            return testObject.TextBoxUserInput;
        }
    }
}
