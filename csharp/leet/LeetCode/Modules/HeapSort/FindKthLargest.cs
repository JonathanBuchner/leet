using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.HeapSort.FindKthLargest
{
    /// <summary>
    /// Not solved through hep sort.
    /// </summary>
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            return FindKthSmallest(nums, nums.Length - k + 1);
        }

        public int FindKthSmallest(int[] nums, int k)
        {
            var random_element = nums[new Random().Next(nums.Length)];
            var list_less = new List<int>();
            var list_more = new List<int>();
            var list_equal = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < random_element)
                {
                    list_less.Add(nums[i]);
                }
                else if (nums[i] > random_element)
                {
                    list_more.Add(nums[i]);
                }
                else
                {
                    list_equal.Add(nums[i]);
                }
            }

            if (list_less.Count >= k)
            {
                return FindKthSmallest(list_less.ToArray(), k);
            }
            else if (list_less.Count + list_equal.Count < k)
            {
                return FindKthSmallest(list_more.ToArray(), k - (list_less.Count + list_equal.Count));
            }
            else
            {
                return list_equal[0];
            }
        }
    }
}
