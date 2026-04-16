using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ClosestEqualElementQueries
{
    public class Solution
    {
        public IList<int> SolveQueries(int[] nums, int[] queries)
        {
            var dict = new Dictionary<int, List<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], new List<int>());

                dict[nums[i]].Add(i);
            }

            for (var i = 0; i < queries.Length; i++)
            {
                var index = queries[i];
                var indexes = dict[nums[index]];

                queries[i] = GetShortest(index, indexes, nums.Length);
            }

            return queries;
        }

        private int GetShortest(int index, List<int> indexes, int numsLength)
        {
            var shortest = Int32.MaxValue;
            
            for (var i = 0; i < indexes.Count; i++)
            {
                if (index == indexes[i])
                    continue;

                var right = Math.Abs(index - indexes[i]);
                var left_long = Math.Abs(index + numsLength - indexes[i]);
                var left_short = Math.Abs(index - numsLength - indexes[i]);

            shortest = Math.Min(shortest, Math.Min(right, Math.Min(left_short, left_long)));
            }

            return shortest != Int32.MaxValue ? shortest : -1;
        }
    }
}
