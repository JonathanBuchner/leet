﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Microsoft.LongestHappyString;

namespace leet_test.LeetCode.Microsoft
{
    [TestClass]
    public class LongestHappyString
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_a = 1;
            var input_b = 1;
            var input_c = 7;
            var expected = "ccccbcc";

            var actual = sut.LongestDiverseString(input_a, input_b, input_c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_a = 7;
            var input_b = 1;
            var input_c = 0;
            var expected = "aabaa";

            var actual = sut.LongestDiverseString(input_a, input_b, input_c);

            Assert.AreEqual(expected, actual);
        }
    }
}
