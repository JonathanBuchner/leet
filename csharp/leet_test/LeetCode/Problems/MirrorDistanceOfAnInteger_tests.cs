using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MirrorDistanceOfAnInteger;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MirrorDistanceOfAnInteger_tests
    {
        private static IEnumerable<(int i, int expected)> basic_cases()
        {
            yield return (28, 27);
            yield return (10, 9);
            yield return (7, 0);
        }

        [DataTestMethod]
        [DynamicData(nameof(basic_cases), DynamicDataSourceType.Method)]
        public void MirrorDistanceOfAnInteger_basic_tests(int i, int expected)
        {
            var SUT = new Solution();
            var actual = SUT.MirrorDistance(i);
            Assert.AreEqual(expected, actual);
        }
    }
}
