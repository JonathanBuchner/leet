using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.ZigzagConversation;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ZigzagConversation
    {
        [TestMethod]
        public void Convert_CanConverWithThreeRows()
        {
            var sut = new Solution();
            var input_string = "PAYPALISHIRING";
            var input_rows = 3;
            var expected = "PAHNAPLSIIGYIR";

            var actual = sut.Convert(input_string, input_rows);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Convert_CanConverWithFourRows()
        {
            var sut = new Solution();
            var input_string = "PAYPALISHIRING";
            var input_rows = 4;
            var expected = "PINALSIGYAHRPI";

            var actual = sut.Convert(input_string, input_rows);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Convert_CanConverWithOneRow()
        {
            var sut = new Solution();
            var input_string = "PAYPALISHIRING";
            var input_rows = 1;
            var expected = "PAYPALISHIRING";

            var actual = sut.Convert(input_string, input_rows);

            Assert.AreEqual(expected, actual);
        }
    }
}
