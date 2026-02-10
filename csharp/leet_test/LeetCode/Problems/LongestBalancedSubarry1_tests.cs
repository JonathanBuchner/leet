using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.LongestBalancedSubarray;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class LongestBalancedSubarry1_tests
    {
        private static IEnumerable<(int[] input, int expected)> cases()
        {
            yield return (
                    new int[] {2, 5, 4, 3},
                    4
                );

            yield return (
                    new int[] { 3, 2, 2, 5, 4 },
                    5
                );

            yield return (
                    new int[] { 1, 2, 3, 2 },
                    3
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void LongestBalancedSubarry1_test123(int[] input, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.LongestBalanced(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
