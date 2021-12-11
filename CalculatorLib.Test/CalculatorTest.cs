using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLib.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_5_10_15()
        {
            int x = 5;
            int y = 10;
            double expected = 15;

            var actual = Calculator.Add(x, y);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sub_10_5_5()
        {
            int x = 10;
            int y = 5;
            double expected = 5;

            var actual = Calculator.Sub(x, y);
            
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Mult_10_5_50()
        {
            int x = 10;
            int y = 5;
            double expected = 50;

            var actual = Calculator.Mult(x, y);
            
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Div_10_5_2()
        {
            int x = 10;
            int y = 5;
            double expected = 2;

            var actual = Calculator.Div(x, y);
            
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Div_Exception()
        {
            Assert.ThrowsException<DivideByZeroException>(Action);
        }

        private void Action()
        {
            int x = 10;
            int y = 0;
            Calculator.Div(x, y);
        }
    }
}