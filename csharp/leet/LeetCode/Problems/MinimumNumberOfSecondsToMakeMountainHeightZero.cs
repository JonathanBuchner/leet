using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumNumberOfSecondsToMakeMountainHeightZero
{
    public class Solution
    {
        private class Worker
        {
            public int Speed { get; }
            public int Blocks { get; set; }
            public long CurrentSeconds { get; set; }

            public Worker(int speed)
            {
                Speed = speed;
                Blocks = 0;
                CurrentSeconds = 0;
            }
           
            public long GetNextSeconds()
            {
                return CurrentSeconds + (long) Speed * (long) (Blocks + 1);
            }

        }
        public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
        {
            var workingQueue = SeedQueue(workerTimes);

            // Choose a worker for each section
            for (var i = 0; i < mountainHeight; i++)
            {
                var worker = workingQueue.Dequeue();
                worker.CurrentSeconds = worker.GetNextSeconds();
                worker.Blocks++;
                workingQueue.Enqueue(worker, worker.GetNextSeconds());
            }

            long largest = 0;
            while (workingQueue.Count != 0)
            {
                largest = Math.Max(largest, workingQueue.Dequeue().CurrentSeconds);
            }

            return largest;
        }

        private PriorityQueue<Worker, long> SeedQueue(int[] workerTimes)
        {
            var queue = new PriorityQueue<Worker, long>();

            for (var i = 0; i < workerTimes.Length; i++)
            {
                var worker = new Worker(workerTimes[i]);
                queue.Enqueue(worker, worker.GetNextSeconds());
            }

            return queue;
        }
    }
}
