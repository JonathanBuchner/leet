using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ShortestWordDistance
{
    /*
     * Shortest Word Distance
     * 
     * Given an array of strings wordsDict and two different strings that already exist in the array word1 and word2, return the shortest distance between these two words in the list.
     * 
     * https://leetcode.com/problems/shortest-word-distance/    
     */
    public class Solution
    {
        public int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            var shortest = Int32.MaxValue;
            var w1 = -1;
            var w2 = -1;

            for (var i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                {
                    w1 = i;

                    if (w2 != -1)
                    {
                        shortest = Math.Min(shortest, w1 - w2);
                    }
                }
                else if (wordsDict[i] == word2)
                {
                    w2 = i;

                    if (w1 != -1)
                    {
                        shortest = Math.Min(shortest, w2 - w1);
                    }
                }
            }

            return shortest;
        }
    }
}
