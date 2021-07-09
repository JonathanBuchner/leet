using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Arrays.MoveZeros;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.Arrays
{   
    [TestClass]
    public class MoveZeros_tests
    {
        [TestMethod]
        public void Example1_Can_move_zeros_to_end()
        {
            var input = new int[] { 0, 1, 0, 3, 12 };
            var expected = new int[] { 1, 3, 12, 0, 0 };
            var sut = new Solution();

            sut.MoveZeroes(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Example2_works_if_solution_is_all_zeros()
        {
            var input = new int[] { 0, 0, 0, 0 };
            var expected = new int[] { 0, 0, 0, 0 };
            var sut = new Solution();

            sut.MoveZeroes(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Can_move_zeros_to_end_for_longer_array()
        {
            var input = new int[] { 1, 1, 0, 3, 4, 5, 0, 0, 6, 12 };
            var expected = new int[] { 1, 1, 3, 4, 5, 6, 12, 0, 0, 0 };
            var sut = new Solution();

            sut.MoveZeroes(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Can_calculate_if_there_are_no_zeros()
        {
            var input = new int[] { 2, 1 };
            var expected = new int[] { 2, 1 };
            var sut = new Solution();

            sut.MoveZeroes(input);

            CollectionAssert.AreEqual(expected, input);
        }
    }
}
