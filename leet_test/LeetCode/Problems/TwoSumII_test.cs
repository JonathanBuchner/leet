using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.TwoSumII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class TwoSumII_test
    {
        [TestMethod]
        public void TestCase3()
        {
            var sut = new Solution();
            var input_numbers = new int[] { 0, 0, 3, 4 };
            var input_target = 0;
            var expected = new int[] { 1, 2 };

            var actual = sut.TwoSum(input_numbers, input_target);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
