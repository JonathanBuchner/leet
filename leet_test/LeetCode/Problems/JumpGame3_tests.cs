using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.JumpGame3;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class JumpGame3_tests
    {
        [TestMethod]
        public void CanReach_Example1()
        {
            var sut = new Solution();
            var input_arr = new int[] { 4, 2, 3, 0, 3, 1, 2 };
            var input_start = 5;
            var expected = true;

            var actual = sut.CanReach(input_arr, input_start);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanReach_Example2()
        {
            var sut = new Solution();
            var input_arr = new int[] { 4, 2, 3, 0, 3, 1, 2 };
            var input_start = 0;
            var expected = true;

            var actual = sut.CanReach(input_arr, input_start);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanReach_Example3()
        {
            var sut = new Solution();
            var input_arr = new int[] { 3, 0, 2, 1, 2 };
            var input_start = 2;
            var expected = true;

            var actual = sut.CanReach(input_arr, input_start);

            Assert.AreEqual(expected, actual);
        }
    }
}
