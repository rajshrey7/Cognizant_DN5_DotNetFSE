using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests;

[TestFixture]
public class MultiplicationTests
{
    [TestCase(10, 5, 50)]
    [TestCase(20, 10, 200)]
    [TestCase(5, 0, 0)]
    [TestCase(-10, -5, 50)]
    public void Multiplication_ValidInputs_ReturnsExpectedResult(
        double a,
        double b,
        double expected)
    {
        SimpleCalculator calc = new SimpleCalculator();

        double actual = calc.Multiplication(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}