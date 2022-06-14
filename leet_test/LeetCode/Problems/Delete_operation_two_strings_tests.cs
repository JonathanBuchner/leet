using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.Delete_operation_two_strings;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class Delete_operation_two_strings_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_word1 = "sea";
            var input_word2 = "eat";
            var expected = 2;

            var actual = sut.MinDistance(input_word1, input_word2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_word1 = "leetcode";
            var input_word2 = "etco";
            var expected = 4;

            var actual = sut.MinDistance(input_word1, input_word2);

            Assert.AreEqual(expected, actual);
        }
    }
}
