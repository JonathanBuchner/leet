using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet.LeetCode.GroupAnagrams
{
    /*
     * Group Anagrams
     * 
     * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
     * 
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/200/
     */
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, int>();
            var list = new List<IList<string>>();

            for (var i = 0; i < strs.Length; i++)
            {
                var chars = strs[i].ToCharArray();
                Array.Sort(chars);
                var sorted = new String(chars);

                if (dict.ContainsKey(sorted))
                {
                    list[dict[sorted]].Add(strs[i]);
                }
                else
                { 
                    dict.Add(sorted, list.Count());
                    list.Add(new List<string>() { strs[i] });
                }
            }

            return list;
        }
    }
}
