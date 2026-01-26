using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using leet.LeetCode.Modules.HeapSort.FindKthLargest;


namespace leet_tests.LeetCode.Modules.HeapSort.FindKthLargest
{
    [TestClass]
    public class FindKthLargest_tests
    {
        public static IEnumerable<object[]> Cases()
        {
            yield return new object[] { (new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 }; // 1 2 3 4 5 6
            yield return new object[] { (new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 }; // 1 2 3 4 5 6
            yield return new object[] { (new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 }; // 1 2 3 4 5 6
            yield return new object[] { (new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 }; // 1 2 3 4 5 6
            yield return new object[] { (new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 }; // 1 2 3 4 5 6
            yield return new object[] { (new int[] { 3, 2, 1, 5, 6, 4 }, 2), 5 }; // 1 2 3 4 5 6
            yield return new object[] { (new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 }; // 1 2 2 3 3 4 5 5 6
            yield return new object[] { (new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 }; // 1 2 2 3 3 4 5 5 6
            yield return new object[] { (new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 }; // 1 2 2 3 3 4 5 5 6
            yield return new object[] { (new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 }; // 1 2 2 3 3 4 5 5 6
            yield return new object[] { (new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 }; // 1 2 2 3 3 4 5 5 6
            yield return new object[] { (new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4 }; // 1 2 2 3 3 4 5 5 6
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void FindKthLargest_tests_basic((int[] nums, int k) input, int expected)
        {
            var sut = new Solution();

            var actual = sut.FindKthLargest(input.nums, input.k);

            Assert.AreEqual(expected, actual);
        }
    }
}
