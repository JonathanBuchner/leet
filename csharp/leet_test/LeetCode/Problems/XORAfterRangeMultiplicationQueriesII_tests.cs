using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.XORAfterRangeMultiplicationQueriesII;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class XORAfterRangeMultiplicationQueriesII_tests
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

            yield return (
                   new int[] { 780 },
                   new int[][]
                   {
                        [0,0,1,13],[0,0,1,17],[0,0,1,9],[0,0,1,18],[0,0,1,16],[0,0,1,6],[0,0,1,4],[0,0,1,11],[0,0,1,7],[0,0,1,18],[0,0,1,8],[0,0,1,15],[0,0,1,12]
                   },
                   523618060
               );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void XORAfterRangeMultiplicationQueriesII_basic_tests(int[] nums, int[][] queries, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.XorAfterQueries(nums, queries);

            Assert.AreEqual(expected, actual);
        }
    }
}
