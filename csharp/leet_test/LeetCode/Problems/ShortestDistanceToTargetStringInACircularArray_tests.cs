using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using leet.LeetCode.Problems.ShortestDistanceToTargetStringInACircularArray;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ShortestDistanceToTargetStringInACircularArray_tests
    {
        private static IEnumerable<(string[] words, string target, int startIndex, int expected)> cases_basic()
        {
            yield return (
                ["hello", "i", "am", "leetcode", "hello"],
                "hello",
                1,
                1
                );

            yield return (
                ["a", "b", "leetcode"],
                "leetcode",
                0,
                1
                );


            yield return (
                 ["i", "eat", "leetcode"],
                 "ate",
                 0,
                 -1
                 );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases_basic), DynamicDataSourceType.Method)]
        public void ShortestDistanceToTargetStringInACircularArray_basic_tests(string[] words, string target, int startIndex, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.ClosestTarget(words, target, startIndex); 

            Assert.AreEqual(expected, actual);
        }
    }
}

