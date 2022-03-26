using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.GroupShiftedStrings
{
    public class Solution
    {
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var dict = new Dictionary<string, List<string>>();
            var result = new List<IList<string>>();

            foreach (var str in strings)
            {
                var key = GetKey(str);

                if(dict.ContainsKey(key))
                {
                    dict[key].Add(str);
                }
                else
                {
                    dict.Add(key, new List<string>() { str });
                }
            }

            foreach (var key in dict.Keys)
            {
                result.Add(dict[key]);
            }

            return result;
        }

        private string GetKey(string str)
        {
            int start = str[0] - 97;
            var builder = new StringBuilder();

            foreach(var let in str)
            {
                var num = let - start;
                
                if (num < 97)
                {
                    num += 26;
                }

                builder.Append(Convert.ToChar(num));
            }

            return builder.ToString();
        }
    }
}
