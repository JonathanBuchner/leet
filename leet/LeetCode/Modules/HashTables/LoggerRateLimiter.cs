using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.HashTables.LoggerRateLimiter
{
    /*
     * Logger Rate Limiter
     * 
     * Design a logger system that receives a stream of messages along with their timestamps. Each unique message should only be printed at most every 10 seconds (i.e. a message printed at timestamp t will prevent other identical messages from being printed until timestamp t + 10).
     * 
     * All messages will come in chronological order. Several messages may arrive at the same timestamp.
     * 
     * https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1122/
     */
    public class Logger
    {
        private Dictionary<int, int> dict;

        public Logger()
        {
            dict = new Dictionary<int, int>();
        }
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            var hash = message.GetHashCode();

            if(dict.ContainsKey(hash))
            {
                if (dict[hash] <= timestamp - 10)
                {
                    dict[hash] = timestamp;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                dict.Add(hash, timestamp);
                return true;
            }
        }
    }

    /**
     * Your Logger object will be instantiated and called as such:
     * Logger obj = new Logger();
     * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
     */
}
