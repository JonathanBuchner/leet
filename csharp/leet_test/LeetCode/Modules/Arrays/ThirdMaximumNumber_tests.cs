using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.Arrays.ThirdMaximumNumber;

namespace leet_test.LeetCode.Modules.Arrays
{
    [TestClass]
    public class ThirdMaximumNumber_tests
    {
        [TestMethod]
        [DataRow(new int[] { 3, 2, 1}, 1 )]
        [DataRow(new int[] { 2, 1 }, 2)]
        [DataRow(new int[] { 1 }, 1)]
        [DataRow(new int[] { 1, 2, 3, 4}, 2)]
        [DataRow(new int[] { Int32.MaxValue, 0, -1, Int32.MinValue }, -1)]
        [DataRow(new int[] { 0, 1, 1, 1, 1, 1 ,1 }, 1)]
        [DataRow(new int[] { 0, 2, 3, 4, 5, 6, 7 }, 5)]
        [DataRow(new int[] { 7, 6, 5, 4, 3, 2, 1 }, 5)]

        public void Examplel1_Basic(int[] input, int expected)
        {
            var sut = new Solution();

            var actual = sut.ThirdMax(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
