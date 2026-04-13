using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.PourWater;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class PourWater_tests
    {
        private static IEnumerable<(int[] heights, int volume, int k, int[] expected)> cases()
        {
            yield return (
                    [2, 1, 1, 2, 1, 2, 2],
                    4,
                    3,
                    [2, 2, 2, 3, 2, 2, 2]
                );

            yield return (
                    [1, 2, 3, 4],
                    2,
                    2,
                    [2, 3, 3, 4]
                );

            yield return (
                    [3, 1, 3],
                    5,
                    1,
                    [4, 4, 4]
                );

            yield return (
                    [1, 2, 3, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1],
                    5,
                    5,
                    [1, 2, 3, 4, 3, 4, 3, 3, 3, 4, 3, 2, 1]
                );

            yield return (
                    [1, 2, 3, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1],
                    2,
                    2,
                    [2, 3, 3, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1]
                );

            yield return (
                    [1, 2, 3, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1],
                    10,
                    2,
                    [4, 4, 4, 4, 3, 3, 3, 3, 3, 4, 3, 2, 1]
                );

            yield return (
                    [1, 2, 3, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1],
                    5,
                    2,
                    [3, 4, 4, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1]
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void PourWater_basic_tests(int[] heights, int volume, int k, int[] expected)
        {
            var SUT = new Solution();

            var actual = SUT.PourWater(heights, volume, k);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
