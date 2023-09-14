using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RelativeRanks
{
    /*
    * Relative Ranks
    *
    * You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition. All the scores are guaranteed to be unique.
    *
    * The athletes are placed based on their scores, where the 1st place athlete has the highest score, the 2nd place athlete has the 2nd highest score, and so on. The placement of each athlete determines their rank:
    *
    * https://leetcode.com/problems/relative-ranks/
    */
    public class Solution {
        public string[] FindRelativeRanks(int[] score) {
            var arr = new int[score.Length][];
            var result = new String[score.Length];
            
            for (var i = 0; i < score.Length; i++)
            {
                arr[i] = new int[] {i, score[i]};
            }

            Array.Sort(arr, (a,b) => b[1].CompareTo(a[1]));

            for (var i = 0; i < arr.Length; i++)
            {
                var index = arr[i][0];
                Console.WriteLine(index);
                result[index] = GetMedel(i+1);
            }

            return result;
        }

        private string GetMedel(int place)
        {
            switch(place)
            {
                case 1 :
                    return "Gold Medal";
                
                case 2 :
                    return "Silver Medal";

                case 3 :
                    return "Bronze Medal";

                default:
                    return place.ToString();
            }
        }
    }
}