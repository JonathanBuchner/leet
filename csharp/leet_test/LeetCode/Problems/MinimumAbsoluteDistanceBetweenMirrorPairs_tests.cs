using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumAbsoluteDistanceBetweenMirrorPairs;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumAbsoluteDistanceBetweenMirrorPairs_tests
    {
        private static IEnumerable<(int[] nums, int expected)> basic_cases()
        {
            yield return
                (
                    [12, 21, 45, 33, 54],
                    1
                );

            yield return
               (
                   [120, 21],
                   1
               );

            yield return
               (
                   [21, 120],
                   -1
               );
        }

        [DataTestMethod]
        [DynamicData(nameof(basic_cases), DynamicDataSourceType.Method)]
        public void MinimumAbsoluteDistanceBetweenMirrorPairs_basic_tests(int[] nums, int expected)
        {
            var SUT = new Solution();
            var actual = SUT.MinMirrorPairDistance(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
