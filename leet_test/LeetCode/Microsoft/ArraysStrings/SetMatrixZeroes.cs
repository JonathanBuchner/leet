using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Microsoft.ArrayStrings.SetMatrixZeroes;
using leet_test.Helpers;

namespace leet_test.LeetCode.Microsoft.ArraysStrings
{
    [TestClass]
    public class SetMatrixZeroes
    {
        [TestMethod]
        public void Example1_Can_turn_numbers_to_zeros()
        {
            var input = new int[][] {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 }
            };
            var expected = new int[][] {
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 0, 1 }
            };
            var sut = new Solution();

            sut.SetZeroes(input);

            AssertTwoDemensionalArrays.AreEqual(input, expected);
        }

        [TestMethod]
        public void Example2_Can_turn_problems_with_zeros_correctly()
        {
            var input = new int[][] { 
                new int[] { 0, 1, 2, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 }
            };
            var expected = new int[][] {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 4, 5, 0 },
                new int[] { 0, 3, 1, 0 }
            };
            var sut = new Solution();

            sut.SetZeroes(input);

            AssertTwoDemensionalArrays.AreEqual(input, expected);
        }
    }
}
