using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ReverseLinkedListII
{
    /*
     * Reverse Linked List II
     * 
     * Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.
     * 
     * https://leetcode.com/problems/reverse-linked-list-ii/
     */
    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode l = null;
            ListNode r = null;
            var i = 0;

            while(i < left)
            {
                curr = curr.next;
                ++i;
            }
            l = prev = curr;
            r = curr = curr.next;

            while(curr != null && i <= right)
            {
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            l.next = prev;
            r.next = curr;

            return head;
        }
    }
}
