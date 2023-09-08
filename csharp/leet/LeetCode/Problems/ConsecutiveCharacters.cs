using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.ConsecutiveCharacters
{
    public class Solution
    {
        /*
         * Consecutive Characters
         * 
         * The power of the string is the maximum length of a non-empty substring that contains only one unique character.  Given a string s, return the power of s.
         * 
         * https://leetcode.com/problems/consecutive-characters/
         */
        public int MaxPower(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            var max = 1;
            var challanger = 1;
            char curr = s[0]; 
                
            for(var i = 1; i < s.Length; i++)
            {
                if (curr == s[i])
                {
                    challanger++;
                    max = Math.Max(max, challanger);
                }
                else
                {
                    curr = s[i];
                    challanger = 1;
                }
            }

            return max;
        }
    }
}
