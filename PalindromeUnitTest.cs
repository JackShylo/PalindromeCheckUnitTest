using System;
using PalindromeChecker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeCheckUnitTest
{
    [TestClass]
    public class PalindromeUnitTest
    {
        Methods myMethod = new Methods();

        [TestMethod]
        public void ShouldPlaindromeBool()
        {
            string Input = "A Man, A Plan, A Canal-Panama!";
            Boolean Expected = true;

            Boolean Actual = myMethod.CheckIfPalindrome(Input);

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void ShouldNotPlaindromeBool()
        {
            string Input = "Well I don't think this is a palindrome.";
            Boolean Expected = false;

            Boolean Actual = myMethod.CheckIfPalindrome(Input);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
