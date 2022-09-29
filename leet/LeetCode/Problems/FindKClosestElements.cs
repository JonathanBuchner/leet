using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FindKClosestElements
{
    /*
     * Find K Closests Elements
     * 
     * Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array. The result should also be sorted in ascending order.
     * 
     * https://leetcode.com/problems/find-k-closest-elements/
     */
    public class Solution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var prev = 0;
            var next = 0;
            var result = new int[k];

            var i = 0;
            while (i < arr.Length && arr[i] < x)
            {
                i++;
            }
            prev = i - 1;
            next = i;

            while (prev >= 0 && next < arr.Length && k > 0)
            {
                if (arr[next] - x < x - arr[prev])
                {
                    next++;
                }
                else
                {
                    prev--;
                }
                k--;
            }

            while (prev >= 0 && k > 0)
            {
                prev--;
                k--;
            }

            while (next < arr.Length && k > 0)
            {
                next++;
                k--;
            }

            prev++;

            Array.Copy(arr, prev, result, 0, result.Length);

            return result;
        }
    }
}
