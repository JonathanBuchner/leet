using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.FindTheLengthOfTheLongestCommonPrefix
{
    public class Solution
    {
        public int LongestCommonPrefix(int[] arr1, int[] arr2)
        {
            var result = 0;

            var set = GetPrefexs(arr2);

            for (var i = 0; i < arr1.Length; i++)
            {
                result = Math.Max(result, GetHighestPrefix(arr1[i], set));
            }

            return result;
        }

        private HashSet<int> GetPrefexs(int[] arr)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < arr.Length; i++)
            {
                var num = arr[i];
                var d = 1;
                while (true)
                {
                    num = arr[i] / d;

                    if (num < 1)
                        break;

                    if (!set.Contains(num))
                        set.Add(num);

                    d *= 10;
                }
            }

            return set;
        }

        private int GetHighestPrefix(int num, HashSet<int> set)
        {
            var n = num;
            var d = 1;

            while (true)
            {
                n = num / d;

                if (n < 1)
                    return 0;

                if (set.Contains(n))
                    return CountDigits(n);

                d *= 10;
            }
        }

        private int CountDigits(int num)
        {
            if (num < 1)
                throw new ArgumentOutOfRangeException("Number cannnot be less than 1");

            return num.ToString().Length;
        }
    }
}
