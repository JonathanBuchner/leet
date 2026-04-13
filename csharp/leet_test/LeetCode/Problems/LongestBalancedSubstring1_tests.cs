using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.LongestBalancedSubstring1;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class LongestBalancedSubstring1_tests
    {
        private static IEnumerable<(string input, int expected)> get_test_data()
        {
            // Test Case 1: Example 1 is simple long string
            yield return (
                    "abbac",
                    4
                );

            // Test Case 2: Example 2 simple middle substring
            yield return (
                    "zzabccy",
                    4
                );

            // Test Case 3: Example 3 handle odd number
            yield return (
                    "aba",
                    2
                );

        }

        [DataTestMethod]
        [DynamicData(nameof(get_test_data), DynamicDataSourceType.Method)]
        public void LongestBalancedSubstring1_basic_tests(string input, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.LongestBalanced(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
