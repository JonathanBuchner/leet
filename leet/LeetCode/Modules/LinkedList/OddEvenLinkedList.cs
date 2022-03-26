using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.OddEvenLinkedList
{
    /*
     * Odd Even Linked List
     * 
     * The first node is considered odd, and the second node is even, and so on.
     * Note that the relative order inside both the even and odd groups should remain as it was in the input.
     * You must solve the problem in O(1) extra space complexity and O(n) time complexity.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1208/
     */
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return head;

            ListNode curr = head;
            ListNode evens = null;
            ListNode evenList = null;
            var i = 0;

            while (curr.next != null)
            {
                ListNode next = curr.next;
                
                if (i % 2 == 1)
                {
                    if (evenList == null)
                    {
                        evens = evenList = curr;
                    }
                    else
                    {
                        evens = evens.next = curr;
                    }
                }
                else
                {
                    curr.next = curr.next.next;
                }

                i++;
                curr = next;
            }
            even.next = null;
            curr.next = evenList;

            return head;
        }
    }
}
