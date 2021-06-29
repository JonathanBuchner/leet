using System;
using leet.LeetCode.Modules.Arrays.Deleting.RemoveDuplicatesFromSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.Arrays.Delete
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArray_tests
    {
        [TestMethod]
        public void Example1_can_return_correct_length_and_delete_from_array()
        {
            var input = new int[] { 1, 1, 2 };
            var expected = 2;
            var expectedArray = new int[] { 1, 2 };
            var sut = new Solution();

            var actual = sut.RemoveDuplicates(input);

            Assert.AreEqual(expected, actual);

            for(var i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], input[i]);
            }
        }

        [TestMethod]
        public void Example2_can_return_correct_length_and_delete_from_array()
        {
            var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var expected = 5;
            var expectedArray = new int[] { 0, 1, 2, 3, 4 };
            var sut = new Solution();

            var actual = sut.RemoveDuplicates(input);

            Assert.AreEqual(expected, actual);

            for (var i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], input[i]);
            }
        }
    }
}
