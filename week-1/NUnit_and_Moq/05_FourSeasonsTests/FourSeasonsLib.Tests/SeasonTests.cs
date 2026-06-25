using NUnit.Framework;
using SeasonsLib;

namespace FourSeasonsLib.Tests
{
    [TestFixture]
    public class SeasonTellerTests
    {
        private SeasonTeller teller;

        [SetUp]
        public void Setup()
        {
            teller = new SeasonTeller();
        }

        [Test]
        public void DisplaySeasonBy_February_ReturnsSpring()
        {
            Assert.AreEqual("Spring", teller.DisplaySeasonBy("February"));
        }

        [Test]
        public void DisplaySeasonBy_April_ReturnsSummer()
        {
            Assert.AreEqual("Summer", teller.DisplaySeasonBy("April"));
        }

        [Test]
        public void DisplaySeasonBy_August_ReturnsMonsoon()
        {
            Assert.AreEqual("Monsoon", teller.DisplaySeasonBy("August"));
        }

        [Test]
        public void DisplaySeasonBy_November_ReturnsAutumn()
        {
            Assert.AreEqual("Autumn", teller.DisplaySeasonBy("November"));
        }

        [Test]
        public void DisplaySeasonBy_December_ReturnsWinter()
        {
            Assert.AreEqual("Winter", teller.DisplaySeasonBy("December"));
        }

        [Test]
        public void DisplaySeasonBy_InvalidMonth_ReturnsInvalidSeason()
        {
            Assert.AreEqual("Invalid Season", teller.DisplaySeasonBy("Hello"));
        }

        [Test]
        public void DisplaySeasonBy_MonthName_IsCaseInsensitive()
        {
            Assert.AreEqual("Summer", teller.DisplaySeasonBy("jUne"));
        }
    }
}