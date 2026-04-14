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
        private static IEnumerable<(IList<int> robot, int[][] factory, int expected)> cases()
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
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void MinimumTotalDistanceTraveled_basic_tests(IList<int> robot, int[][] factory, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.MinimumTotalDistance(robot, factory);

            Assert.AreEqual(expected, actual);
        }
    }
}
