using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.CountOfSmallerNumbersAfterSelf
{
    /*
     * Count of Smaller Numbers After Self
     * 
     * You are given an int array nums and you have to return a new counts array. The counts array has the property where counts[i] is the number of smaller elements to the right of nums[i].
     * 
     * https://leetcode.com/problems/count-of-smaller-numbers-after-self/
     * 
     * Copied this solution
     */
    public class Solution
    {
        public List<int> CountSmaller(int[] nums)
        {
            int offset = 10000; // offset negative to non-negative
            int size = 2 * 10000 + 2; // total possible values in nums plus one dummy
            int[] tree = new int[size];
            List<int> result = new List<int>();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int smaller_count = Query(nums[i] + offset, tree);
                result.Add(smaller_count);
                Update(nums[i] + offset, 1, tree, size);
            }

            result.Reverse();
            
            return result;
        }

        // implement Binary Index Tree
        private void Update(int index, int value, int[] tree, int size)
        {
            index++; // index in BIT is 1 more than the original index
            
            while (index < size)
            {
                tree[index] += value;
                index += index & -index;
            }
        }

        private int Query(int index, int[] tree)
        {
            // return sum of [0, index)
            int result = 0;
            
            while (index >= 1)
            {
                result += tree[index];
                index -= index & -index;
            }
            
            return result;
        }
    }
}
