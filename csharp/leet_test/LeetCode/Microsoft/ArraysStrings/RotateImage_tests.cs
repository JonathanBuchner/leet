using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Microsoft.ArrayStrings.RotateImage;
using leet_test.Helpers;

namespace leet_test.LeetCode.Microsoft.ArraysStrings
{
    [TestClass]
    public class RotateImage_tests
    {
        [TestMethod]
        public void Example1_Can_rotate_three_by_three_matrix()
        {
            // [[1,2,3],[4,5,6],[7,8,9]]
            var input = new int[][]
            {
                new int[] { 1, 2, 3},
                new int[] { 4, 5, 6},
                new int[] { 7, 8, 9}
            };
            // [[7,4,1],[8,5,2],[9,6,3]]
            var expeceted = new int[][]
            {
                new int[] { 7, 4, 1 },
                new int[] { 8, 5, 2 },
                new int[] { 9, 6, 3 }
            };
            var sut = new Solution();

            sut.Rotate(input);

            AssertTwoDemensionalArrays.AreEqual(expeceted, input);
        }

        [TestMethod]
        public void Example2_Can_rotate_four_by_four_matrix()
        {
            // [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
            var input = new int[][]
            {
                new int[] {  5,  1,  9, 11 },
                new int[] {  2,  4,  8, 10 },
                new int[] { 13,  3,  6,  7 },
                new int[] { 15, 14, 12, 16 }
            };
            // [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
            var expeceted = new int[][]
            {
                new int[] { 15, 13,  2,  5 },
                new int[] { 14,  3,  4,  1},
                new int[] { 12,  6,  8,  9 },
                new int[] { 16 , 7, 10, 11 }
            };
            var sut = new Solution();


            sut.Rotate(input);

            AssertTwoDemensionalArrays.AreEqual(expeceted, input);
        }

        [TestMethod]
        public void Example3_Can_rotate_1_by_1_matrix()
        {
            var input = new int[][]
            {
                new int[] { 1 },
            };
            var expeceted = new int[][]
            {
                new int[] { 1} ,
            };
            var sut = new Solution();


            sut.Rotate(input);

            AssertTwoDemensionalArrays.AreEqual(expeceted, input);
        }

        [TestMethod]
        public void Example4_Can_rotate_two_by_two_matrix()
        {
            // [[1,2],[3,4]]
            var input = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },

            };
            // [[3,1],[4,2]]
            var expeceted = new int[][]
            {
                new int[] { 3, 1} ,
                new int[] { 4, 2} ,

            };
            var sut = new Solution();


            sut.Rotate(input);

            AssertTwoDemensionalArrays.AreEqual(expeceted, input);
        }
    }
}
