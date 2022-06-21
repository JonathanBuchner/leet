using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.FurthestBuildingYouCanReach;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class FurthestBuildingYouCanReach_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_heights = new int[]
            {
                4,2,7,6,9,14,12
            };
            var input_bricks = 5;
            var input_ladders = 1;
            var expected = 4;

            var actual = sut.FurthestBuilding(input_heights, input_bricks, input_ladders);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_heights = new int[]
            {
                4,12,2,7,3,18,20,3,19
            };
            var input_bricks = 10;
            var input_ladders = 2;
            var expected = 7;

            var actual = sut.FurthestBuilding(input_heights, input_bricks, input_ladders);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_heights = new int[]
            {
                14,3,19,3
            };
            var input_bricks = 17;
            var input_ladders = 0;
            var expected =3;

            var actual = sut.FurthestBuilding(input_heights, input_bricks, input_ladders);

            Assert.AreEqual(expected, actual);
        }
    }
}
