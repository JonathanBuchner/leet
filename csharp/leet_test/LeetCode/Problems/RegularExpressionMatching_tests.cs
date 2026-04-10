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
        private static IEnumerable<(string s, string p, bool expected)> cases()
        {
            yield return (
                "aa",
                "pp",
                false
                );

            yield return (
                "aa",
                "a*",
                true
                );

            yield return (
                "ab",
                ".*",
                true
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void RegularExpressionMatching_basic_tests(string s, string p, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.IsMatch(s, p);

            Assert.AreEqual(expected, actual);
        }

    }
}
