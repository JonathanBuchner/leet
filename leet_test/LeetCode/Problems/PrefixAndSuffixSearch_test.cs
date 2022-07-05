using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.PrefixAndSuffixSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PrefixAndSuffixSearch_test
    {
        [TestMethod]
        public void Exampl1()
        {
            var input = new string[]
            {
                "apple",
            };
            var sut = new WordFilter(input);
            var expected = 0;

            var actual = sut.F("a", "e");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            var input = new string[]
            {
                "cabaabaaaa", "ccbcababac", "bacaabccba", "bcbbcbacaa", "abcaccbcaa", "accabaccaa", "cabcbbbcca", "ababccabcb", "caccbbcbab", "bccbacbcba"
            };
            var sut = new WordFilter(input);

            var expected1 = 9;
            var actual1 = sut.F("bccbacbcba", "a");
            var expected2 = 4;
            var actual2 = sut.F("ab", "abcaccbcaa");

            /*            
            ["bccbacbcba", "a"],    9
            ["ab", "abcaccbcaa"],   4
            ["a", "aa"],            5
            ["cabaaba", "abaaaa"],  0
            ["cacc", "accbbcbab"],  8
            ["ccbcab", "bac"],      1
            ["bac", "cba"],         2
            ["ac", "accabaccaa"],   5
            ["bcbb", "aa"],         3
            ["ccbca", "cbcababac"]  1
            */

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }
    }
}
