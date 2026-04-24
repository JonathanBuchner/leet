using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.MinimumTotalDistanceTraveled;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumTotalDistanceTraveled_tests
    {
        private static IEnumerable<(IList<int> robot, int[][] factory, long expected)> cases_basic()
        {
            yield return (
                [0, 4, 6],
                [[2, 2], [6, 2]],
                4
                );

            yield return (
                [1, -1],
                [[-2, 1], [2, 1]],
               2
               );


            yield return (
               [9, 11, 99, 101],
               [[10, 1], [7, 1], [14, 1], [100, 1], [96, 1], [103, 1]],
               6
               );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases_basic), DynamicDataSourceType.Method)]
        public void MinimumTotalDistanceTraveled_basic_tests(IList<int> robot, int[][] factory, long expected)
        {
            var SUT = new Solution();

            var actual = SUT.MinimumTotalDistance(robot, factory);

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<(IList<int> robot, int[][] factory, long expected)> cases_long()
        {
            yield return (
               [-333539942, 359275673, 89966494, 949684497, -733065249, 241002388, 325009248, 403868412, -390719486, -670541382, 563735045, 119743141, 323190444, 534058139, -684109467, 425503766, 761908175],
               [[-590277115, 0], [-80676932, 3], [396659814, 0], [480747884, 9], [118956496, 10]],
              4412966458
              );
        }

            [DataTestMethod]
        [DynamicData(nameof(cases_long), DynamicDataSourceType.Method)]
        public void MinimumTotalDistanceTraveled_longs_tests(IList<int> robot, int[][] factory, long expected)
        {
            var SUT = new Solution();

            var actual = SUT.MinimumTotalDistance(robot, factory);

            Assert.AreEqual(expected, actual);
        }
    }
}
