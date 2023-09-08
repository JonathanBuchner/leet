using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ImplementQueueUsingStacks
{
    /*
     * Implement Queue using Stacks
     * 
     * Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).
     * 
     * https://leetcode.com/problems/implement-queue-using-stacks/description/
     */
    public class MyQueue
    {
        private Stack<int> loading = new Stack<int>();
        private Stack<int> unloading = new Stack<int>();
        private bool isLoading = true;

        public MyQueue()
        {

        }

        public void Push(int x)
        {
            isLoading = true;
            PrepareQueue();
            loading.Push(x);
        }

        public int Pop()
        {
            isLoading = false;
            PrepareQueue();

            return unloading.Pop();
        }

        public int Peek()
        {
            isLoading = false;
            PrepareQueue();

            return unloading.Peek();
        }

        public bool Empty()
        {
            return loading.Count + unloading.Count < 1;
        }

        private void PrepareQueue()
        {
            if (isLoading)
            {
                while (unloading.Count > 0)
                {
                    loading.Push(unloading.Pop());
                }
            }
            else
            {
                while (loading.Count > 0)
                {
                    unloading.Push(loading.Pop());
                }
            }
        }

        private void DEBUG_QUEUE()
        {
            Console.WriteLine($"Left Queue: {loading.Count}");
            Console.WriteLine($"Right Queue: {unloading.Count}");
            Console.WriteLine($"---");
        }
    }

}
