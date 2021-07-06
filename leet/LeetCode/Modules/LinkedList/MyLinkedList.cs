using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.LinkedList
{
    /*
     * Design a Linked List
     * 
     * Design your implementation of the linked list. You can choose to use a singly or doubly linked list...
     * 
     * https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1290/
     */
    public class MyLinkedList
    {
        /** Initialize your data structure here. */
        public DoubleListNode Head { get; set; }
        public DoubleListNode Tail { get; set; }
        public MyLinkedList(DoubleListNode head = null, DoubleListNode tail = null)
        {
            Head = head;
            Tail = tail == null ? head : tail;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var i = 0;
            var curr = Head;
            
            while(true)
            {
                if(index == i)
                {
                    return curr.Value;
                }
                else if (curr.Next == null)
                {
                    return -1;
                }
                else
                {
                    curr = curr.Next;
                    i++;
                }
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Head = new DoubleListNode(val, null, Head);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Tail = new DoubleListNode(val, Tail, null);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0) AddAtHead(val);
            
            var i = 0;
            var curr = Head;

            while(true)
            {
                if (i == index)
                {
                    if (curr.Next == null)
                    {
                        AddAtTail(val);
                    }
                    else
                    {
                        curr.Next = new DoubleListNode(val, curr, curr.Next);
                    }
                }
                else if (curr.Next == null)
                {
                    throw new IndexOutOfRangeException($"Cannot add node with value ${val} at index {index}.");
                }
                else
                {
                    curr = curr.Next;
                    i++;
                }
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                Head = Head.Next;
                Head.Prev = null;
            }

            var i = 0;
            var curr = Head;

            while (true)
            {
                if (i == index)
                {
                    if (curr.Next == null)
                    {
                        Tail = Tail.Prev;
                        Tail.Next = null;
                    }
                    else
                    {
                        curr.Prev = curr.Next;
                        curr.Next = curr.Prev;
                    }
                }
                else if (curr.Next == null)
                {
                    throw new IndexOutOfRangeException($"Cannot delete node at index {index}.");
                }
                else
                {
                    curr = curr.Next;
                    i++;
                }
            }
        }
    }

    /*public class DoubleListNode
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
    }*/

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
