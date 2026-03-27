using System;
using System.Collections.Generic;
using System.Data;
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
            
            for (var n = 0; n < mat.Length; n++)
            {
                for (var m = 0; m < mat[n].Length; m++)
                {
                    if (mat[n][m] != mat[n][(m + k) % mat[n].Length])
                        return false;
                }
            }

            return true;
        }
    }
}
