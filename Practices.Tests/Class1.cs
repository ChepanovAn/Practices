using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practices;


namespace Practices.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AdditionalTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Additional(10, 10) == 20);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Subtraction(10, 10) == 0);
        }

        [TestMethod()]
        public void MiltiplicationTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Miltiplication(10, 10) == 100);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Division(10, 10) == 1);
        }
    }
}
