using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.PartitionEqualSubsetSum;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PartitionEqualSubsetSum_tests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 5, 11, 5 }, true)]
        [DataRow(new int[] { 1, 2, 3, 5 }, false)]

        public void CanPartition_Examples(int[] nums, bool expected)
        {
            var sut = new Solution();

            var actual = sut.CanPartition(nums);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 99, 97} , true)]
        public void CanPartition_Tests(int[] nums, bool expected)
        {
            var sut = new Solution();

            var actual = sut.CanPartition(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
