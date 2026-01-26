using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using leet.LeetCode.Problems.MinimumPairRemoval_I;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumPairRemovaltoSortArrayI
    {
        public static IEnumerable<object[]> Cases()
        {
            // Case 1:
            yield return new object[] { new int[] { 5, 2, 3, 1 }, 2 };

            // Case 2
            yield return new object[] { new int[] { 1, 2, 2 }, 0 };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void MinimumPairRemoval_tests_basic(int[] input, int expected)
        {
            var sut = new Solution();

            var result = sut.MinimumPairRemoval(input);

            Assert.AreEqual(expected, result);
        }
    }
}
