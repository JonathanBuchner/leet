using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumAbsDifference
{
    /// <summary>
    /// Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements. Return a list of pairs in ascending order(with respect to pairs), each pair[a, b] follows
    /// - a, b are from arr
    /// - a<b
    /// - b - a equals to the minimum absolute difference of any two elements in arr
    /// 
    /// https://leetcode.com/problems/minimum-absolute-difference/description/?envType=daily-question&envId=2026-01-26
    /// </summary>
    public class Solution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException($"Arr must have length greater than 1. Array length: {arr.Length}.");
            }

            var result = new List<IList<int>>();

            Array.Sort(arr);
            var min_diff = arr[1] - arr[0];
            result.Add(new List<int>() { arr[0], arr[1] });

            for (var i = 1; i + 1 < arr.Length; i++)
            {
                if (arr[i + 1] - arr[i] < min_diff)
                {
                    min_diff = arr[i + 1] - arr[i];
                    result = new List<IList<int>>();
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
                else if (arr[i + 1] - arr[i] == min_diff)
                {
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
                else
                {
                    // Do nothing
                }
            }

            return result;
        }
    }
}
