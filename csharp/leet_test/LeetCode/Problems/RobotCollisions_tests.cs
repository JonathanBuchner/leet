using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.RobotCollisions;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class RobotCollisions_tests
    {
        private static IEnumerable<((int[] positions, int[] healths, string directions), List<int> expected)> cases()
        {
            yield return (
                (
                    new int[] { 5, 4, 3, 2, 1 }, 
                    new int[] { 2, 17, 9, 15, 10 },
                    "RRRRR"
                ),
                new List<int>() { 2, 17, 9, 15, 10 }     
            );

            yield return (
                (
                    new int[] { 3, 5, 2, 6 },
                    new int[] { 10, 10, 15, 12 },
                    "RLRL"
                ),
                new List<int>() { 14 }
            );

            yield return (
                (
                    new int[] { 1, 2, 5, 6 },
                    new int[] { 10, 10, 11, 11 },
                    "RLRL"
                ),
                new List<int>() { }
            );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void RobotCollisions_basic_tests((int[] positions, int[] healths, string directions) input, List<int> expected)
        {
            var SUT = new Solution();

            var actual = SUT.SurvivedRobotsHealths(input.positions, input.healths, input.directions);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
