using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.ThreeSum;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ThreeSum_tests
    {
        [TestMethod]
        public void ThreeSum_Example1()
        {
            var sut = new Solution();
            var input = new int[] { -1, 0, 1, 2, -1, -4 };
            var expected = new List<IList<int>> 
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 },
            };

            var actual = sut.ThreeSum(input);

            AssertTwoDementionalLists.AreMatch(expected, (List<IList<int>>) actual);
        }
        [TestMethod]
        public void ThreeSum_Example2()
        {
            var sut = new Solution();
            var input = new int[] {};
            var expected = new List<IList<int>>
            {
                new List<int> { },
            };

            var actual = sut.ThreeSum(input);

            AssertTwoDementionalLists.AreMatch(expected, (List<IList<int>>)actual);
        }
        [TestMethod]
        public void ThreeSum_Example3()
        {
            var sut = new Solution();
            var input = new int[] { 0 };
            var expected = new List<IList<int>>
            {
            };

            var actual = sut.ThreeSum(input);

            AssertTwoDementionalLists.AreMatch(expected, (List<IList<int>>)actual);
        }
    }
}
