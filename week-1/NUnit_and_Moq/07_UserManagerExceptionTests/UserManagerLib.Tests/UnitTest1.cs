using NUnit.Framework;
using System;
using UserManagerLib;

namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UserTests
    {
        private User user;

        [SetUp]
        public void Setup()
        {
            user = new User();
        }

        [Test]
        public void CreateUser_ValidPAN_DoesNotThrowException()
        {
            User newUser = new User
            {
                PANCardNo = "ABCDE1234F"
            };

            Assert.DoesNotThrow(() => user.CreateUser(newUser));
        }

        [Test]
        public void CreateUser_NullPAN_ThrowsNullReferenceException()
        {
            User newUser = new User
            {
                PANCardNo = null
            };

            Assert.Throws<NullReferenceException>(() => user.CreateUser(newUser));
        }

        [Test]
        public void CreateUser_EmptyPAN_ThrowsNullReferenceException()
        {
            User newUser = new User
            {
                PANCardNo = ""
            };

            Assert.Throws<NullReferenceException>(() => user.CreateUser(newUser));
        }

        [Test]
        public void CreateUser_InvalidPANLength_ThrowsFormatException()
        {
            User newUser = new User
            {
                PANCardNo = "ABC123"
            };

            Assert.Throws<FormatException>(() => user.CreateUser(newUser));
        }

        [Test]
        public void ValidatePANCardNumber_ValidPAN_ReturnsValid()
        {
            Assert.That(user.ValidatePANCardNumber("ABCDE1234F"), Is.EqualTo("Valid"));
        }
    }
}