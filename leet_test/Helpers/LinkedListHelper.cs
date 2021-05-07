using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace leet_test.Helpers
{
    public class LinkedListHelper
    {
        public ListNode CreateSinglyLinkedList(int[] list) => CreateList(list, out _);

        public ListNode CreateSinglyLinkedList(int[] list, out ListNode tail) => CreateList(list, out tail);

        private ListNode CreateList(int[] list, out ListNode tail)
        {
            ListNode head = null;
            tail = null;

            if (list.Length > 0) tail = head = new ListNode(list[0]);

            if (list.Length > 1)
            {
                for (var i = 1; i < list.Length; i++)
                {
                    tail = tail.Next = new ListNode(list[i]);
                }
            }

            return head;
        }
    }
}
