using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.TwoSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode
{
    [TestClass]
    public class TwoSum_tests
    {
        [TestMethod]
        public void Example1_can_find_two_numbers_that_add_to_target()
        {
            var arr = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };
            var sut = new Solution();

            var result = sut.TwoSum(arr, target);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example2_can_find_two_numbers_that_add_to_target_not_including_first_number()
        {
            var arr = new int[] { 3, 2, 4 };
            var target = 6;
            var expected = new int[] { 1, 2 };
            var sut = new Solution();

            var result = sut.TwoSum(arr, target);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example3_can_find_two_numbers_that_add_to_target_if_numbers_are_the_same()
        {
            var arr = new int[] { 3, 3};
            var target = 6;
            var expected = new int[] { 0, 1 };
            var sut = new Solution();

            var result = sut.TwoSum(arr, target);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_can_find_two_numbers_that_add_to_target_if_numbers_are_negative()
        {
            var arr = new int[] { -1, -2, -3, -4, -5 };
            var target = -8;
            var expected = new int[] { 2, 4 };
            var sut = new Solution();

            var result = sut.TwoSum(arr, target);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
