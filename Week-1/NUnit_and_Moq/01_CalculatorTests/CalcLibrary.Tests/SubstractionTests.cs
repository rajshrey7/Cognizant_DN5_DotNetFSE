using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests;

[TestFixture]
public class MathLibraryTests
{
    [TestCase(10, 5, 5)]
    [TestCase(20, 10, 10)]
    [TestCase(5, 10, -5)]
    [TestCase(-10, -5, -5)]
    public void Subtraction_ValidInputs_ReturnsExpectedResult(
        double a,
        double b,
        double expected)
    {
        SimpleCalculator calc = new SimpleCalculator();

        double actual = calc.Subtraction(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}