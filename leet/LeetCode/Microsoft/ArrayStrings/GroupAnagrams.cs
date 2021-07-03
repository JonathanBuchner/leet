using System;
using System.Collections.Generic;

namespace leet.LeetCode.Microsoft.ArrayStrings.GroupAnagrams
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
            var dict = new Dictionary<string, IList<string>>();
            var list = new List<IList<string>>();

            foreach (var str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                var sorted = new String(chars);

                if (dict.ContainsKey(sorted))
                {
                    dict[sorted].Add(str);
                }
                else
                { 
                    dict.Add(sorted, new List<string>() { str });
                }
            }

            foreach (var item in dict)
            {
                list.Add(item.Value);
            }

            return list;
        }
    }
}
