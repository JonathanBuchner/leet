using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.MinimumDistanceBetweenThreeEqualElementsII;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumDistanceBetweenThreeEqualElementsII_tests
    {
        private static IEnumerable<(int[] nums, int expected)> cases()
        {
            yield return (
                    [1, 2, 1, 1, 3],
                    6
                );
            yield return (
                   [1, 1, 2, 3, 2, 1, 2],
                   8
               );

            yield return (
                   [1],
                   -1
               );
        }


        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void MinimumDistanceBetweenThreeEqualElementsI_basic_tests(int[] nums, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.MinimumDistance(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}
