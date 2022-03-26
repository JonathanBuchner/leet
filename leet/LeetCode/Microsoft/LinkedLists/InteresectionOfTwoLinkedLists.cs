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
            ListNode currA = headA;
            var lengthA = 0;
            ListNode currB = headB;
            var lengthB = 0;
            ListNode result = null;


            while (currA != null)
            {
                lengthA++;
                currA = currA.next;
            }

            while (currB != null)
            {
                lengthB++;
                currB = currB.next;
            }

            if (lengthA > lengthB)
            {
                currA = headA;
                currB = headB;
            }
            else
            {
                currA = headB;
                currB = headA;
            }

            var i = Math.Abs(lengthA - lengthB);

            while (i > 0)
            {
                currA = currA.next;
                i--;
            }

            while (currA != null || currB != null)
            {
                if (currA == currB)
                {
                    result = currA;
                    break;
                }
                currA = currA.next;
                currB = currB.next;
            }

            return result;
        }
    }
}
