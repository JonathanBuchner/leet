using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ReverseVowels
{
    /*
     * Reverse Vowels of a String
     * 
     * Given a string s, reverse only all the vowels in the string and return it.
     * 
     * The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
     * 
     * https://leetcode.com/problems/reverse-vowels-of-a-string/description/
     */
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            var r = s.Length - 1;
            var l = 0;
            char ll = 'z';
            char rl = 'z';

            var set = new HashSet<char>()
        {
            'a', 'e', 'i', 'o', 'u','A', 'E', 'I', 'O', 'U'
        };

            var sb = new StringBuilder(s);

            while (l < r)
            {
                if (ll == 'z')
                {
                    if (set.Contains(s[l]))
                    {
                        ll = s[l];
                    }
                    else
                    {
                        l++;
                    }
                }
                else if (rl == 'z')
                {
                    if (set.Contains(s[r]))
                    {
                        rl = s[r];
                    }
                    else
                    {
                        r--;
                    }
                }
                else
                {
                    sb[l] = rl;
                    sb[r] = ll;
                    ll = 'z';
                    rl = 'z';
                    r--;
                    l++;
                }
            }

            return sb.ToString();
        }
    }
}
