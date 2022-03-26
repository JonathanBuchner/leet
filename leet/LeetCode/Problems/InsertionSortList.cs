using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.InsertionSortList
{
    /*
     * Insertion Sort List
     * 
     * Given the head of a singly linked list, sort the list using insertion sort, and return the sorted list's head.
     * 
     * The steps of the insertion sort algorithm:
     * 
     * 1) Insertion sort iterates, consuming one input element each repetition and growing a sorted output list.
     * 2) At each iteration, insertion sort removes one element from the input data, finds the location it belongs within the sorted list and inserts it there.
     * 3) It repeats until no input elements remain.
     * 
     * The following is a graphical example of the insertion sort algorithm. The partially sorted list (black) initially contains only the first element in the list. One element (red) is removed from the input data and inserted in-place into the sorted list with each iteration.
     * 
     * https://leetcode.com/problems/insertion-sort-list/
     */
    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            
            if(head == null && head.next == null)
            {
                return head;
            }

            ListNode result = head;
            ListNode count = head;

            while (count.next != null)
            {
                ListNode move = count.next;
                ListNode curr = result;
                ListNode prev = null;
                
                while(true)
                {
                    if (move.val < curr.val)
                    {
                        count.next = count.next.next;
                        
                        
                        if (prev == null)
                        {
                            move.next = result;
                            result = move;
                        }
                        else
                        {
                            prev.next = move;
                            move.next = curr;
                        }
                        break;
                    }

                    if(curr == move)
                    {
                        count = count.next;
                        break;
                    }

                    prev = curr;
                    curr = curr.next;
                }
            }

            return result;
        }
    }
}
