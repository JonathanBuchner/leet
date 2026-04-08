using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace leet.LeetCode.Problems.XORAfterRangeMultiplicationQueriesI
{
    public class Solution
    {

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int XorAfterQueries(int[] nums, int[][] queries)
        {
            var MOD = 1_000_000_007;
            for (var i = 0; i < queries.Length; i++)
            {
                var idx = queries[i][0];
                while (idx <= queries[i][1])
                {
                    nums[idx] = (int) (((long) nums[idx] * queries[i][3]) % MOD);
                    idx += queries[i][2];
                }
            }

            var num = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                num ^= nums[i];
            }

            return num;
        }
    }
}
