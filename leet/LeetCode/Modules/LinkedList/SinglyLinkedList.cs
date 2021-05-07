using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace leet.LeetCode.Modules.LinkedList
{
    public class MyLinkedList
    {
        /** Initialize your data structure here. */
        private ListNode _head;
        private ListNode _tail;

        public MyLinkedList(ListNode head, ListNode tail = null)
        {
            _head = head;
            _tail = tail ?? GetTail();
        }

        public ListNode Head => _head;

        public ListNode Tail => _tail;

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var pos = 1;
            var curr = _head;

            while(pos < index)
            {
                curr = curr.Next;
                pos++;
            }

            return curr.Val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var prevHead = _head;
            _head = new ListNode(val, prevHead);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            _tail = _tail.Next = new ListNode(val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 1) AddAtHead(val);

            var pos = 1;
            var curr = _head;

            while (pos < index - 1)
            {
                curr = curr.Next;
                pos++;
            }

            var insertNode = new ListNode(val, curr.Next.Next);
            curr.Next = insertNode;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 1) _head = _head.Next;

            var pos = 1;
            var curr = _head;

            while (pos < index - 1)
            {
                curr = curr.Next;
                pos++;
            }

            curr.Next = curr.Next.Next;
        }

        private ListNode GetTail()
        {           
            var curr = _head;

            while(curr.Next != null)
            {
                curr = curr.Next;
            }

            return curr;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
