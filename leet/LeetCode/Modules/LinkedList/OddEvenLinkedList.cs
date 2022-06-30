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
            ListNode evensHead = null;

            while(curr.next != null)
            {
                if(evensHead == null)
                {
                    evensHead = evens = curr.next;
                }
                else 
                {
                    evens = evens.next = curr.next;
                }

                if(curr.next.next != null)
                {
                    curr = curr.next = curr.next.next;
                    evens.next = null;
                }
                else
                {
                    evens.next = null;
                    break;
                }
            }

            curr.next = evensHead;

            return head;
        }
    }
}
