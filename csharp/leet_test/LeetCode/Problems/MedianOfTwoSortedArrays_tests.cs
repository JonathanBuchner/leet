using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.MedianOfTwoSortedArrays;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MedianOfTwoSortedArrays_tests
    {
        [TestMethod]
        [DataRow(
            new int[] { 1, 2, 3, 4 },
            new int[] {  },
            2.5000d)
        ]
        [DataRow(
            new int[] { 1, 3 }, 
            new int[] { 2 },
            2.0000d )
        ]
        [DataRow(
            new int[] { 1, 2 },
            new int[] { 3, 4 },
            2.5000d)
        ]
        [DataRow(
            new int[] { 0, 0 },
            new int[] { 0, 0 },
            0.0000d)
        ]
        [DataRow(
            new int[] { },
            new int[] { 1 },
            1.0000d)
        ]
        [DataRow(
            new int[] { 1 },
            new int[] { 2 },
            1.5000d)
        ]
        public void FindMedianSortedArrays(int[] input_nums1, int[] input_nums2, double expected)
        {
            var sut = new Solution();

            var actual = sut.FindMedianSortedArrays(input_nums1, input_nums2);

            Assert.AreEqual(expected, actual);
        }
    }
}
