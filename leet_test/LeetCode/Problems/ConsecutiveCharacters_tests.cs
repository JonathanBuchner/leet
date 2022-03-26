using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.ConsecutiveCharacters;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ConsecutiveCharacters_tests
    {
        [TestMethod]
        [DataRow("leetcode", 2)]
        [DataRow("abbcccddddeeeeedcba", 5)]
        [DataRow("triplepillooooow", 5)]
        [DataRow("hooraaaaaaaaaaay", 11)]
        [DataRow("tourist", 1)]

        public void MaxPower_Examples(string input, int expected)
        {
            var sut = new Solution();

            var actual = sut.MaxPower(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
