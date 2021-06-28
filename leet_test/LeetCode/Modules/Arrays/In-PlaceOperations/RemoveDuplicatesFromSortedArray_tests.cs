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

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}
