using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.LinkedLists.MergeTwoSortedLists
{
    /*
     * Merge Two Sorted Link Lists
     * 
     * Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
     * 
     * https://leetcode.com/explore/interview/card/microsoft/32/linked-list/175/
     */
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var p = new Problem()
            {
                head = null,
                curr = null,
            };

            while (l1 != null && l2 != null)
            {
                if(l1.val > l2.val)
                {
                    AddNode(p, l2.val);
                    l2 = l2.next;
                }
                else
                {
                    AddNode(p, l1.val);
                    l1 = l1.next;
                }
            }
            while (l1 != null)
            {
                AddNode(p, l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                AddNode(p, l2.val);
                l2 = l2.next;
            }

            return p.head;
        }

        private void AddNode(Problem problem, int val)
        {
            if (problem.head == null)
            {
                problem.head = problem.curr = new ListNode(val);
            }
            else
            {
                problem.curr = problem.curr.next = new ListNode(val);
            }
        }
    }

    public class Problem
    {
        public ListNode curr { get; set; }
        public ListNode head { get; set; }

    }
}
