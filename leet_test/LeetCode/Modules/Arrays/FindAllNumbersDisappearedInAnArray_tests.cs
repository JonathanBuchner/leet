using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Arrays.FindAllNumbersDisappearedInAnArray;

namespace leet_test.LeetCode.Modules.Arrays
{
    [TestClass]
    public class FindAllNumbersDisappearedInAnArray_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var expected =  new List<int>() { 5, 6 };

            var actual = sut.FindDisappearedNumbers(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new int[] { 1, 1 };
            var expected = new List<int>() { 2 };

            var actual = sut.FindDisappearedNumbers(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
