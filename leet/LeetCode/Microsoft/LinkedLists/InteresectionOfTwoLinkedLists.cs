using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.LinkedLists.InteresectionOfTwoLinkedLists
{
    /*
     * Intersection of Two Linked Lists
     * 
     * Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/32/linked-list/212/
     */
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            headA = ReverseList(headA);
            headB = ReverseList(headB);
            ListNode currA = headA;
            ListNode currB = headB;

            while (currA != null || currB != null)
            {
                if (currA == currB)
                {
                    return currA;
                }
                currA = currA.next;
                currB = currB.next;
            }

            return null;
        }
        private ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode reverse = null;

            while (curr != null)
            {
                var next = curr.next;
                curr.next = reverse;
                reverse = curr;
                curr = next;
            }

            return reverse;
        }
    }
}
