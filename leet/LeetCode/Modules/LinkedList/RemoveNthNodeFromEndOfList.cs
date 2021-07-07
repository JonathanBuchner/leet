using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.RemoveNthNodeFromEndOfList
{
    /*
     * Remove Nth Node From End Of List
     * 
     * Given the head of a linked list, remove the nth node from the end of the list and return its head.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1296/
     */
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var curr = head;
            var prev = head;
            var i = 1;
            int ind;

            if (head == null) return null;

            while (curr.next != null)
            {
                curr = curr.next;
                i++;
            }

            ind = i - n;

            if (ind < 0) throw new IndexOutOfRangeException("Nth node is higher than the length of the list");
            
            curr = head;
            i = 0;

            if (curr.next == null) return null;
            curr = curr.next;
            if (ind == 0) return curr;

            while(prev != null)
            {
                if ( i == ind - 1)
                {
                    if (curr == null)
                    {
                        prev.next = null;
                    }
                    else
                    {
                        prev.next = curr.next;
                    }

                    return head;
                }
                else
                {
                    i++;
                    curr = curr.next;
                    prev = prev.next;
                }
            }

            return null;
        }
    }
}
