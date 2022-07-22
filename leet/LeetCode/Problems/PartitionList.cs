using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.PartitionList
{
    /*
     * Partition List
     * 
     * Given the head of a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.  You should preserve the original relative order of the nodes in each of the two partitions.
     * 
     * https://leetcode.com/problems/partition-list/
     */
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            ListNode curr = head;
            ListNode under = null;
            ListNode startUnder = null;
            ListNode equalAbove = null;
            ListNode startEqualAbove = null;

            while (curr != null)
            {
                if(curr.val < x)
                {
                    if(under == null)
                    {
                        startUnder = under = curr;
                    }
                    else
                    {
                        under = under.next = curr;
                    }
                }
                else
                {
                    if (equalAbove == null)
                    {
                        startEqualAbove = equalAbove = curr;
                    }
                    else
                    {
                        equalAbove = equalAbove.next = curr;
                    }
                }

                curr = curr.next;
            }

            if(under != null)
            {
                under.next = startEqualAbove;
            }
            
            if(equalAbove != null)
            {
                equalAbove.next = null;
            }
            
            return startUnder ?? startEqualAbove;
        }
    }
}
