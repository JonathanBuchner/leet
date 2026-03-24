using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leet.LeetCode.Problems.ConstructProductMatrix;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ConstructProductMatrix_tests
    {
        private static IEnumerable<object> cases()
        {
            yield return (
                new int[][]
                {
                    [1,2],[3,4]
                },
                new int[][]
                {
                    [24,12],[8,6]
                }
            );

            yield return (
                new int[][]
                {
                    [12345],[2],[1]
                },
                new int[][]
                {
                   [2],[0],[0]
                }
            );

            yield return (
                new int[][]
                {
                   [3,2,5],[6,4,3],[6,3,1]
                },
                new int[][]
                {
                   [615,7095,7776],[6480,9720,615],[6480,615,1845]
                }
            );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void ConstructProductMatrix_basic_tests(int[][] input, int[][] expected)
        {
            var SUT = new Solution();

            var actual = SUT.ConstructProductMatrix(input);

            AssertTwoDemensionalArrays.AreEqual(expected, actual);
        }
    }
}
