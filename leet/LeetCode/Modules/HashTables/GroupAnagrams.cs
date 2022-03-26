using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet.LeetCode.Modules.HashTables.GroupAnagrams
{
    public class Solution
    {
        /*
         * Group Anagrams
         * 
         * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
         * 
         * https://leetcode.com/explore/learn/card/hash-table/185/hash_table_design_the_key/1124/
         */
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            var result = new List<IList<string>>();

            foreach(var str in strs)
            {
                var key = String.Concat(str.OrderBy(c => c));
                
                if(dict.ContainsKey(key))
                {
                    dict[key].Add(str);
                }
                else
                {
                    dict.Add(key, new List<string>() { str });
                }
            }

            foreach(var key in dict.Keys)
            {
                result.Add(dict[key]);
            }

            return (List<IList<string>>) result;
        }
    }
}
