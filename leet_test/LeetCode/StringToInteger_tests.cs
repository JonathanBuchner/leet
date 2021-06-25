﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.StringToInteger;

namespace leet_test.LeetCode
{
    [TestClass]
    public class StringToInteger_tests
    {
        [TestMethod]
        public void Example1_can_convert_string_to_integer()
        {
            var input = "42";
            var expected = 42;
            var sut = new Solution();

            var result = sut.MyAtoi(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example2_can_convert_string_to_negative_integer_with_spaces()
        {
            var input = "   -42";
            var expected = -42;
            var sut = new Solution();

            var result = sut.MyAtoi(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example3_can_convert_string_to_integer_when_it_starts_with_numbers()
        {
            var input = "4193 with words";
            var expected = 4193;
            var sut = new Solution();

            var result = sut.MyAtoi(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example3_when_converting_string_to_integer_that_starts_with_words_output_is_zero()
        {
            var input = "words and 987";
            var expected = 0;
            var sut = new Solution();

            var result = sut.MyAtoi(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example3_when_converting_string_to_integer_amount_is_capped_at_Int32()
        {
            var input = "-91283472332";
            var expected = -2147483648;
            var sut = new Solution();

            var result = sut.MyAtoi(input);

            Assert.AreEqual(expected, result);
        }
    }
}
