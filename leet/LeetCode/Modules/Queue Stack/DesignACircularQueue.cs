using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Queue_Stack
{
    /*
     * Design Circular Queue
     * 
     * Design your implementation of the circular queue. The circular queue is a linear data structure in which the operations are performed based on FIFO (First In First Out) principle and the last position is connected back to the first position to make a circle. It is also called "Ring Buffer".
     * 
     * https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1337/
     */
    public class MyCircularQueue
    {
        private int[] queue;
        private int rear;
        private int front;
        private int count;

        public MyCircularQueue(int k)
        {
            rear = 0;
            front = 0;
            count = 0;
            queue = new int[k];
        }

        public bool EnQueue(int value)
        {
            if(IsFull())
            {
                return false;
            }
            else if (IsEmpty())
            {
                NextFront();
            }

            NextRear();

            queue[rear] = value;
            count++;

            return true;
        }

        public bool DeQueue()
        {
            if(IsEmpty())
            {
                return false;
            }

            if(rear == front)
            {
                NextRear();
            }

            NextFront();
            count--;

            return true;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return queue[front];
        }

        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return queue[rear];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count >= queue.Length;
        }

        private void NextFront()
        {
            front++;
            if (front == queue.Length)
            {
                front = 0;
            }
        }

        private void NextRear()
        {
            rear++;
            if (rear == queue.Length)
            {
                rear = 0;
            }
        }
    }
}
