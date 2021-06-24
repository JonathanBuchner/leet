using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.ReverseWordsInaString;

namespace leet_test.LeetCode
{
    [TestClass]
    public class ReverseWordsInaString_tests
    {
        [TestMethod]
        public void Example1_can_reverse_words()
        {
            var input = "the sky is blue";
            var expected = "blue is sky the";
            var sut = new Solution();

            var result = sut.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example2_reversed_string_should_not_contain_leading_or_trailing_spaces()
        {
            var input = "  hello world  ";
            var expected = "world hello";
            var sut = new Solution();

            var result = sut.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example2_multiple_spaces_between_two_words_to_a_single_space()
        {
            var input = "a good   example";
            var expected = "example good a";

            var sut = new Solution();

            var result = sut.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example4_all_spaces_correctly_removed()
        {
            var input = "  Bob    Loves  Alice   ";
            var expected = "Alice Loves Bob";

            var sut = new Solution();

            var result = sut.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Example5_nan_reverse_many_words()
        {
            var input = "Alice does not even like bob";
            var expected = "bob like even not does Alice";
            var sut = new Solution();

            var result = sut.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }
    }
}
