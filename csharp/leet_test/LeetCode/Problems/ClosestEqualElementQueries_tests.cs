using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.ClosestEqualElementQueries;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ClosestEqualElementQueries_tests
    {
        private static IEnumerable<(int[] nums, int[] queries, int[] expected)> cases()
        {
            yield return (
                [1, 3, 1, 4, 1, 3, 2],
                [0, 3, 5],
                [2, -1, 3]
                );

            yield return (
               [1, 2, 3, 4],
               [0, 1, 2, 3],
               [-1, -1, -1, -1]
               );

            yield return (
              [6, 12, 17, 9, 16, 7, 6],
              [5, 6, 0, 4],
              [-1, 1, 1, -1]
              );
        }


        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void ClosestEqualElementQueries_basic_tests(int[] nums, int[] queries, int[] expected)
        {
            var SUT = new Solution();

            var actual = SUT.SolveQueries(nums, queries);

            Assert.AreEqual(expected.Length, actual.Count);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        private static IEnumerable<(int[] nums, int[] queries, int[] expected)> practice_cases()
        {
            yield return (
              [6, 12, 17, 9, 16, 7, 6],
              [6, 0],
              [1, 1]
              );
        }

        [DataTestMethod]
        [DynamicData(nameof(practice_cases), DynamicDataSourceType.Method)]
        public void ClosestEqualElementQueries_practice_tests(int[] nums, int[] queries, int[] expected)
        {
            var SUT = new Solution();

            var actual = SUT.SolveQueries(nums, queries);

            Assert.AreEqual(expected.Length, actual.Count);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
