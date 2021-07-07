using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.IntersectOfTwoLinkedLists
{
    /*
     * Intersection of Two Linked Lists
     * 
     * Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1215/
     */
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var aList = headA;
            var bList = headB;
            var a = 0;
            var b = 0;

            while (aList.next != null)
            {
                aList = aList.next;
                a++;
            }

            while (bList.next != null)
            {
                bList = bList.next;
                b++;
            }

            if (aList != bList) return null;

            aList = MoveNode(Math.Max(0, a - b), headA);
            bList = MoveNode(Math.Max(0, b - a), headB);

            while(aList != bList)
            {
                aList = aList.next;
                bList = bList.next;
            }

            return aList;
        }

        private ListNode MoveNode(int index, ListNode node)
        {
            var i = 0;
            var curr = node;

            while(i < index)
            {
                i++;
                curr = curr.next;
            }

            return curr;
        }
    }
}
