using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RegularExpressionMatching
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            return IsMatch(s, p, 0, 0);
        }
        public bool IsMatch(string s, string p, int s_i, int p_i)
        {
            if (s.Length == 0 || p.Length == 0 || p.StartsWith('*'))
            {
                return false;
            }

            while (true)
            {
                if (p_i + 1 < p.Length && p[p_i + 1] == '*')
                {
                    var multi = p[p_i];
                    if (multi == '.')
                    {
                        if (p_i + 2 >= p.Length)
                        {
                            return true;
                        }

                        p_i += 2;
                        var next = p[p_i]; 

                        while (s_i < s.Length)
                        {
                            if (IsMatch(s, p, s_i, p_i))
                            {
                                return true;
                            }
                            s_i++;
                        }

                        return false; 
                    }
                    else
                    {
                        while (p[p_i] == multi || p[p_i] == '*')
                        {
                            p_i++;
                            if (p_i >= p.Length)
                            {
                                break;
                            }
                        }

                        while (s_i < s.Length && s[s_i] == multi)
                        {
                            s_i++;
                        }
                    }
                }
                else
                {
                    if (s_i >= s.Length || p_i >= p.Length)
                    {
                        break;
                    }

                    var match = p[p_i];

                    if (match != s[s_i] && match != '.')
                    {
                        return false;
                    }

                    s_i++;
                    p_i++;
                    
                }
            }

            return p_i == p.Length && s_i == s.Length;
        }
    }
}
