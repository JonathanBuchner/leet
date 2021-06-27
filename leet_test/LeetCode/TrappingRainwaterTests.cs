using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.TrappingRainWater;

namespace leet_test.LeetCode
{
    [TestClass]
    public class TrappingRainwaterTests
    {
        [TestMethod]
        public void Example1_can_compute_water_trapped()
        {
            var input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            var expected = 6;
            var sut = new Solution();

            var actual = sut.Trap(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example1_can_compute_water_trapped_when_highest_numbers_on_the_side()
        {
            var input = new int[] { 4, 2, 0, 3, 2, 5 };
            var expected = 9;
            var sut = new Solution();

            var actual = sut.Trap(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
