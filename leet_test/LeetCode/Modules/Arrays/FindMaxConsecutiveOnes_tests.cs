using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Arrays.MaxConsecutiveOnesII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Modules.Arrays
{
    [TestClass]
    public class FindMaxConsecutiveOnes_tests
    {
        [TestMethod]
        public void Exmaple1_Simple_Flipping_Only_One_Zero()
        {
            var sut = new Solution();
            var input = new int[] { 1, 0, 1, 1, 0 };
            var expected = 4;

            var actual = sut.FindMaxConsecutiveOnes(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exmaple2_Simple_Flipping_Only_One_Zero()
        {
            var sut = new Solution();
            var input = new int[] { 1, 0, 1, 1, 0 };
            var expected = 4;

            var actual = sut.FindMaxConsecutiveOnes(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { }, 0)]
        [DataRow(new int[] { 0 }, 1)]
        [DataRow(new int[] { 0, 0, 0, }, 1)]
        [DataRow(new int[] { 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1 }, 6)]
        [DataRow(new int[] { 1, 0,  0, 0,}, 2)]
        public void Tests_Simple_Flipping_Only_One_Zero(int[] input, int expected)
        {
            var sut = new Solution();

            var actual = sut.FindMaxConsecutiveOnes(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
