using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.JumpGame4
{
    /**
     * Jump Game IV
     * 
     * https://leetcode.com/problems/jump-game-iv/
     */
    public class Solution
    {
        public class Node
        {
            public int Index { get; set; }
            public int Steps { get; set; }
            public Node(int index, int steps)
            {
                Index = index;
                Steps = steps;
            }
        }
        public int MinJumps(int[] arr)
        {
            var dict = GetDictionary(arr);
            var goal = arr.Length - 1;
            var curr = new Node(0, 0);
            var queue = new Queue<Node>();
            var set = new HashSet<int>();
            AddMissingToQueue(curr.Index, curr.Steps, queue, set);

            while (curr.Index != goal)
            {
                if (queue.Count == 0)
                    throw new ArgumentException("No solution give the array");

                curr = queue.Dequeue();

                if (curr.Index != 0)
                    AddMissingToQueue(curr.Index - 1, curr.Steps + 1, queue, set);

                if (curr.Index != arr.Length - 1)
                    AddMissingToQueue(curr.Index + 1, curr.Steps + 1, queue, set);

                if (dict.ContainsKey(arr[curr.Index]))
                {
                    for (var i = dict[arr[curr.Index]].Count - 1; i >= 0; i--)
                        AddMissingToQueue(dict[arr[curr.Index]][i], curr.Steps + 1, queue, set);

                    dict.Remove(arr[curr.Index]);
                }
            }

            return curr.Steps;
        }

        private Dictionary<int, List<int>> GetDictionary(int[] arr)
        {
            var dict = new Dictionary<int, List<int>>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], new List<int>());

                dict[arr[i]].Add(i);
            }

            return dict;
        }

        private void AddMissingToQueue(int index, int steps, Queue<Node> queue, HashSet<int> set)
        {
            if (!set.Contains(index))
            {
                queue.Enqueue(new Node(index, steps));
                set.Add(index);
            }
        }
    }
}
