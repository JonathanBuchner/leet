using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.RegularExpressionMatching;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class RegularExpressionMatching_tests
    {
        private static IEnumerable<(string s, string p, bool expected)> cases_basic()
        {
            yield return (
                "aa",
                "pp",
                false
            );

            yield return (
               "aa",
               "aa",
               true
               );

            yield return (
              "a",
              "aa",
              false
            );

            yield return (
              "aaa",
              "a",
              false
            );

        }

        private static IEnumerable<(string s, string p, bool expected)> cases_dots()
        {
            yield return (
                "ap",
                "a.",
                true
            );

            yield return (
               "ap",
               "..",
               true
            );

            yield return (
               "ap",
               ".b",
               false
            );
        }

        private static IEnumerable<(string s, string p, bool expected)> cases_star()
        {

            yield return (
                "aa",
                "a*",
                true
                );

            yield return (
               "aab",
               "c*a*b",
               true
               );

            yield return (
              "aaa",
              "a*a",
              true
              );

            yield return (
              "aaaaaaaaa",
              "a*a*a*a*a*a",
              true
              );

            yield return (
              "a",
              "a*a*a*a*a*a",
              true
              );

            yield return (
              "c",
              "a*a*a*ca*a*a*",
              true
              );

            yield return (
              "b",
              "a*b",
              true
             );

            yield return (
             "abcd",
             "d*",
             false
             );

            yield return (
             "aaa",
             "*a*c*a",
             false
             );

            yield return (
             "aaa",
             "ab*a*c*a",
             true
             );
        }
        private static IEnumerable<(string s, string p, bool expected)> cases_dots_and_star()
        {
            yield return (
               "ab",
               ".*c",
               false
               );

            yield return (
               "ab",
               ".*",
               true
               );

            yield return (
               "abcbbbbabbbcabbb",
               ".*ca.*",
               true
               );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases_basic), DynamicDataSourceType.Method)]
        public void RegularExpressionMatching_basic_tests(string s, string p, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.IsMatch(s, p);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DynamicData(nameof(cases_dots), DynamicDataSourceType.Method)]
        public void RegularExpressionMatching_dots_tests(string s, string p, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.IsMatch(s, p);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DynamicData(nameof(cases_star), DynamicDataSourceType.Method)]
        public void RegularExpressionMatching_star_tests(string s, string p, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.IsMatch(s, p);

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DynamicData(nameof(cases_dots_and_star), DynamicDataSourceType.Method)]
        public void RegularExpressionMatching_dots_and_star_tests(string s, string p, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.IsMatch(s, p);

            Assert.AreEqual(expected, actual);
        }

    }
}
