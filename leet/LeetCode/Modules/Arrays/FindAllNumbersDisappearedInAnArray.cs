using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Arrays.FindAllNumbersDisappearedInAnArray
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var test = new bool[nums.Length + 1];
            var list = new List<int>();

            for(var i = 0; i < nums.Length; i++)
            {
                test[nums[i]] = true;
            }

            for (var i = 1; i < test.Length; i++)
            {
                if (test[i] == false)
                {
                    list.Add(i);
                }
            }

            return list;

        }
    }
}
