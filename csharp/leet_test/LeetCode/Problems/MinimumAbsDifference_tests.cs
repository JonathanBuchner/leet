using leet.LeetCode.Problems.MinimumAbsDifference;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumAbsDifference_tests
    {
        public static IEnumerable<object[]> Cases()
        {
            // Case 1
            yield return new object[] { 
                    new int[] { 4,2,1,3 }, 
                    new List<IList<int>>() {
                        new List<int>() { 1, 2 },
                        new List<int>() { 2, 3 },
                        new List<int>() { 3, 4 },
                    } 
                };

            // Case 2
            yield return new object[] {
                    new int[] { 1,3,6,10,15 },
                    new List<IList<int>>() {
                        new List<int>() { 1, 3 },
                    }
                };

            // Case 3
            yield return new object[] {
                    new int[] { 3, 8, -10, 23, 19, -4, -14, 27 },
                    new List<IList<int>>() {
                        new List<int>() { -14,-10 },
                        new List<int>() { 19,23 },
                        new List<int>() { 23, 27 }
                    }
                };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void MinimumPairRemoval_tests_basic(int[] input, IList<IList<int>> expected)
        {
            var sut = new Solution();

            var actual = sut.MinimumAbsDifference(input);

            AssertTwoDementionalLists<int>.AreMatch(expected, actual);
        }
    }
}
