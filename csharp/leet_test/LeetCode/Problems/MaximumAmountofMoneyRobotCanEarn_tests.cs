using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MaximumAmountofMoneyRobotCanEarn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MaximumAmountofMoneyRobotCanEarn_tests
    {
        private static IEnumerable<(int[][] coins, int expected)> cases()
        {
            yield return (
                new int[][] 
                {
                    [0,1,-1],[1,-2,3],[2,-3,4]
                },
                8
            );

            yield return (
                new int[][]
                {
                    [10,10,10],[10,10,10]
                },
                40
            );
        }


        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void MaximumAmountofMoneyRobotCanEarn_basic_tests(int[][] coins, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.MaximumAmount(coins);

            Assert.AreEqual(actual, expected);
        }
    }
}
