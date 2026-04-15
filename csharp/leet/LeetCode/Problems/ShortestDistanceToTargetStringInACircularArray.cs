using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ShortestDistanceToTargetStringInACircularArray
{
    /**
     * Shortest Distance to Target String in a Circular Array
     * 
     * https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array/
     */
    public class Solution
    {
        public int ClosestTarget(string[] words, string target, int startIndex)
        {
            var result = -1;

            var left_index = startIndex + words.Length;
            var right_index = startIndex;
            
            while (left_index + 1 > right_index)
            {
                if (words[left_index % words.Length] == target || words[right_index % words.Length] == target)
                    return right_index - startIndex;

                left_index--;
                right_index++;
            }

            return result;
        }
    }
}
