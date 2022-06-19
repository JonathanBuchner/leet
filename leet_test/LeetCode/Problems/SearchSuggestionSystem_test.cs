using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Problems.SearchSuggestionSystem;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class SearchSuggestionSystem_test
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input_words = new string[]
            {
                "mobile","mouse","moneypot","monitor","mousepad"
            };
            var input_search = "mouse";
            var expected = new List<IList<string>>()
            {
                new List<string>() { "mobile", "moneypot", "monitor" },
                new List<string>() { "mobile", "moneypot", "monitor" },
                new List<string>() { "mouse","mousepad" },
                new List<string>() { "mouse","mousepad" },
                new List<string>() { "mouse","mousepad" },
            };

            var actual = sut.SuggestedProducts(input_words, input_search);

            AssertTwoDementionalLists.AreMatch(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input_words = new string[]
            {
                "bags","baggage","banner","box","cloths"
            };
            var input_search = "bags";
            var expected = new List<IList<string>>()
            {
                new List<string>() { "baggage","bags","banner" },
                new List<string>() { "baggage","bags","banner" },
                new List<string>() { "baggage","bags" },
            };

            var actual = sut.SuggestedProducts(input_words, input_search);

            AssertTwoDementionalLists.AreMatch(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var input_words = new string[]
            {
                "havana"
            };
            var input_search = "havana";
            var expected = new List<IList<string>>()
            {
                new List<string>() { "havana" },
                new List<string>() { "havana" },
                new List<string>() { "havana" },
                new List<string>() { "havana" },
                new List<string>() { "havana" },
                new List<string>() { "havana" },
            };

            var actual = sut.SuggestedProducts(input_words, input_search);

            AssertTwoDementionalLists.AreMatch(expected, actual);
        }
    }
}
