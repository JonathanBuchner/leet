using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Arrays.Inserting.MergeSortedArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.Arrays.Inserting
{
    [TestClass]
    public class MergeSortedArrays_tests
    {
        [TestMethod]
        public void Example1_Can_merge_two_arrays()
        {
            var input1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var input1Length = 3;
            var input2 = new int[] { 2, 5, 6 };
            var input2Length = 3;
            var expected = new int[] { 1, 2, 2, 3, 5, 6 };
            var sut = new Solution();

            sut.Merge(input1, input1Length, input2, input2Length);

            CollectionAssert.AreEqual(expected, input1);
        }

        [TestMethod]
        public void Example2_Can_merge_two_arrays_if_the_second_array_is_empty()
        {
            var input1 = new int[] { 1 };
            var input1Length = 1;
            var input2 = new int[] { };
            var input2Length = 0;
            var expected = new int[] { 1 };
            var sut = new Solution();

            sut.Merge(input1, input1Length, input2, input2Length);

            CollectionAssert.AreEqual(expected, input1);
        }

        [TestMethod]
        public void Example3_Can_merge_two_arrays_if_the_first_array_is_empty()
        {
            var input1 = new int[] { 0 };
            var input1Length = 0;
            var input2 = new int[] { 1 };
            var input2Length = 1;
            var expected = new int[] { 1 };
            var sut = new Solution();

            sut.Merge(input1, input1Length, input2, input2Length);

            CollectionAssert.AreEqual(expected, input1);
        }
    }
}
