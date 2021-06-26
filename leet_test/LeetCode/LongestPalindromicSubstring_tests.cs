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
            var input = "cbbd";
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
        public void Example4_two_different_letter_string_returns_answer()
        {
            var input = "ac";
            var possibleResults = new String[] { "a", "c" };
            var sut = new Solution();

            var result = sut.LongestPalindrome(input);

            Assert.IsTrue(possibleResults.Contains(result) && result.Length == 1);
        }

        [TestMethod]
        public void Test_All_Same_Character_and_is_odd()
        {
            var input = "aaaaa";
            var expected = "aaaaa";
            var sut = new Solution();

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_All_Same_Character_and_is_even()
        {
            var input = "abaaba";
            var expected = "abaaba";
            var sut = new Solution();

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_can_do_palendrome_length_of_three_repeating()
        {
            var input = "ccc";
            var expected = "ccc";
            var sut = new Solution();

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
