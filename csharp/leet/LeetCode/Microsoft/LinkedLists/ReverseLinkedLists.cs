using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.LinkedLists.ReverseLinkedLists
{
    /*
     * Reverse Linked Lists
     * 
     * Given the head of a singly linked list, reverse the list, and return the reversed list.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/32/linked-list/169/
     */
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;


            /*ListNode back = null;
            while(head != null)
            {
                var node = new ListNode(head.val, back);
                back = node;
                head = head.next;
            }

            return back;*/
        }
    }
}
