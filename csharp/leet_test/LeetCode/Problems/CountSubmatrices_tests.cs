using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.CountSubmatrices;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class CountSubmatrices_tests
    {
        private static IEnumerable<(int[][] grid, int num, int expected)> cases()
        {
            yield return (
                 
                new int[][]
                {
                    [ 7, 6, 3],
                    [ 6, 6, 1]
                },
                18,
                4
            );

            yield return (

               new int[][]
               {
                    [7,2,9],
                    [1,5,0],
                    [2,6,6]
               },
               20,
               6
            );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void CountSubmatrices_simple_tests(int[][] grid, int num, int expected)
        {
            var SUT = new Solution();

            var actual = SUT.CountSubmatrices(grid, num);

            Assert.AreEqual(expected, actual);
        }
    }
}
