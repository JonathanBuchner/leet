using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PalindromePermutationII
{
    /*
     * Palindrome Permutation
     * 
     * Given a string s, return true if a permutation of the string could form a  palindrome and false otherwise.
     * 
     * https://leetcode.com/problems/palindrome-permutation/submissions/915980660/
     */
    public class Solution
    {
        public bool CanPermutePalindrome(string s)
        {
            var arr = new bool[26];

            for (var i = 0; i < s.Length; i++)
            {
                var index = s[i] - 'a';

                arr[index] = !arr[index];
            }

            if (s.Length % 2 == 0)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                var matches = 0;
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i])
                    {
                        if (matches < 1)
                        {
                            matches++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
