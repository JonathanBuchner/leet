using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.DetectCapital
{
    /*
     * Detect Capital
     * We define the usage of capitals in a word to be right when one of the following cases holds:
     *      All letters in this word are capitals, like "USA".
     *      All letters in this word are not capitals, like "leetcode".
     *      Only the first letter in this word is capital, like "Google".
     * Given a string word, return true if the usage of capitals in it is right.
     * 
     * https://leetcode.com/problems/detect-capital/description/
     */
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {

            if (word.Length < 2)
            {
                return true;
            }

            if (!(word[0] >= 65 && word[0] <= 91) && word[1] >= 65 && word[1] <= 91)
            {
                Console.WriteLine("First is lower, second is upper");
                return false;
            }

            var areUpper = false;
            var areLower = false;
            for (var i = 1; i < word.Length; i++)
            {
                var isUpper = word[i] >= 65 && word[i] <= 91;

                if (isUpper)
                {
                    Console.WriteLine("Upper marked true");
                    areUpper = true;
                }
                else
                {
                    Console.WriteLine("Lower marked true");
                    areLower = true;
                }

                if (areUpper && areLower)
                {
                    Console.WriteLine("Mismatch");
                    return false;
                }
            }

            return true;
        }
    }
}
