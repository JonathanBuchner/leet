using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace leet.LeetCode.Modules.LinkedList
{
    /***
     * DO NOT US
     * 
     * Was rewritten and passes all tests as double linked list.
     * 
     * 
     * **/
    public class MySinglyLinkedList
    {
        /** Initialize your data structure here. */
        private ListNode _head;
        private ListNode _tail;

        public MySinglyLinkedList(ListNode head, ListNode tail = null)
        {
            _head = head;
            _tail = tail ?? GetTail();
        }

        public ListNode Head => _head;

        public ListNode Tail => _tail;

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var pos = 0;
            var curr = _head;

            while(pos < index)
            {
                curr = curr.next;
                pos++;
            }

            return curr.val;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public ListNode GetNode(int index)
        {
            var pos = 0;
            var curr = _head;

            while (pos < index)
            {
                curr = curr.next;
                pos++;
            }

            return curr;
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
            _tail = _tail.next = new ListNode(val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0) AddAtHead(val);

            var pos = 0;
            var curr = _head;

            while (pos < index - 1)
            {
                curr = curr.next;
                pos++;
            }

            var insertNode = new ListNode(val, curr.next.next);
            curr.next = insertNode;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 0) _head = _head.next;

            var pos = 0;
            var curr = _head;

            while (pos < index - 1)
            {
                curr = curr.next;
                pos++;
            }

            curr.next = curr.next.next;
        }

        private ListNode GetTail()
        {           
            var curr = _head;

            while(curr.next != null)
            {
                curr = curr.next;
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
