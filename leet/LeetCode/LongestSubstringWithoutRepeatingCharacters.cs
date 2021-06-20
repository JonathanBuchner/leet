using System;
using System.Collections.Generic;

/*
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/
 * 
 * Given a string s, find the length of the longest substring without repeating characters.
 */
namespace LeetCode.LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            var longest = 0;
            var front = 0;
            var back = 0;
            var seen = new HashSet<char>() { };

            while (front < s.Length)
            {
                if (seen.Contains(s[front]))
                {
                    seen.Remove(s[back]);
                    back++;
                }
                else
                {
                    seen.Add(s[front]);
                    if (longest < seen.Count) longest = seen.Count;
                    front++;
                }

            }

            return longest;
        }
    }
}
