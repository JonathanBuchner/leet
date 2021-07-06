using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList
{
    public class DoubleListNode
    {
        public int Value { get; set; }
        public DoubleListNode Next { get; set; }
        public DoubleListNode Prev { get; set; }

        public DoubleListNode(int value, DoubleListNode prev = null, DoubleListNode next = null)
        {
            Value = value;
            Prev = prev;
            Next = next;
        }
    }
}
