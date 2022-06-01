using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.PalindromeLinkedList
{
    /* Palindrome Linked List
     * 
     * Given the head of a singly linked list, return true if it is a palindrome.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1209/
     */

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
        public bool IsPalindrome(ListNode head)
        {
            var length = 0;
            var curr = head;

            while(curr != null)
            {
                curr = curr.next;
                length++;
            }

            if(length < 2)
            {
                return true;
            }

            var middle = length / 2;
            var counter = 0;
            curr = head;
            ListNode prev = null;

            while(counter <= middle)
            {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
                counter++;
            }

            if (length % 2 != 0)
            {
                curr = curr.next;
                counter++;
            }

            while(curr != null)
            {
                if(prev.val != curr.val)
                {
                    return false;
                }

                curr = curr.next;
                prev = prev.next;
            }

            return true;
        }
    }
}
