using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.RemoveVowelsFromAstring
{
    public class Solution
    {
        public string RemoveVowels(string s)
        {

            var sb = new System.Text.StringBuilder(s);
            var i = 0;

            while (i < sb.Length)
            {
                if
                (
                    sb[i] == 'a' ||
                    sb[i] == 'e' ||
                    sb[i] == 'i' ||
                    sb[i] == 'o' ||
                    sb[i] == 'u'
                )
                {
                    sb.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            return sb.ToString();
        }
    }

    // Faster solution
    /*
        public class Solution {
            public string RemoveVowels(string s) {
                char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < s.Length; i++) {
                    if(Array.IndexOf(vowels, s[i]) < 0) {
                        sb.Append(s[i]);
                    }
                }
                return sb.ToString();
            }
        }
    */
}
