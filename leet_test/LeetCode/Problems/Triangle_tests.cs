using leet.LeetCode.Problems.Triangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class Triangle_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new List<IList<int>>()
            {
                new List<int>() { 2 },
                new List<int>() { 3, 4 },
                new List<int>() { 6, 5, 7 },
                new List<int>() { 4, 1, 8, 3 },
            };
            var expected = 11;

            var actual = sut.MinimumTotal(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new List<IList<int>>()
            {
                new List<int>() { -10 },
            };
            var expected = -10;

            var actual = sut.MinimumTotal(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
