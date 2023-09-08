using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.RemoveLinkedListElements
{
    /*
     * Remove Linked List Elements
     * 
     * Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
     */
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode prev = null;
            ListNode curr = head;

            while(curr != null)
            {
                if (curr.val == val)
                {
                    if (curr == head)
                    {
                        head = curr.next;

                    }
                    else
                    {
                        prev.next = curr.next;
                    }
                }
                else
                {
                    prev = curr;
                }

                curr = curr.next;
            }

            return head;
        }
    }
}
