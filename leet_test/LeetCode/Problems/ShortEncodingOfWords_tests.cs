using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Problems.ShortEncodingOfWords;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ShortEncodingOfWords_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new string[]
            {
                "time", "me", "bell"
            };
            var expected = 10;

            var actual = sut.MinimumLengthEncoding(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new string[]
            {
                "t"
            };
            var expected = 2;

            var actual = sut.MinimumLengthEncoding(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
