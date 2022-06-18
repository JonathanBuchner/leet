using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.OddEvenLinkedList
{
    /*
     * Odd Even Linked List
     * 
     * The first node is considered odd, and the second node is even, and so on.
     * Note that the relative order inside both the even and odd groups should remain as it was in the input.
     * You must solve the problem in O(1) extra space complexity and O(n) time complexity.
     * 
     * https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1208/
     */
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return head;

            ListNode curr = head;
            ListNode odd = curr;
            ListNode even = null;
            ListNode evenList = null;
            ListNode oddList = null;
            var i = 0;

            while (curr != null)
            {
                if( i % 2 == 0 )
                {
                    if(evenList == null)
                    {
                        evenList = even = curr;
                    }
                    else
                    {
                        even = even.next = curr;
                    }
                }
                else
                {
                    if (oddList == null)
                    {
                        oddList = odd = curr;
                    }
                    else
                    {
                        odd = odd.next = curr;
                    }
                }

                i++;
                curr = curr.next;
            }
            odd.next = null;
            even.next = oddList;
            

            return evenList;
        }
    }
}
