using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.FurthestPointFromOrigin;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class FurthestPointFromOrigin_tests
    {
        private static IEnumerable<(string moves, int expected)> basic_cases()
        {
            yield return ("L_RL__R", 3);
            yield return ("_R__LL_", 5);
            yield return ("_______", 7);
        }

        [DataTestMethod]
        [DynamicData(nameof(basic_cases), DynamicDataSourceType.Method)]
        public void FurthestPointFromOrigin_basic_tests(string moves, int expected)
        {
            var SUT = new Solution();
            var actual = SUT.FurthestDistanceFromOrigin(moves);
            Assert.AreEqual(expected, actual);
        }
    }
}
