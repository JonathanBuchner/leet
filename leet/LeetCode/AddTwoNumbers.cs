using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

namespace leet.LeetCode.AddTwoNumbers
{
    #region Problem
    //https://leetcode.com/problems/add-two-numbers/

    // You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order, and each of their nodes contains a single digit.Add the two numbers and return the sum as a linked list.
    #endregion
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode tail = null;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                var val1 = 0;
                var val2 = 0;

                // Get value and and progress list by one if needed.
                if (l1 != null)
                {
                    val1 = l1.Val;
                    l1 = l1.Next;
                }

                if (l2 != null)
                {
                    val2 = l2.Val;
                    l2 = l2.Next;
                }

                var total = val1 + val2 + carry;
                carry = 0;

                // Set up carry
                if (total > 9)
                {
                    total = total - 10;
                    carry = 1;
                }

                // Create new node with the total value
                if (head == null)
                {
                    tail = head = new ListNode(total);
                }
                else
                {
                    tail = tail.Next = new ListNode(total);
                }

                //Lists are empty but there is still a carry, add one.
                if (l1 == null && l2 == null && carry == 1)
                {
                    tail.Next = new ListNode(1);
                    //Loop should also be broken
                }
            }

            return head;
        }
    }
}
