using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.ProblemsDesign.DesignHitCounter
{
    public class HitCounter
    {
        private Queue<int> queue;

        public HitCounter()
        {
            queue = new Queue<int>();
        }

        public void Hit(int timestamp)
        {
            queue.Enqueue(timestamp);
        }

        public int GetHits(int timestamp)
        {
            while (true)
            {
                int currTime;

                var result = queue.TryPeek(out currTime);

                if (result == false)
                {
                    return 0;
                }

                if (currTime + 300 > timestamp)
                {
                    return queue.Count;
                }

                queue.Dequeue(); 
            }
        }
    }
}
