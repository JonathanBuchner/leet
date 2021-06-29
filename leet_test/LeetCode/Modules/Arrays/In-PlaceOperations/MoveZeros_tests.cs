using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Arrays.In_PlaceOperations.MoveZeros;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.Arrays.In_PlaceOperations
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
    }
}
