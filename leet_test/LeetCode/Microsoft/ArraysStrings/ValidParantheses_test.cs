using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Microsoft.ArrayStrings.ValidParentheses;

namespace leet_test.Microsoft.ArrayStrings.LeetCode
{
    [TestClass]
    public class ValidParantheses_test
    {
        [TestMethod]
        public void Example1_one_left_and_one_right_parantheses_is_true()
        {
            var input = "()";
            var expected = true;
            var sut = new Solution();

            var result = sut.IsValid(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example2_one_left_and_one_right_of_all_brackets_is_true()
        {
            var input = "()[]{}";
            var expected = true;
            var sut = new Solution();

            var result = sut.IsValid(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example3_incorrect_closing_of_brackets_is_false()
        {
            var input = "(]";
            var expected = false;
            var sut = new Solution();

            var result = sut.IsValid(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example4_incorrect_order_of_scloing_brackets_is_false()
        {
            var input = "([)]";
            var expected = false;
            var sut = new Solution();

            var result = sut.IsValid(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example5_correct_order_Of_closing_brackets_is_true()
        {
            var input = "([{}])";
            var expected = true;
            var sut = new Solution();

            var result = sut.IsValid(input);

            Assert.AreEqual(expected, result);
        }
    }
}
