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
            var node = new DoubleListNode(val, null, Head);
            
            if (Head != null)
            {
                Head.Prev = node;
                Head = node;
            }
            else
            {
                Head = node;
                Tail = Head;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var node =  new DoubleListNode(val, Tail, null);
            
            if (node.Prev != null)
            {
                Tail.Next = node;
                Tail = node;
            }
            else
            {
                Tail = node;
                Head = Tail;
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            
            var i = 0;
            var curr = Head;

            while(true)
            {
                if (i == index - 1)
                {
                    if (curr.Next == null)
                    {
                        AddAtTail(val);
                        return;
                    }
                    else
                    {
                        var node = new DoubleListNode(val, curr, curr.Next);
                        curr.Next.Prev = node;
                        curr.Next = node;
                        return;
                    }
                }
                else if (curr == null)
                {
                    throw new IndexOutOfRangeException($"Cannot add node with value {val} at index {index}.");
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
                if(Head.Next == null)
                {
                    Head = null;
                    Tail = null;
                } 
                    else
                {
                    Head = Head.Next;
                    Head.Prev = null;
                }
            }

            var i = 0;
            var curr = Head;

            while (true)
            {
                if (i == index - 1)
                {
                    if (curr.Next == null)
                    {
                        return;
                    }
                    else
                    {
                        var after = curr.Next.Next;
                        
                        if (after == null)
                        {
                            curr.Next = null;
                            Tail = curr;
                        }
                        else
                        {
                            after.Prev = curr;
                            curr.Next = after;
                        }
                    }
                    return;
                }
                else if (curr.Next == null)
                {
                    return;
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
