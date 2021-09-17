using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Arrays.RemoveElement;

namespace leet_test.LeetCode.Modules.Arrays
{
    [TestClass]
    public class RemoveElement_tests
    {
        [TestMethod]
        public void Example1_Can_remove_duplicates()
        {
            var sut = new Solution();
            var remove = 3;
            var input = new int[] { 3, 2, 2, 3 };
            var expectedArray = new int[] { 2, 2, 2, 3 };
            var expected = 2;

            var actual = sut.RemoveElement(input, remove);

            Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expectedArray, input);
        }
        [TestMethod]
        public void Example2_Can_remove_duplicates_longer()
        {
            var sut = new Solution();
            var remove = 2;
            var input = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var expectedArray = new int[] { 0, 1, 4, 0, 3, 0, 4, 2 };
            var expected = 5;

            var actual = sut.RemoveElement(input, remove);

            Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expectedArray, input);
        }
        [TestMethod]
        public void Test_Can_remove_if_no_duplicate()
        {
            var sut = new Solution();
            var remove = 1;
            var input = new int[] { 2, 3, 4, 5 };
            var expectedArray = new int[] { 2, 3, 4, 5 };
            var expected = 0;

            var actual = sut.RemoveElement(input, remove);

            Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expectedArray, input);
        }
    }
}
