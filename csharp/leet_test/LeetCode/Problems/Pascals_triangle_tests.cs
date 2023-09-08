using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.Pascals_Triangle;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class Pascals_triangle_tests
    {
        /*
         * Pascal's Triangle
         * 
         * Given an integer numRows, return the first numRows of Pascal's triangle.
         * 
         * https://leetcode.com/problems/pascals-triangle/
         */
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = 5; // Amount of Rows
            var expected = new List<IList<int>>()
            {
                new List<int>(){ 1 },
                new List<int>(){ 1, 1},
                new List<int>(){ 1, 2, 1},
                new List<int>(){ 1, 3, 3, 1},
                new List<int>(){ 1, 4, 6, 4, 1},
            };

            var actual = sut.Generate(input);

            AssertTwoDementionalLists.AreMatch(expected, (List<IList<int>>) actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = 1; // Amount of Rows
            var expected = new List<IList<int>>()
            {
                new List<int>(){ 1 },
            };

            var actual = sut.Generate(input);

            AssertTwoDementionalLists.AreMatch(expected, (List<IList<int>>) actual);
        }
    }
}
