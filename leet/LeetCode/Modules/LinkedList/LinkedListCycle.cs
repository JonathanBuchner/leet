using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.LinkedListCycle
{
    /*
     * Linked List Cycle
     * 
     * Given head, the head of a linked list, determine if the linked list has a cycle in it.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/
     */
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow) return true;
            }

            return false;
        }
    }
}
