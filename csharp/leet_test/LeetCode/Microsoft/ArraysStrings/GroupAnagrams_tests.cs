using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Microsoft.ArrayStrings.GroupAnagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections;
using leet_test.Helpers;

namespace leet_test.LeetCode.Microsoft.ArraysStrings
{
    [TestClass]
    public class GroupAnagrams_tests
    {
        [TestMethod]
        public void Example1_Can_group_anagrams()
        {
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new List<IList<string>>()
           {
                new List<string>(){ "bat" },
                new List<string>(){ "nat", "tan" },
                new List<string>(){ "ate", "eat", "tea"}
            };
            var sut = new Solution();

            var actual = sut.GroupAnagrams(input);

            AssertTwoDementionalLists<string>.AreMatch(expected, actual);
        }

        [TestMethod]
        public void Example2_Empty_string_returns_empty_list_nested_in_list()
        {
            var input = new string[] { "" };
            var expected = new List<IList<string>>()
           {
                new List<string>(){ "" }
            };
            var sut = new Solution();

            var actual = sut.GroupAnagrams(input);

            AssertTwoDementionalLists<string>.AreMatch(expected, actual);
        }

        [TestMethod]
        public void Example3_Can_solve_if_only_one_letter_in_array()
        {
            var input = new string[] { "a" };
            var expected = new List<IList<string>>()
            {
                new List<string>(){ "a" }
            };
            var sut = new Solution();

            var actual = sut.GroupAnagrams(input);

            AssertTwoDementionalLists<string>.AreMatch(expected, actual);
        }
    }
}
