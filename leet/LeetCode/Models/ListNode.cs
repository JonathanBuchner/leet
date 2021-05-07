using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Models
{
    public class ListNode
    {
        public int Val { get; set; }
        public ListNode Next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}
