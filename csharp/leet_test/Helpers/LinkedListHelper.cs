using leet.LeetCode.Models;
using leet.LeetCode.Modules.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using DoubleListNode = leet.LeetCode.Modules.LinkedList.DoubleListNode;

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
                    tail = tail.next = new ListNode(list[i]);
                }
            }

            return head;
        }

        public DoubleListNode CreateDoubleLinkedList(int[] list) => CreateDoubleList(list, out _);

        public DoubleListNode CreateDoubleLinkedList(int[] list, out DoubleListNode tail) => CreateDoubleList(list, out tail);

        private DoubleListNode CreateDoubleList(int[] list, out DoubleListNode tail)
        {
            DoubleListNode head = null;
            tail = null;

            if (list.Length > 0) tail = head = new DoubleListNode(list[0]);

            if (list.Length > 1)
            {
                for (var i = 1; i < list.Length; i++)
                {
                    tail = tail.Next = new DoubleListNode(list[i], tail);
                }
            }

            return head;
        }
    }
}
