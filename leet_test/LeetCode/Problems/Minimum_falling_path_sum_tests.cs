using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.Minimum_falling_path_sum;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class Minimum_falling_path_sum_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new int[][]
            {
                new int[] { 2, 1, 3 },
                new int[] { 6, 5, 4 },
                new int[] { 7, 8, 9 },
            };
            var expected = 13;

            var actual = sut.MinFallingPathSum(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new int[][]
            {
                new int[] { -19, 57},
                new int[] {-40, -5 },
            };
            var expected = -59;

            var actual = sut.MinFallingPathSum(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
