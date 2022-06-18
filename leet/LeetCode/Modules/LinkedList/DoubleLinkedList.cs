using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace leet.LeetCode.Modules.LinkedList.DoubleLinkedList
{
    public class MyLinkedList
    {
        private DoubleListNode head;
        private DoubleListNode tail;

        public MyLinkedList()
        {
            head = null;
            tail = null;
        }

        public MyLinkedList(DoubleListNode head, DoubleListNode tail)
        {
            this.head = head;
            this.tail = tail;
        }

        public int Get(int index)
        {
            var counter = 0;
            var curr = head;
            
            if(curr == null)
            {
                return -1;
            }

            while (counter < index)
            {
                if(curr.Next == null)
                {
                    return -1;
                }

                curr = curr.Next;
                counter++;
            }

            return curr.Value;
        }

        public void AddAtHead(int val)
        {
            head = new DoubleListNode(val, null, head);
            
            if(head.Next == null)
            {
                tail = head;
            }
            else 
            { 
                head.Next.Prev = head;
            }
        }

        public void AddAtTail(int val)
        {
            if (tail == null)
            {
                AddAtHead(val);
            }
            else
            {
                tail = new DoubleListNode(val, tail, null);
                tail.Prev.Next = tail;
            }
        }

        public void AddAtIndex(int index, int val)
        {
            if(index == 0)
            {
                AddAtHead(val);
                return;
            }

            if(head == null)
            {
                return;
            }

            var counter = 1;
            var curr = head;

            while(counter < index)
            {
                curr = curr.Next;
                counter++;

                if (curr == null)
                {
                    //  If index is greater than the length, the node will not be inserted.
                    return;
                }
            }

            if(curr.Next == null)
            {
                AddAtTail(val);
                return;
            }

            curr.Next = new DoubleListNode(val, curr, curr.Next);
            curr.Next.Next.Prev = curr.Next;
        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                head = head.Next;
                if (head != null)
                {
                    head.Prev = null;
                }
                return; 
            }
            var counter = 0;
            var curr = head;

            while (counter < index - 1)
            {
                curr = curr.Next;
                counter++;

                if (curr == null)
                {
                    //  If index is greater than the length, the node will not be inserted.
                    return;
                }
            }

            if (curr.Next == null)
            {
                tail = curr;
                curr.Next = null;
                return;
            }

            curr.Next = curr.Next.Next;
            
            if (curr.Next !=  null)
            {
                curr.Next.Prev = curr;
            }
            else
            {
                tail = curr;
            }
            
        }
    }
}
