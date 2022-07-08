using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.PaintHouseIII;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PaintHouseIII_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var houses = new int[]
            {
                0,0,0,0,0
            };
            var costs = new int[][]
            {
                //[1,10],[10,1],[10,1],[1,10],[5,1]
                new int[]{ 1, 10},
                new int[]{ 10, 1},
                new int[]{ 10, 1},
                new int[]{ 1, 10},
                new int[]{ 5, 1},
            };
            var rows = 5;
            var colors = 2;
            var target = 3;
            var expected = 9;

            var actual = sut.MinCost(houses, costs, rows, colors, target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var houses = new int[]
            {
                0,2,1,2,0
            };
            var costs = new int[][]
            {
                // [1,10],[10,1],[10,1],[1,10],[5,1]
                new int[]{ 1, 10},
                new int[]{ 10, 1},
                new int[]{ 10, 1},
                new int[]{ 1, 10},
                new int[]{ 5, 1},
            };
            var rows = 5;
            var colors = 2;
            var target = 3;
            var expected = 11;

            var actual = sut.MinCost(houses, costs, rows, colors, target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var houses = new int[]
            {
                3,1,2,3
            };
            var costs = new int[][]
            {
                // [1,1,1],[1,1,1],[1,1,1],[1,1,1]
                new int[]{ 1, 1, 1},
                new int[]{ 1, 1, 1},
                new int[]{ 1, 1, 1},
                new int[]{ 1, 1, 1},
            };
            var rows = 4;
            var colors = 3;
            var target = 3;
            var expected = -1;

            var actual = sut.MinCost(houses, costs, rows, colors, target);

            Assert.AreEqual(expected, actual);
        }
    }
}
