using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ValidAnagram
{
    /*
     * Valid Anagram
     * 
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
     * 
     * https://leetcode.com/problems/valid-anagram/
     */
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {

            var lets = new int[26];

            for (var i = 0; i < s.Length; ++i)
            {
                lets[s[i] - 'a']++;
            }

            for (var i = 0; i < t.Length; ++i)
            {
                lets[t[i] - 'a']--;
            }

            for (var i = 0; i < lets.Length; ++i)
            {
                if (lets[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
