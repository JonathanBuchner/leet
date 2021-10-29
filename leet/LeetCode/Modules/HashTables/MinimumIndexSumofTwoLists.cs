using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.MinimumIndexSumofTwoLists
{
    /*
     * Minimum Index Sum of Two Lists
     * 
     * Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1177/
     */
    public class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var dict = new Dictionary<string, int>();
            var lowest = Int32.MaxValue;
            var lowestList = new List<string>();


            for(var i = 0; i < list1.Length; i++ )
            {
                dict.Add(list1[i], i);
            }

            for(var i =0; i <list2.Length; i++)
            {
                int index; 
                var found = dict.TryGetValue(list2[i], out index);

                if (found)
                {
                    var total = index + i;
                    
                    if(lowest > total)
                    {
                        lowestList.Clear();
                        lowestList.Add(list2[i]);
                        lowest = total;
                    }
                    else if(lowest == total)
                    {
                        lowestList.Add(list2[i]);
                    }
                }
            }

            return lowestList.ToArray();
        }
    }
}
