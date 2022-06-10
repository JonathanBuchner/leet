using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.AddBinary;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class AddBinary_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_a = "11";
            var input_b = "1";
            var expected = "100";

            var actual = sut.AddBinary(input_a, input_b);

            Assert.AreEqual(expected, actual);
        }

    }
}
