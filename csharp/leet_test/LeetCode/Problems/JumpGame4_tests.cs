
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.JumpGame4;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class JumpGame4_tests
    {
        private static IEnumerable<(int[] arr, int expected)> basic_cases()
        {
            yield return (
                    [100, -23, -23, 404, 100, 23, 23, 23, 3, 404],
                    3
                );

            yield return (
                   [7],
                   0
               );

            yield return (
                   [7, 6, 9, 6, 9, 6, 9, 7],
                   1
               );
        }

        [DataTestMethod]
        [DynamicData(nameof(basic_cases), DynamicDataSourceType.Method)]
        public void JumpGame4_basic_tests(int[] arr, int expected)
        {
            var SUT = new Solution();
            var actual = SUT.MinJumps(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}
