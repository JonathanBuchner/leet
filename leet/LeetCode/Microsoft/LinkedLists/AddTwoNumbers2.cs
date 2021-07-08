using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.LinkedLists.AddTwoNumbers2
{
    /*
     * Add Two Numbers II
     * 
     * You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/32/linked-list/205/
     * 
     * NOTE: Not most effecient solution. Did challange "Could you solve it without reversing the input lists?" 
     */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }

            var len1 = 0;
            var len2 = 0;
            var i1 = 0;
            var i2 = 0;
            var h1 = l1;
            var h2 = l2;
            ListNode c1 = null;
            var i3 = 1;
            ListNode carry = null;
            ListNode total = null;
            ListNode result = null;

            while (h1 != null)
            {
                h1 = h1.next;
                len1++;
            }

            while (h2 != null)
            {
                h2 = h2.next;
                len2++;
            }
            
            // Reset values
            h1 = l1;
            h2 = l2;
            i1 = len1;
            i2 = len2;

            // See if we even need to add
            if (len1 == 1 && h1.val == 0)
            {
                return h2;
            }
            else if (len2 == 1 && h2.val == 0)
            {
                return h1;
            }


            // Get lists at same digit
            while (i1 > i2)
            {
                h1 = h1.next;
                i1--;
            }

            while (i2 > i1)
            {
                h2 = h2.next;
                i2--;
            }

            // While at same digit, add lists.  If greater than 9, add one to l to list, else 0;
            while (h1 != null)
            {
                ListNode node = null;
                if (h1.val + h2.val > 9)
                {
                    node = new ListNode(1);
                }
                else
                {
                    node = new ListNode(0);
                }

                if (carry == null)
                {
                    carry = node;
                    c1 = carry;
                }
                else
                {
                    c1.next = node;
                    c1 = c1.next;
                }
                i3++;
                h1 = h1.next;
                h2 = h2.next;
            }

            // Add a zero to the end so carry lines up with correct  
            c1.next = new ListNode(0);

            h1 = l1;
            h2 = l2;
            i1 = len1;
            i2 = len2;
            c1 = carry;

            for 
            (
                var k = Math.Max(i1, Math.Max(i2, i3));
                k > 0;
                k--
            )
            {
                var t = 0;
                if (i3 == k)
                {
                    t += c1.val;
                    c1 = c1.next;
                    i3--;
                }

                if (i1 < k && i2 < k && t == 0)
                {

                    continue;
                }

                if (i1 == k)
                {
                    t += h1.val;
                    h1 = h1.next;
                    i1--;
                }
                if (i2 == k)
                {
                    t += h2.val;
                    h2 = h2.next;
                    i2--;
                }

                if (t > 9) t -= 10;
                var node = new ListNode(t);

                if (total == null)
                {
                    total = node;
                    result = node;
                }
                else
                {
                    total.next = node;
                    total = total.next;
                }
            }

            return result;
        }
    }
}
