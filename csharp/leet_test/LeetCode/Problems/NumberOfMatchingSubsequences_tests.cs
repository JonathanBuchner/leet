using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.NumberOfMatchingSubsequences;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class NumberOfMatchingSubsequences_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var s = "abcde";
            var words = new string[]
            {
                "a", "bb", "acd", "ace"
            };
            var expected = 3;

            var actual = sut.NumMatchingSubseq(s, words);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var s = "dsahjpjauf";
            var words = new string[]
            {
               "ahjpjau","ja","ahbwzgqnuk","tnmlanowax"
            };
            var expected = 2;

            var actual = sut.NumMatchingSubseq(s, words);

            Assert.AreEqual(expected, actual);
        }
    }
}
