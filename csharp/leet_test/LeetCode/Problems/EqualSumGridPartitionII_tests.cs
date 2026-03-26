using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.EqualSumGridPartitionII;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class EqualSumGridPartitionII_tests
    {
        private static IEnumerable<object> cases()
        {
            yield return (
                new int[][]
                {
                    [1,4],[2,3]
                },
                true
            );


            yield return (
                new int[][]
                {
                    [1,2],[3,4]
                },
                false
            );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void EqualSumGridPartitionII_basic_tests(int[][] input, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.CanPartitionGrid(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
