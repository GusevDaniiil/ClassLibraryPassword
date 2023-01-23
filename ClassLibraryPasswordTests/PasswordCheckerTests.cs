using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_RuturnsTrue()
        {
            // Arrange.
            string password = "ASqw12$$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_4Symbols_RuturnsFalse()
        {
            // Arrange.
            string password = "Aq1$";
         

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_30Symbols_RuturnsFalse()
        {
            // Arrange.
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithDigits_RuturnsTrue()
        {
            // Arrange.
            string password = "ASDqwe1$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutDigits_RuturnsFalse()
        {
            // Arrange.
            string password = "ASDqweASD$";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_RuturnsTrue()
        {
            // Arrange.
            string password = "Aqwe123$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithousSpecSymbols_RuturnsTrue()
        {
            // Arrange.
            string password = "ASDqwe123";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_RuturnsTrue()
        {
            // Arrange.
            string password = "Aqwe123$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_RuturnsFalse()
        {
            // Arrange.
            string password = "asdqwe123$";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_RuturnsTrue()
        {
            // Arrange.
            string password = "ASDq123$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_RuturnsFalse()
        {
            // Arrange.
            string password = "ASDQWE123$";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}