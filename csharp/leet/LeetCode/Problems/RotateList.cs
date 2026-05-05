using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Rotate List
 * 
 * Given the head of a linked list, rotate the list to the right by k places.
 * 
 * https://leetcode.com/problems/rotate-list/description/?envType=daily-question&envId=2026-05-05
 */ 

namespace leet.LeetCode.Problems.RotateList
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int val=0, ListNode next=null) {
    *         this.val = val;
    *         this.next = next;
    *     }
    * }
    */
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            // Handle edge cases:
            // 1) Nothing to mive
            // 2) List is empty; null
            // 2) List has one item: can't rotate.
            if (k == 0 || head == null || head.next == null)
                return head;

            // Find lenth of list by setting curr to last item in list.
            var curr = head;
            var i = 1;
            while (curr.next != null)
            {
                curr = curr.next;
                i++;
            }

            // Set last item to point to first item; create wrap around.
            curr.next = head;

            // Go back through list to find item before new HEAD.
            var len = i - (k % i);
            curr = head;
            while (len > 1)
            {
                curr = curr.next;
                len--;
            }

            // Set the next item to the first item in the list
            head = curr.next;
            // Make current item the last item in the list.
            curr.next = null;

            return head;
        }
    }
}
