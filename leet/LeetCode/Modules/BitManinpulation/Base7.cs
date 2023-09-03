using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Modules.BitManinpulation.Base7
{
    public class Solution
    {
        public string ConvertToBase7(int num)
        {
            var sb = new StringBuilder();
            var isNeg = num < 0;

            if (num == 0)
            {
                return "0";
            }

            if (isNeg)
            {
                num = num * -1;
            }

            while (num != 0)
            {
                sb.Insert(0, Convert.ToString(num % 7));
                num /= 7;
            }

            if (isNeg)
            {
                sb.Insert(0, "-");
            }

            return sb.ToString();
        }
    }
}
