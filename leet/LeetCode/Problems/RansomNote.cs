using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RansomNote
{
    /*
     * Ransom Note
     * 
     * Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
     * 
     * Each letter in magazine can only be used once in ransomNote.
     * 
     * https://leetcode.com/problems/ransom-note/description/
     */
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var rlist = new int[26];

            for (var i = 0; i < magazine.Length; i++)
            {
                var index = magazine[i] - 'a';
                rlist[index]++;
            }

            for (var i = 0; i < ransomNote.Length; i++)
            {
                var index = ransomNote[i] - 'a';

                rlist[index]--;

                if (rlist[index] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
