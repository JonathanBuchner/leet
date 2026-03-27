using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MatrixSimilarityAfterCyclicShifts;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MatrixSimilarityAfterCyclicShifts_tests
    {
        private static IEnumerable<((int[][] mat, int k) input, bool expected)> cases()
        {
            yield return (
                (
                    new int[][]
                    {
                        [1,2,3],[4,5,6],[7,8,9]
                    },
                    4
                ),
                false
            );

            yield return (
                (
                    new int[][]
                    {
                        [1,2,1,2],[5,5,5,5],[6,3,6,3]
                    },
                    2
                ),
               true
            );

            yield return (
               (
                   new int[][]
                   {
                       [2,2],[2,2]
                   },
                   3
               ),
               true
           );

            yield return (
              (
                  new int[][]
                  {
                       [1,2]
                  },
                  1
              ),
              false
          );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void MatrixSimilarityAfterCyclicShifts_basic_tests((int[][] mat, int k) input, bool expected)
        {
            var SUT = new Solution();

            var actual = SUT.AreSimilar(input.mat, input.k);

            Assert.AreEqual(expected, actual);
        }
    }
}
