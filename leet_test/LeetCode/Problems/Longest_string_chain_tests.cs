using leet.LeetCode.Problems.Longest_String_Chain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class Longest_string_chain_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new string[]
            {
                "a", "b", "ba", "bca", "bda", "bdca"
            };
            var expected = 4;

            var actual = sut.LongestStrChain(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new string[]
            {
                "xbc","pcxbcf","xb","cxbc","pcxbc"
            };
            var expected = 5;

            var actual = sut.LongestStrChain(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input = new string[]
            {
               "abcd","dbqca"
            };
            var expected = 1;

            var actual = sut.LongestStrChain(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
