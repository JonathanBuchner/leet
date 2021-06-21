using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.ValidPalindrome;

namespace leet_test.LeetCode
{
    [TestClass]
    public class ValidPalindrome_tests
    {
        [TestMethod]
        public void Example1_Can_indentify_palindrom()
        {
            var input = "A man, a plan, a canal: Panama";
            var expected = true;
            var sut = new Solution();

            var result = sut.IsPalindrome(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example1_Can_indentify_not_a_palindrom()
        {
            var input = "race a car";
            var expected = false;
            var sut = new Solution();

            var result = sut.IsPalindrome(input);

            Assert.AreEqual(expected, result);
        }
    }
}
