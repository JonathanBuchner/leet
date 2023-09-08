using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MaxAreaOfIsland;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MaxAreaOfIslands_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var grid = new int[][]
            {
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
                new int[] { 0,1,1,0,1,0,0,0,0,0,0,0,0 },
                new int[] { 0,1,0,0,1,1,0,0,1,0,1,0,0 },
                new int[] { 0,1,0,0,1,1,0,0,1,1,1,0,0 },
                new int[] { 0,0,0,0,0,0,0,0,0,0,1,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,0,0,0,0 },
            };
            var expect = 6;

            var actual = sut.MaxAreaOfIsland(grid);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var grid = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
            var expect = 0;

            var actual = sut.MaxAreaOfIsland(grid);

            Assert.AreEqual(expect, actual);
        }
    }
}
