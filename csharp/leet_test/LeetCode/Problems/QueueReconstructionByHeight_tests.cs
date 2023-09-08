using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.QueueReconstructionByHeight;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class QueueReconstructionByHeight_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var input = new int[][]
            {
                //[7,0],[4,4],[7,1],[5,0],[6,1],[5,2]
                new int[] {7, 0 },
                new int[] {4, 4 },
                new int[] {7, 1 },
                new int[] {5, 0 },
                new int[] {6, 1 },
                new int[] {5, 2 },
            };
            // new int[] {5, 0 },
            // new int[] {7, 0 }
            // new int[] {6, 1 },
            // new int[] {7, 1 },
            // new int[] {5, 2 },
            // new int[] {4, 4 }
            var expected = new int[][]
            {
                new int[] {5, 0 },
                new int[] {7, 0 },
                new int[] {5, 2 },
                new int[] {6, 1 },
                new int[] {4, 4 },
                new int[] {7, 1 },
            };

            var actual = sut.ReconstructQueue(input);


            AssertTwoDemensionalArrays.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var input = new int[][]
            {
                //[[6,0],[5,0],[4,0],[3,2],[2,2],[1,4]]
                new int[] {6, 0 },
                new int[] {5, 0 },
                new int[] {4, 0 },
                new int[] {3, 2 },
                new int[] {2, 2 },
                new int[] {1, 4 },
            };
            var expected = new int[][]
            {
                new int[] {4, 0 },
                new int[] {5, 0 },
                new int[] {2, 2 },
                new int[] {3, 2 },
                new int[] {1, 4 },
                new int[] {6, 0 },
            };

            var actual = sut.ReconstructQueue(input);


            AssertTwoDemensionalArrays.AreEqual(expected, actual);
        }
    }
}
