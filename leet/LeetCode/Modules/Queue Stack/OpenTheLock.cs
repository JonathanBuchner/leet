using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Queue_Stack.OpenTheLock
{
    /*
    * Open the Lock
    * 
    * You have a lock in front of you with 4 circular wheels. Each wheel has 10 slots: '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'. The wheels can rotate freely and wrap around: for example we can turn '9' to be '0', or '0' to be '9'. Each move consists of turning one wheel one slot.
    *
    * https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1375/
    */
    public class Solution
    {
        public int OpenLock(string[] deadends, string target)
        {
            var queue = new Queue<string>();
            var ends = new HashSet<string>();
            ends.Add("0000");
            queue.Enqueue("00000");

            foreach(var end in deadends)
            {
                ends.Add(end);
            }

            while(queue.Count > 0)
            {
                var num = queue.Dequeue();
                var wheels = num.Substring(num.Length - 4, 4);
                var count = Int32.Parse(num.Substring(0, num.Length - 4));

                if(wheels == target)
                {
                    return count;
                }
                
                var i = 0;
                count++;

                while(i < wheels.Length)
                {
                    var k = -1;
                    while(k < 2)
                    {
                        var wheel = ((wheels[i] - '0') + k + 10) % 10;
                        var newWheel = String.Concat(wheels.Substring(0,i), wheel.ToString(), wheels.Substring(i+1));
                        k += 2;
                    }

                    i++;
                }
            }

            return -1;
        }
    }
}
