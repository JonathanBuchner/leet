using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MaximumUnitesOnATruck;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MaximumUnitesOnATruck_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_boxes = new int[][]
            {
                new int[] { 1, 3},
                new int[] { 2, 2},
                new int[] { 3, 1},
            };
             var input_truckSize = 4;
            var expected = 8;

             var actual = sut.MaximumUnits(input_boxes, input_truckSize);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_boxes = new int[][]
            {
                new int[] { 5,10},
                new int[] { 2,5},
                new int[] { 4,7},
                new int[] { 3,9},
            };
            //[5,10],[2,5],[4,7],[3,9]
             var input_truckSize = 10;
            var expected = 91;

             var actual = sut.MaximumUnits(input_boxes, input_truckSize);

            Assert.AreEqual(expected, actual);
        }

    }
}
