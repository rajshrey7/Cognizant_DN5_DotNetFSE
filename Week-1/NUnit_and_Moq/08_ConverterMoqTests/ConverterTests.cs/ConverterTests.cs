using ConverterLib;
using CurrencyConverterApp;
using Moq;
using NUnit.Framework;

namespace ConverterTests
{
    [TestFixture]
    public class ConverterTests
    {
        private Mock<IDollarToEuroExchangeRateFeed> mockFeed;
        private ConverterLib.Converter converter;

        [SetUp]
        public void Setup()
        {
            mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            converter = new ConverterLib.Converter(mockFeed.Object);
        }

        [Test]
        public void CelsiusToKelvin_Test()
        {
            Assert.AreEqual(273.15, converter.CelsiusToKelvin(0));
        }

        [Test]
        public void KilogramToPound_Test()
        {
            Assert.AreEqual(22.05, converter.KilogramToPound(10));
        }

        [Test]
        public void KilometerToMile_Test()
        {
            Assert.AreEqual(10, converter.KilometerToMile(16.09), 0.01);
        }

        [Test]
        public void LiterToGallon_Test()
        {
            Assert.AreEqual(1, converter.LiterToGallon(3.785), 0.01);
        }

        [Test]
        public void USDToEuro_Test()
        {
            mockFeed.Setup(x => x.GetActualUSDollarValue())
                    .Returns(0.85);

            Assert.AreEqual(85, converter.USDToEuro(100));
        }
    }
}