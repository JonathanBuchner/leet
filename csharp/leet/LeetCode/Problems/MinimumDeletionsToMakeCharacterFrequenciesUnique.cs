using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    /*
     * Minimum Deletions to Make Character Frequencies Unique
     * 
     * A string s is called good if there are no two different characters in s that have the same frequency.  Given a string s, return the minimum number of characters you need to delete to make s good.
     * 
     * https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
     */
    public class Solution
    {
        public int MinDeletions(string s)
        {
            var dict = new Dictionary<char, int>();
            var list = new List<int>();

            if(s == null)
            {
                return 0;
            }

            foreach(var c in s)
            {
                if(dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach(var entry in dict)
            {
                list.Add(entry.Value);
            }

            list.Sort((a, b) => b.CompareTo(a));

            var prev = list[0];
            var removals = 0;

            for(var i = 1; i < list.Count; i++)
            {
                if (prev <= 1)
                {
                    removals += list[i];
                }
                else if (list[i] >= prev)
                {
                    var remove = list[i] - prev + 1;
                    prev = list[i] - remove;
                    removals += remove;
                }
                else
                {
                    prev = list[i];
                }
            }

            return removals;
        }
    }
}
