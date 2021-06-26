using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.LongestPalindromicSubstring;
using System.Linq;

namespace leet_test.LeetCode
{
    [TestClass]
    public class LongestPalindromicSubstring_tests
    {
        [TestMethod]
        public void Example1_can_return_a_longest_sub_string()
        {
            var input = "babad";
            var possibleResults = new String[] {"bab", "aba"};
            var sut = new Solution();

            var result = sut.LongestPalindrome(input);

            Assert.IsTrue(possibleResults.Contains(result));
        }

        [TestMethod]
        public void Example2_back_to_back_letters_is_palendromic()
        {
            var input = "cbbc";
            var expected = "bb";
            var sut = new Solution();

            var result = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example3_a_single_letter_is_a_palindromic()
        {
            var input = "a";
            var expected = "a";
            var sut = new Solution();

            var result = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example1_two_different_letter_string_returns_answer()
        {
            var input = "ac";
            var possibleResults = new String[] { "a", "c" };
            var sut = new Solution();

            var result = sut.LongestPalindrome(input);

            Assert.IsTrue(possibleResults.Contains(result));
        }
    }
}
