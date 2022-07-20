using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.ShortestDistanceToTargetColor;
using System.Net.Http.Headers;

namespace leet_test.LeetCode.Problems.ShortestDistanceToTagetColor
{
    [TestClass]
    public class ShortestDistanceToTagetColor
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var colors = new int[]
            {
                1,1,2,1,3,2,2,3,3
            };
            var queries = new int[][]
            {
                //[1,3],[2,2],[6,1]
                new int[] { 1, 3},
                new int[] { 2, 2},
                new int[] { 6, 1},
            };
            var expected = new List<int>()
            {
                3,0,3
            };

            var actual = sut.ShortestDistanceColor(colors, queries);

            CollectionAssert.AreEqual(expected, (List<int>) actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var colors = new int[]
            {
                1,2
            };
            var queries = new int[][]
            {
                new int[] { 0, 3},
            };
            var expected = new List<int>()
            {
                -1
            };

            var actual = sut.ShortestDistanceColor(colors, queries);

            CollectionAssert.AreEqual(expected, (List<int>) actual);
        }
    }
}
