using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
            if(head == null || head.next == null)
            {
                return head;
            }

            ListNode curr = head;
            ListNode prev = null;
            ListNode l = null;
            ListNode r = null;
            var i = 1;

            while(i < left)
            {
                prev = curr;
                curr = curr.next;
                ++i;
            }

            l = prev;
            r = curr;
            
            while(curr != null && i <= right)
            {
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                ++i;
            }
            if(l != null)
            {
                l.next = prev;
            }
            else
            {
                head = prev;
            }

            r.next = curr;

            return head;
        }
    }
}
