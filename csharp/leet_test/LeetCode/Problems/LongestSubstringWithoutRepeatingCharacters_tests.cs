using System;
using leet.LeetCode.Problems.LongestSubstringWithoutRepeatingCharacters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharacters_tests
    {
        [TestMethod]
        public void Example1_can_calculate_length()
        {
            var test = "abcabcbb";
            var sut = new Solution();

            var response = sut.LengthOfLongestSubstring(test);

            Assert.AreEqual(3, response);
        }

        [TestMethod]
        public void Example2_return_one_for_repeating_string()
        {
            var test = "bbbbb";
            var sut = new Solution();

            var response = sut.LengthOfLongestSubstring(test);

            Assert.AreEqual(1, response);
        }

        [TestMethod]
        public void Example3_calculates_substring_not_sequence()
        {
            var test = "pwwkew";
            var sut = new Solution();

            var response = sut.LengthOfLongestSubstring(test);

            Assert.AreEqual(3, response);
        }

        [TestMethod]
        public void Example1_empty_lists_returns_0()
        {
            var test = "";
            var sut = new Solution();

            var response = sut.LengthOfLongestSubstring(test);

            Assert.AreEqual(0, response);
        }
    }
}