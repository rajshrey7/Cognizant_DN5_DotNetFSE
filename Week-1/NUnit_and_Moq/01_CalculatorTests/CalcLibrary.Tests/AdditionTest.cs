using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests;

[TestFixture]
public class AdditionTest
{
    private SimpleCalculator calc = null!;

    [SetUp]
    public void Setup()
    {
        calc = new SimpleCalculator();
    }

    [TestCase(10, 20, 30)]
    [TestCase(5, 5, 10)]
    [TestCase(-5, 5, 0)]
    [TestCase(100, 200, 300)]
    public void Addition_ValidInputs_ReturnsExpectedResult(
        double num1,
        double num2,
        double expected)
    {
        double actual = calc.Addition(num1, num2);

        Assert.That(actual, Is.EqualTo(expected));
    }
}