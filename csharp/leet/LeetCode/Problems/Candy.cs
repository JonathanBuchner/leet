using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.Candy
{/*
  * Candy
  * 
  * You are giving candies to these children subjected to the following requirements:
  * 
  *   Each child must have at least one candy.
  *   Children with a higher rating get more candies than their neighbors.
  * 
  * Return the minimum number of candies you need to have to distribute the candies to the children.
  * 
  * https://leetcode.com/problems/candy/
  */
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            var candies = new int[ratings.Length];

            var list = new List<(int, int)>();

            for(var i = 0; i < ratings.Length; ++i)
            {
                list.Add((ratings[i], i));
            }

            list.Sort((a, b) => a.Item1.CompareTo(b.Item1));

            foreach(var pair in list)
            {
                var highest = 1;
                var rating = pair.Item1;

                if(pair.Item2 != 0)
                {
                    if(rating > ratings[pair.Item2 - 1])
                    {
                        highest = candies[pair.Item2 - 1] + 1;
                    }
                }

                if(pair.Item2 != ratings.Length -1)
                {
                    if (rating > ratings[pair.Item2 + 1])
                    {
                        highest = Math.Max(highest, candies[pair.Item2 + 1] + 1);
                    }
                }

                candies[pair.Item2] = highest;
            }

            return candies.Sum();
        }
    }
}
