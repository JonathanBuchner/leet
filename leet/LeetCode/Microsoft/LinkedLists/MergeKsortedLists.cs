using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Microsoft.LinkedLists.MergeKsortedLists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode head = null;
            ListNode curr = null;
            ListNode temp = null;

            if (lists.Length == 0) return null;

            while(true)
            {
                foreach (var list in lists)
                {
                    if (list == null)
                    {
                        continue;
                    }
                    else if (temp == null)
                    {
                        temp = list;
                    }
                    else
                    {
                        if (temp.val > list.val)
                        {
                            temp = list;
                        }
                    }
                }

                if (temp == null)
                {
                    break;
                }
                else if (head == null)
                {
                    head = curr = new ListNode(temp.val);
                }
                else
                {
                    curr = curr.next = new ListNode(temp.val);
                }

                for (var i = 0; i < lists.Length; i++)
                {
                    if (lists[i] == temp)
                    {
                        lists[i] = lists[i].next;
                        break;
                    }
                }
                temp = null;
            }

            return head;
        }
    }
}
