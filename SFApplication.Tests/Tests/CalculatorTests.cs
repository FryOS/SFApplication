using NUnit.Framework;
using System;
using static Task1.Program;

namespace SFApplication.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void SubtractionMustSubtractAndreturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(2, calculator.Subtraction(4, 2));
        }

        [Test]
        public void SubtractionMustMultAndreturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(8, calculator.Miltiplication(4, 2));
        }

        [Test]
        public void DivisionMustDivAndreturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(2, calculator.Division(4, 2));
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Add(10, 220), Is.EqualTo(230));
        }
    }
}