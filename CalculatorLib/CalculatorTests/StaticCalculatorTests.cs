using NUnit.Framework;
using CalculatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
  
    class StaticCalculatorTests
    {
        [TestCase(1, 8, 9)]
        public void AddTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 9, 1)]
        public void SubTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Sub(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(3, 1, 2)]
        public void DivTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Div(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(4, 2, 3)]
        public void ProTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Pro(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(5, 3, 4)]
        public void ModTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Mod(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
