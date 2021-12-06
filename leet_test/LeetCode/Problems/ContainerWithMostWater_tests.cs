using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.ContainerWithMostWater;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ContainerWithMostWater_tests
    {
        [TestMethod]
        public void MaxArea_Exampe1()
        {
            var sut = new Solution();
            var input = new int[] { 1, 1 };
            var expected = 1;

            var actual = sut.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxArea_Exampe2()
        {
            var sut = new Solution();
            var input = new int[] { 4, 3, 2, 1, 4 };
            var expected = 16;

            var actual = sut.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxArea_Exampe3()
        {
            var sut = new Solution();
            var input = new int[] { 1, 2, 1 };
            var expected = 2;

            var actual = sut.MaxArea(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
