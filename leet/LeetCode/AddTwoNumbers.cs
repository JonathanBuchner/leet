using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace LeetCode.AddTwoNumbers
{
    #region Problem
    //https://leetcode.com/problems/add-two-numbers/

    // You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order, and each of their nodes contains a single digit.Add the two numbers and return the sum as a linked list.
    #endregion
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var length1 = GetListLength(l1);
            var length2 = GetListLength(l2);
            var longest = Math.Max(length1, length2);
            ListNode currNode = null; 

            for(var i = longest; i > 0; i--)
            {
                var place1 = 0;
                var place2 = 0;

                if(i <= length1)
                {
                    place1 = l1.val;
                    l1 = l1.next;
                }

                if (i <= length2)
                {
                    place2 = l2.val;
                    l2 = l2.next;
                }

                var total = place1 + place2;

                if (total > 9)
                {
                    if (currNode == null)
                    {
                        currNode = new ListNode(1, null);
                    }
                    else
                    {
                        currNode.val++;
                    }
                }

                var next = new ListNode(total);
                currNode.next = next;
                currNode = next;
            }

            return currNode;
        }

        private int GetListLength(ListNode list)
        {
            var length = 0;
            while (list != null)
            {
                length++;
                list = list.next;
            }

            return length;
        }
    }
}
