using System;
using System.Collections.Generic;
using System.Text;

/*
 * Given an input string s, reverse the order of the words.
 * A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
 * Return a string of the words in reverse order concatenated by a single space.
 * Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
 * 
 * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/166/
 */

namespace leet.LeetCode.ReverseWordsInaString
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var stack = new Stack<String>();
            var sb = new StringBuilder();

            s.Trim();

            for(var i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (sb.Length > 0)
                    {
                        stack.Push(String.Concat(" ", sb.ToString()));
                        sb.Clear();
                    }
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            stack.Push(sb.ToString());
            sb.Clear();

            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString().Trim();
        }
    }
}
