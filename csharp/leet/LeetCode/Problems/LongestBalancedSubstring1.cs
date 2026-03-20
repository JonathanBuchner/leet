using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.LongestBalancedSubstring1
{
    public class Solution
    {
        public int LongestBalanced(string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;

            // For loop determining length (start larget)
            for (var i = s.Length - 1; i > 0; i--)
            {
                for (var k = 0; k + i < s.Length; k++)
                {
                    if (IsLbs(s.Substring(k, i)))
                    {
                        return i;
                    }

                }
            }

            return 1;
        }

        private bool IsLbs(string s)
        {
            var count = new int[26];
            var highest = 0;

            // Count number of each letter
            for (var i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
            }

            // Check that all number are the same or zero
            for (var i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    if (highest == 0)
                    {
                        highest = count[i];
                    }
                    else
                    {
                        if (highest != count[i])
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
