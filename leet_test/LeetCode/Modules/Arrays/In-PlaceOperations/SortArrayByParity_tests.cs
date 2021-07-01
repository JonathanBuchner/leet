using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Arrays.In_PlaceOperations.SortArraysByParity;

namespace leet_test.LeetCode.Modules.Arrays.In_PlaceOperations
{
    [TestClass]
    public class SortArrayByParity_tests
    {
        [TestMethod]
        public void Examplel1_Can_sort_by_even_odd_parity()
        {
            var input = new int[] { 3, 1, 2, 4 };
            var expected = new int[] { 2, 4, 3, 1 };
            var sut = new Solution();

            var actual = sut.SortArrayByParity(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
