using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Models
{
    public class DoubleListNode
    {
        public DoubleListNode next { get; set; }
        public DoubleListNode prev { get; set; }
        public int val { get; set; }

        public DoubleListNode(int val, DoubleListNode next = null, DoubleListNode prev = null)
        {
            this.next = next;
            this.prev = prev;
            this.val = val;
        }
     }
}
