using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumDistanceToTypeAWordUsingTwoFingers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumDistanceToTypeAWordUsingTwoFingers
    {
        private static IEnumerable<(string word, int expected)> cases()
        {
            yield return (
                    "CAKE",
                    3
                );

            yield return (
                    "HAPPY",
                    6
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void MinimumDistanceToTypeAWordUsingTwoFingers_basic_tests(string word, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.MinimumDistance(word);

            Assert.AreEqual(expected, actual);
        }
    }
}
