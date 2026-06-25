using NUnit.Framework;
using CalcLibrary;
namespace CalcLibrary.Tests;
[TestFixture]
public class AddAndClearTests
{
    [Test]
    public void TestAddAndClear()
    {
        SimpleCalculator calc = new SimpleCalculator();
        
        calc.Addition(10, 20);
Assert.That(calc.GetResult, Is.EqualTo(30));
calc.AllClear();
Assert.That(calc.GetResult, Is.EqualTo(0));
    }
}