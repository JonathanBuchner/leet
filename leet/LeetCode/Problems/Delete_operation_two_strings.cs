using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.Delete_operation_two_strings
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            var dp = new int[word1.Length, word2.Length];

            for(var r = 0; r < word1.Length; r++)
            {
                for (var c = 0; c < word2.Length; c++)
                {
                    if (word1[r] == word2[c])
                    {
                        if(r > 0 && c > 0)
                        {
                            dp[r, c] = dp[r - 1, c - 1] + 1;
                        }
                        else
                        {
                            dp[r, c] = 1;
                        }
                    }
                    else
                    {
                        var t = r > 0 ? dp[r - 1, c] : 0;
                        var l = c > 0 ? dp[r, c - 1] : 0;
                        dp[r,c] = t > l ? t : l;
                    }
                }
            }

            var substring = dp[word1.Length - 1, word2.Length - 1];
            return word1.Length - substring + word2.Length - substring;
        }
    }
}
