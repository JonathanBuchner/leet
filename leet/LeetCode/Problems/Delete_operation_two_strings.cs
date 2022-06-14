using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.Delete_operation_two_strings
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            var substring = word1.Length > word2.Length ? word2.Length : word1.Length;

            while (substring > 0)
            {
                var list = new HashSet<string>();
                var p1 = 0;

                while (p1 + substring <= word1.Length)
                {
                    list.Add(word1.Substring(p1, substring));
                    p1++;
                }

                p1 = 0;

                while (p1+substring <= word2.Length)
                {
                    if(list.Contains(word2.Substring(p1, substring)))
                    {
                        return (word1.Length - substring) + (word2.Length - substring); 
                    };
                    p1++;
                }

                substring--;
            }

            return word1.Length + word2.Length;
        }
    }
}
