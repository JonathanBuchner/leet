using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MiddleOfTheLinkedList
{
    /*
     * Middle of the Linked List
     * 
     * Given the head of a singly linked list, return the middle node of the linked list.  If there are two middle nodes, return the second middle node.
     * 
     * https://leetcode.com/problems/middle-of-the-linked-list/
     */
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            if (head.next == null)
            {
                return head;
            }
            if (head.next.next == null)
            {
                return head.next;
            }


            var slow = head;
            var fast = head;

            while (true)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (fast.next == null)
                {
                    return slow;
                }
                else if (fast.next.next == null)
                {
                    return slow.next;
                }

            }
        }
    }
}
