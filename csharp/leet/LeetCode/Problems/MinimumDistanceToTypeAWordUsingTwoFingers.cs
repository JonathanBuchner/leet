using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumDistanceToTypeAWordUsingTwoFingers
{
    /**
     * Minimum Distance to Type a Word Using Two Fingers
     * 
     * https://leetcode.com/problems/minimum-distance-to-type-a-word-using-two-fingers/description
     */
    public class Solution
    {
        private Dictionary<char, int[]> dict;

        public Solution()
        {
            dict = CreateKeyboardPlane();
        }

        public int MinimumDistance(string word)
        {
            return MinimumDistanceRecurse('\0', '\0', word, -1, 0);
        }

        public int MinimumDistanceRecurse(char left, char right, string word, int index, int total)
        {
            index++;
            if (index >= word.Length)
                return total;

            var l_dist = GetDistance(left, word[index]);
            var l_total = MinimumDistanceRecurse(word[index], right, word, index, total + l_dist);
            var r_dist = GetDistance(right, word[index]);
            var r_total = MinimumDistanceRecurse(left, word[index], word, index, total + r_dist);

            return Math.Min(l_total, r_total);
        }


        private int GetDistance(char f, char s)
        {
            if (f == '\0' || s == '\0')
                return 0;

            var f_cor = dict[Char.ToLower(f)];
            var s_cor = dict[Char.ToLower(s)];

            return Math.Abs(f_cor[0] - s_cor[0]) + Math.Abs(f_cor[1] - s_cor[1]);
        }

        private Dictionary<char, int[]> CreateKeyboardPlane()
        {
            var dict = new Dictionary<char, int[]>();

            dict.Add('a', new int[2] { 0, 0 } );
            dict.Add('b', new int[2] { 1, 0 });
            dict.Add('c', new int[2] { 2, 0 });
            dict.Add('d', new int[2] { 3, 0 });
            dict.Add('e', new int[2] { 4, 0 });
            dict.Add('f', new int[2] { 5, 0 });

            dict.Add('g', new int[2] { 0, 1 });
            dict.Add('h', new int[2] { 1, 1 });
            dict.Add('i', new int[2] { 2, 1 });
            dict.Add('j', new int[2] { 3, 1 });
            dict.Add('k', new int[2] { 4, 1 });
            dict.Add('l', new int[2] { 5, 1 });

            dict.Add('m', new int[2] { 0, 2 });
            dict.Add('n', new int[2] { 1, 2 });
            dict.Add('o', new int[2] { 2, 2 });
            dict.Add('p', new int[2] { 3, 2 });
            dict.Add('q', new int[2] { 4, 2 });
            dict.Add('r', new int[2] { 5, 2 });

            dict.Add('s', new int[2] { 0, 3 });
            dict.Add('t', new int[2] { 1, 3 });
            dict.Add('u', new int[2] { 2, 3 });
            dict.Add('v', new int[2] { 3, 3 });
            dict.Add('w', new int[2] { 4, 3 });
            dict.Add('x', new int[2] { 5, 3 });

            dict.Add('y', new int[2] { 0, 4 });
            dict.Add('z', new int[2] { 1, 4 });

            return dict;
        }
    }
}
