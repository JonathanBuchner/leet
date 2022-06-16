using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.LongestPalindromicSubProblem;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class LongestPalindromicSubProblem_test
    {
        [TestMethod]
        public void Exampe1()
        {
            var sut = new Solution();
            var input = "cabad";
            var expected = "bab";

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Exampe2()
        {
            var sut = new Solution();
            var input = "cbbd";
            var expected = "bb";

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestPalindrome_OneItem()
        {
            var sut = new Solution();
            var input = "b";
            var expected = "b";

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestPalindrome_TwoItems()
        {
            var sut = new Solution();
            var input = "bb";
            var expected = "bb";

            var actual = sut.LongestPalindrome(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
