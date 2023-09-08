using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinCostCLimbingStairs;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinCostCLimbingStairs_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var cost = new int[]
            {
                10,15,20
            };
            var expected = 15;

            var actual = sut.MinCostClimbingStairs(cost);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var cost = new int[]
            {
                1,100,1,1,1,100,1,1,100,1
            };
            var expected = 6;

            var actual = sut.MinCostClimbingStairs(cost);

            Assert.AreEqual(expected, actual);
        }
    }
}
