using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.KillProcess
{
    /**
     * 582. Kill Process
     * 
     * https://leetcode.com/problems/kill-process/
     */
    public class Solution
    {
        public class Process
        {
            public IList<Process> Children { get; set; }
            public int Pid { get; }
            public int Ppid { get; }

            public Process(int pid, int ppid)
            {
                Pid = pid;
                Ppid = ppid;
                Children = new List<Process>();
            }
        }

        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var dict = new Dictionary<int, Process>();
            dict.Add(0, new Process(0, -1)); 
            
            // Create a process node for each entry and add to dictionary
            for (var i = 0; i < pid.Count; i++)
            {
                var new_process = new Process(pid[i], ppid[i]);
                dict.Add(pid[i], new_process);
            }

            // Connect children to parents; i.e. set Children list
            for (var i = 0; i < pid.Count; i++)
            {
                var child = dict[pid[i]];
                var parent = dict[ppid[i]];
                parent.Children.Add(child);
            }

            // Ready killing off children
            var result = new List<int>();        
            var queue = new Queue<Process>();

            var victum = dict[kill];
            queue.Enqueue(victum);

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                result.Add(curr.Pid);
                
                for (var i = 0; i < curr.Children.Count; i++)
                {
                    queue.Enqueue(curr.Children[i]);
                }
            }

            return result;
        }
    }
}
