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
     * 
     */
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode back = null;
            while(head != null)
            {
                var node = new ListNode(head.val, back);
                back = node;
                head = head.next;
            }

            return back;
        }
    }
}
