using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.XORAfterRangeMultiplicationQueriesI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class XORAfterRangeMultiplicationQueriesI_tests
    {
        private static IEnumerable<(int[] nums, int[][] queries, int expected)> cases()
        {
            yield return (
                    new int[] 
                    {
                        2,3,1,5,4
                    },
                    new int[][]
                    {
                        [1,4,2,3],[0,2,1,2]
                    },
                    31
                );

            yield return (
                    new int[] { 1, 1, 1 },
                    new int[][]
                    {
                        [0,2,1,4]
                    },
                    4
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void XORAfterRangeMultiplicationQueriesI_basic_tests(int[] nums, int[][] queries, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.XorAfterQueries(nums, queries);

            Assert.AreEqual(expected, actual);
        }
    }
}
