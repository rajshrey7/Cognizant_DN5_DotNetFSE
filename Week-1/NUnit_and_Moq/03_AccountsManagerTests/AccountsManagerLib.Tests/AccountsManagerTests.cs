using AccountsManagerLib;
using NUnit.Framework;
using System;

namespace AccountsManagerLib.Tests
{
    [TestFixture]
    public class AccountsManagerTests
    {
        private AccountsManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new AccountsManager();
        }

        [Test]
        public void ValidateUser_ValidUser11_ReturnsWelcomeMessage()
        {
            string result = manager.ValidateUser(
                "user_11",
                "secret@user11");

            Assert.AreEqual(
                "Welcome user_11!!!",
                result);
        }

        [Test]
        public void ValidateUser_ValidUser22_ReturnsWelcomeMessage()

        {
            string result = manager.ValidateUser(
                "user_22",
                "secret@user22");

            Assert.AreEqual(
                "Welcome user_22!!!",
                result);
        }

        [Test]
        public void ValidateUser_InvalidCredentials_ReturnsErrorMessage()
        {
            string result = manager.ValidateUser(
                "wrong",
                "wrong");

            Assert.AreEqual(
                "Invalid user id/password",
                result);
        }

        [Test]
        public void ValidateUser_EmptyUserId_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(
                () => manager.ValidateUser("", "secret@user11"));
        }

        [Test]
        public void ValidateUser_EmptyPassword_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(
                () => manager.ValidateUser("user_11", ""));
        }

        [Test]
        public void ValidateUser_NullInputs_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(
                () => manager.ValidateUser(null, null));
        }
    }
}