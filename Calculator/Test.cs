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
            string testResult = Operator.Combine("1");
            testResult = Operator.Combine("2");
            Assert.AreEqual("12",testResult);
        }

        [Test]
        public void numberStartsWithZero()
        {

        }
    }
}
