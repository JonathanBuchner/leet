using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Microsoft.ArrayStrings.SpiralMatrix;

namespace leet_test.LeetCode.Microsoft.ArraysStrings
{
    [TestClass]
    public class SpiralMatrix_tests
    {
        [TestMethod]
        public void Example1_Can_return_three_by_three_matrix()
        {
            // [1,2,3],[4,5,6],[7,8,9]
            var input = new int[][]
            {
                new int[] { 1, 2 , 3 },
                new int[] { 4, 5 , 6 },
                new int[] { 7, 8 , 9 }
            };
            IList<int> expected = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            var sut = new Solution();

            var actual = sut.SpiralOrder(input);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void Example2_Can_return_three_by_four_matrix()
        {
            // [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
            var input = new int[][]
            {
                new int[] { 1, 2 , 3, 4 },
                new int[] { 5, 6 , 7, 8 },
                new int[] { 9, 10, 11, 12 }
            };
            IList<int> expected = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
            var sut = new Solution();

            var actual = sut.SpiralOrder(input);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
