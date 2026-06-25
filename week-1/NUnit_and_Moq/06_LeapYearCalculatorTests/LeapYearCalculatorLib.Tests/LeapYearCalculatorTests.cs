using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCalculatorLib.Tests
{
    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new LeapYearCalculator();
        }

        [Test]
        public void IsLeapYear_Year2024_Returns1()
        {
            Assert.AreEqual(1, calculator.IsLeapYear(2024));
        }

        [Test]
        public void IsLeapYear_Year2023_Returns0()
        {
            Assert.AreEqual(0, calculator.IsLeapYear(2023));
        }

        [Test]
        public void IsLeapYear_Year2000_Returns1()
        {
            Assert.AreEqual(1, calculator.IsLeapYear(2000));
        }

        [Test]
        public void IsLeapYear_Year1900_Returns0()
        {
            Assert.AreEqual(0, calculator.IsLeapYear(1900));
        }

        [Test]
        public void IsLeapYear_YearLessThan1753_ReturnsMinus1()
        {
            Assert.AreEqual(-1, calculator.IsLeapYear(1700));
        }

        [Test]
        public void IsLeapYear_YearGreaterThan9999_ReturnsMinus1()
        {
            Assert.AreEqual(-1, calculator.IsLeapYear(10000));
        }
    }
}