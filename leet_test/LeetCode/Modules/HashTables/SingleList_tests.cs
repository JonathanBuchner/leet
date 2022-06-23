using leet.LeetCode.Modules.HashTables.SingleNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class SingleList_tests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 2, 7, 6, 4, 5, 3 }, 1)]
        [DataRow(new int[] { 2, 2, 1}, 1 )]
        [DataRow(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [DataRow(new int[] { 1 }, 1)]
        [DataRow(new int[] { Int32.MaxValue, Int32.MaxValue, Int32.MinValue, }, Int32.MinValue)]
        [DataRow(new int[] { Int32.MaxValue, Int32.MinValue, Int32.MaxValue }, Int32.MinValue)]
        public void SingleNumber_SimpleSolution_ReturnsSingleNumber(int[] input_nums, int expected)
        {
            var sut = new Solution();

            var actual = sut.SingleNumber(input_nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
