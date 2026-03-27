using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MatrixSimilarityAfterCyclicShifts
{
    public class Solution
    {
        public bool AreSimilar(int[][] mat, int k)
        {
            // Shortcut for cycle such that before and and after index is same after all cycles.
            k %= mat[0].Length;
            if (mat.Length == 0)
                return true;
            

            // Cycle copy
            for (var i = 0; i < mat.Length; i++)
            {
                if (!Cycles(mat[i], k))
                    return false;
            }

            return true;
        }

        private bool Cycles(int[] matRow, int k)
        {
            for (var i = 0; i < matRow.Length; i++)
            {
                if (matRow[i] != matRow[(i + k) % matRow.Length])
                    return false;
            }

            return true;
        }
    }
}
