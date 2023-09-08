﻿using leet.LeetCode.Models;
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

        /*
         * Linked List Cycle II 
         * 
         * Given a linked list, return the node where the cycle begins. If there is no cycle, return null.
         * 
         * https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1214/
         */

        public ListNode DetectCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    slow = head;
                    
                    while(fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }

                    return slow;
                }
            }

            return null;
        }
    }
}
