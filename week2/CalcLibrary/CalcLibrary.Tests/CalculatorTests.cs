using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalcLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(5, 7, 12)]
        [TestCase(-2, 3, 1)]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
