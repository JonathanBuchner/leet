using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet.LeetCode.ValidParentheses
{
    /*
     * Valid Parantheses
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * 
     * An input string is valid if:
     * - Open brackets must be closed by the same type of brackets.
     * - Open brackets must be closed in the correct order.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/179/
     */
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var closingBrackets = new char[] { ')', ']', '}' };

            for(var i = 0; i < s.Length; i++)
            {
                if (closingBrackets.Contains(s[i]))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var prev = stack.Pop();
                     
                    if (s[i] == ')' && prev == '(')
                    {
                        continue;
                    }
                    else if (s[i] == ']' && prev == '[')
                    {
                        continue;
                    }
                    else if (s[i] == '}' && prev == '{')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;
        }
    }
}
