using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.PaintHouse;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PaintHouse_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_costs = new int[][]
            {
                // [17,2,17],[16,16,5],[14,3,19]
                new int[] { 17, 2, 17 },
                new int[] { 16, 16, 5 },
                new int[] { 14, 3, 19 },
            };
            var expected = 10;

            var actual = sut.MinCost(input_costs);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_costs = new int[][]
            {
                new int[] { 7,6,2}
            };
            var expected = 2;

            var actual = sut.MinCost(input_costs);

            Assert.AreEqual(expected, actual);
        }
    }
}
