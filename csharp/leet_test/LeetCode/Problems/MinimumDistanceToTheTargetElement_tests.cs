using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumDistanceToTheTargetElement;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumDistanceToTheTargetElement_tests
    {
        private static IEnumerable<(int[] nums, int target, int start, int expected)> cases()
        {
            yield return (
                    [1, 2, 3, 4, 5],
                    5,
                    3,
                    1
                );

            yield return (
                    [1],
                    1,
                    0,
                    0
                );

            yield return (
                    [1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
                    1,
                    0,
                    0
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void MinimumDistanceToTheTargetElement_basic_tests(int[] nums, int target, int start, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.GetMinDistance(nums, target, start);

            Assert.AreEqual(expected, actual);
        }
    }
}
