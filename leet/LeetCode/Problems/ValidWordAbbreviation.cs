using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ValidWordAbbreviation
{
    /*
     * Valid word abbreviation
     * 
     * A string can be abbreviated by replacing any number of non-adjacent, non-empty substrings with their lengths. The lengths should not have leading zeros.
     * 
     * Given a string word and an abbreviation abbr, return whether the string matches the given abbreviation.
     * 
     * A substring is a contiguous non-empty sequence of characters within a string.
     * 
     * https://leetcode.com/problems/valid-word-abbreviation/description/
     */
    public class Solution
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            var a = 0;
            var w = 0;

            while (true)
            {
                //Words match.  Both indexes past matching characters
                if (word.Length == w && abbr.Length == a)
                {
                    return true;
                }

                //Words do no match: a word is longer
                if (a >= abbr.Length || w >= word.Length)
                {
                    return false;
                }

                // If a digit, find any following digits and then increase indexes.
                if (Char.IsDigit(abbr[a]))
                {
                    var i = a;
                    var sb = new StringBuilder();

                    if (abbr[i] == '0') { return false; }

                    while (i < abbr.Length && Char.IsDigit(abbr[i]))
                    {
                        sb.Append(abbr[i]);

                        i++;
                    }

                    w += Convert.ToInt32(sb.ToString());
                    a = i;
                }
                else
                {
                    // Words do not match.  Letters at the same spot do not match up.
                    if (word[w] != abbr[a])
                    {
                        return false;
                    }

                    w++;
                    a++;
                }
            }
        }
    }
}
