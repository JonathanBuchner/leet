using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RegularExpressionMatching
{
    public class Solution
    {
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public bool IsMatch(string s, string p)
        {
            if (p.Length == 0)
                return s.Length == 0;

            var match = false;
            
            if (s.Length != 0)
            {
                match = s[0] == p[0] || p[0] == '.';
            }

            if (p.Length >= 2 && p[1] == '*')
            {
                return IsMatch(s, p.Substring(2)) || (match && IsMatch(s.Substring(1), p));
            }

            return match && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}
