using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ImplementStackUsingQueues
{
    /*
     * Implement Stack using Queues
     * 
     * Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).
     * 
     * FYI: Program constrains confirm only valid operations.
     * 
     * https://leetcode.com/problems/implement-stack-using-queues/
     */
    public class MyStack
    {
        private int[] arr;
        private int front;

        public MyStack()
        {
            arr = new int[100];
            front = -1;
        }

        public void Push(int x)
        {
            ++front;
            arr[front] = x;
        }

        public int Pop()
        {
            --front;
            return arr[front + 1];
        }

        public int Top()
        {
            return arr[front];
        }

        public bool Empty()
        {
            return -1 >= front;
        }
    }
}
