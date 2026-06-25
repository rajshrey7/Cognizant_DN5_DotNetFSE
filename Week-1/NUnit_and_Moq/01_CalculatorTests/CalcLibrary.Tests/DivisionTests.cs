using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests;

[TestFixture]
public class DivisionTests
{
    [TestCase(10, 2, 5)]
    [TestCase(20, 4, 5)]
    [TestCase(100, 10, 10)]
    public void Division_ValidInputs_ReturnsExpectedResult(
        double a,
        double b,
        double expected)
    {
        SimpleCalculator calc = new SimpleCalculator();

        double actual = calc.Division(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Division_ByZero_ThrowsException()
    {
        SimpleCalculator calc = new SimpleCalculator();

        try
        {
            calc.Division(10, 0);

            Assert.Fail("Division by zero");
        }
        catch (ArgumentException ex)
        {
            Assert.That(
                ex.Message,
                Is.EqualTo("Second Parameter Can't be Zero"));
        }
    }
}