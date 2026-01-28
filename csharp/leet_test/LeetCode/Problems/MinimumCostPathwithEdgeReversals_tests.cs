using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumCostPathwithEdgeReversals;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumCostPathwithEdgeReversals_tests
    {
        public static IEnumerable<object[]> Cases()
        {
            // Case 1
            yield return new object[] {
                ( 4,
                new int[][] {
                    new int[] { 0, 1, 3 },
                    new int[] { 3, 1, 1 },
                    new int[] { 2, 3, 4 },
                    new int[] { 0, 2, 2 },
                }),
                5
            };

            // Case 2
            yield return new object[] {
                (4,
                new int[][] {
                    new int[] { 0, 2, 1 },
                    new int[] { 2, 1, 1 },
                    new int[] { 1, 3, 1 },
                    new int[] { 2, 3, 3 },
                }),
                3
            };

            // Case 113
            yield return new object[] {
                (4,
                new int[][] {
                    new int[] { 2,3,25 },
                    new int[] { 2,1,18 },
                    new int[] { 3,1,2 },
                }),
                -1
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void MinimumPairRemoval_tests_basic((int n, int[][] edges) input, int expected)
        {
            var sut = new Solution();

            var actual = sut.MinCost(input.n, input.edges);

            Assert.AreEqual(expected, actual);
        }
    }
}
