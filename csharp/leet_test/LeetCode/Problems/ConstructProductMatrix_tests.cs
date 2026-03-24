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
