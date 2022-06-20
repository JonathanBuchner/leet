using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.ShortEncodingOfWords
{
    public class Solution
    {
        public int MinimumLengthEncoding(string[] words)
        {
            if(words.Length < 1)
            {
                throw new ArgumentException("There must be at least on word in the array");
            }

            var set = new HashSet<string>();
            foreach(var word in words)
            {
                set.Add(word);
            }

            foreach (var word in words)
            {
                for(var i = word.Length - 1; i > 0; i--)
                {
                    var suf = word.Substring(i, word.Length - i);
                    if (set.Contains(suf))
                    {
                        set.Remove(suf);
                    }
                }
            }

            var answer = 0;

            foreach(var word in set)
            {
                answer += word.Length + 1;
            }

            return answer;
        }
    }
}
