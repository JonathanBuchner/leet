using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.TwoFurthestHousesWithDifferentColors;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class TwoFurthestHousesWithDifferentColors_tests
    {
        private static IEnumerable<(int[] colors, int expected)> basic_cases()
        {
            yield return ([1, 1, 1, 6, 1, 1, 1], 3);
            yield return ([1, 8, 3, 8, 3], 4);
            yield return ([0, 1], 1);
        }

        [DataTestMethod]
        [DynamicData(nameof(basic_cases), DynamicDataSourceType.Method)]
        public void TwoFurthestHousesWithDifferentColors_tests_basic_tests(int[] colors, int expected)
        {
            var SUT = new Solution();
            var actual = SUT.MaxDistance(colors);
            Assert.AreEqual(expected, actual);
        }
    }
}
