using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList.RemoveLinkedListElements
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode prev = null;
            ListNode curr = head;

            while(curr != null)
            {
                if (curr.val == val)
                {
                    if (curr == head)
                    {
                        head = curr.next;

                    }
                    else
                    {
                        prev.next = curr.next;
                    }
                }
                else
                {
                    prev = curr;
                }

                curr = curr.next;
            }

            return head;
        }
    }
}
