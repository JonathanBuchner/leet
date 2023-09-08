using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.NumberOfSubmatricesThatSumToTarget;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class NumberOfSubmatricesThatSumToTarget
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var matrix =new int[][]
            {
                //[0,1,0],[1,1,1],[0,1,0]
                new int[] { 0, 1, 0},
                new int[] { 1, 1, 1},
                new int[] { 0, 1, 0},
            };
            var target = 0;
            var expected = 4;

            var actual = sut.NumSubmatrixSumTarget(matrix, target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var matrix = new int[][]
            {
                //[1,-1],[-1,1]
                new int[] { 1, -1},
                new int[] {-1, 1},
            };
            var target = 0;
            var expected = 5;

            var actual = sut.NumSubmatrixSumTarget(matrix, target);

            Assert.AreEqual(expected, actual);
        }
    }
}
