using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Arrays.In_PlaceOperations.RemoveDuplicatesFromSortedArray;

namespace leet_test.LeetCode.Modules.Arrays.In_PlaceOperations
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArray_tests
    { 
        [TestMethod]
        public void Example1_can_return_list_correctly()
        {
            var input = new int[] { 1, 1, 2 };
            var expected = new int[] { 1, 2 };
            var expectedLength = 2;
            var sut = new Solution();

            var actual = sut.RemoveDuplicates(input);

            Assert.AreEqual(expectedLength, actual);

            /*for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }*/
        }

        [TestMethod]
        public void Example2_can_return_complex_list_correctly()
        {
            var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var expected = new int[] { 0, 1, 2, 3 , 4 };
            var expectedLength = 5;
            var sut = new Solution();

            var actual = sut.RemoveDuplicates(input);

            Assert.AreEqual(expectedLength, actual);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}
