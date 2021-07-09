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
            // Input list lenght.  List starting index is 1
            var len1 = 0;
            var len2 = 0;

            // indexs used for tracking traversing lists
            int i1;
            int i2;

            // Lists used for traversing
            var list1 = l1;
            var list2 = l2;
            ListNode listC = null;
            ListNode total = null;

            // List heads
            ListNode headC = null;
            ListNode result = null;

            // Handle null lists;
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

            //  Set lengths of lists
            while (list1 != null)
            {
                list1 = list1.next;
                len1++;
            }

            while (list2 != null)
            {
                list2 = list2.next;
                len2++;
            }
            
            // Set / Reset index and traverse lists
            list1 = l1;
            list2 = l2;
            i1 = len1;
            i2 = len2;

            // TODO: Can delete?
            if (len1 == 1 && list1.val == 0)
            {
                return list2;
            }
            else if (len2 == 1 && list2.val == 0)
            {
                return list1;
            }

            // Reset lengths and lists
            list1 = l1;
            list2 = l2;
            i1 = len1;
            i2 = len2;

            // Set up carry list
            for (var i = Math.Max(i1, i2); i > 0; i--)
            {
                var t = 0;

                if (i == i1)
                {
                    t += list1.val;
                    list1 = list1.next;
                    i1--;
                }
                if(i == i2)
                {
                    t += list2.val;
                    list2 = list2.next;
                    i2--;
                }

                if (t > 9)
                {
                    listC = new ListNode(10, listC);
                } 
                else if (t == 9)
                {
                    listC = new ListNode(9, listC);
                }
                else
                {
                    listC = new ListNode(0, listC);
                }
            }
            listC = new ListNode(0, listC);


            // Correct carry list, reverse it, set length;
            var carry = 0;
            while (listC != null)
            {
                if (listC.val + carry > 9)
                {
                    carry = 1;
                    listC.val = 1;
                }
                else
                {
                    carry = 0;
                    listC.val = 0;
                }
                headC = new ListNode(listC.val, headC);
                listC = listC.next;
            }


            // Add all three lines
            list1 = l1;
            list2 = l2;
            i1 = len1;
            i2 = len2;
            for ( var k = Math.Max(i1,i2) + 1;  k > 0; k-- )
            {
                var t = headC.val;        
                headC = headC.next;

                if (i1 < k && i2 < k && t == 0) continue;


                if (i1 == k)
                {
                    t += list1.val;
                    list1 = list1.next;
                    i1--;
                }
                if (i2 == k)
                {
                    t += list2.val;
                    list2 = list2.next;
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
