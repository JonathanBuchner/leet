using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.MergeSortedArray;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MergSortedArray_tests
    {
        [TestMethod]
        public void CanDoSimpleMerge1()
        {
            var sut = new Solution();
            var actual_input_nums1 = new int[]
            {
                1, 2, 3, 0, 0, 0
            };
            var input_m = 3;
            var input_nums2 = new int[]
            {
                2, 5, 6
            };
            var input_n = 3;
            var expected = new int[]
            {
                1,2,2,3,5,6
            };

            sut.Merge(actual_input_nums1, input_m, input_nums2, input_n);

            CollectionAssert.AreEqual(expected, actual_input_nums1);
        }

        [TestMethod]
        public void CanDoSimpleMerge2()
        {
            var sut = new Solution();
            var actual_input_nums1 = new int[]
            {
                1
            };
            var input_m = 1;
            var input_nums2 = new int[]
            {
                
            };
            var input_n = 0;
            var expected = new int[]
            {
                1
            };

            sut.Merge(actual_input_nums1, input_m, input_nums2, input_n);

            CollectionAssert.AreEqual(expected, actual_input_nums1);
        }

        [TestMethod]
        public void CanDoSimpleMerge3()
        {
            var sut = new Solution();
            var actual_input_nums1 = new int[]
            {
                0
            };
            var input_m = 0;
            var input_nums2 = new int[]
            {
                1
            };
            var input_n = 1;
            var expected = new int[]
            {
                1
            };

            sut.Merge(actual_input_nums1, input_m, input_nums2, input_n);

            CollectionAssert.AreEqual(expected, actual_input_nums1);
        }
    }
}
