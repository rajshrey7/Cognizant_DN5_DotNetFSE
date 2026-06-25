using NUnit.Framework;
using System;
using UtilLib;

namespace UtilLib.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_ValidUrl_ReturnsHostName()
        {
            string result = parser.ParseHostName("http://www.google.com");

            Assert.AreEqual("www.google.com", result);
        }

        [Test]
        public void ParseHostName_InvalidProtocol_ThrowsFormatException()
        {
            try
            {
                parser.ParseHostName("ftp://www.google.com");

                Assert.Fail("Expected FormatException was not thrown.");
            }
            catch (FormatException)
            {
                Assert.Pass();
            }
        }
    }
}