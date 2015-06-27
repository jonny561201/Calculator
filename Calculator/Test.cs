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
        public void addTwoFiguresTogether()
        {
            Operator test = new Operator();
            string testResult = test.Combine("1");
            testResult = test.Combine("2");
            Assert.AreEqual("12",testResult);
        }

        [Test]
        public void numberStartsWithZero()
        {
            Operator test2 = new Operator();
            string testResult = test2.Combine("0");
            testResult= test2.Combine("1");
            Assert.AreEqual("1",testResult);
        }
    }
}
