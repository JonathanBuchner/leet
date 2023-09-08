using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Modules.Queue_Stack.PerfectSquares
{
    public class Solution
    {
        public int NumSquares(int n)
        {
            var possibleSquare = new List<int>();

            for (int i = 0; i * i <= n; i++)
            {
                var square = i * i;
                if(n == square)
                {
                    return 1;
                }
                possibleSquare.Add(square);
            }

            var set = new HashSet<int>();
            set.Add(n);
            var level = 0;

            while (set.Count  > 0)
            {
                level++;
                var nextSet = new HashSet<int>();

                foreach(var num in set)
                {
                    foreach(var square in possibleSquare)
                    {
                        var total = num - square;
                        
                        if(total == 0)
                        {
                            return level;
                        }
                        else if(total > 0 && !set.Contains(total))
                        {
                            nextSet.Add(total);
                        }
                    }
                }

                set = nextSet;
            }

            throw new InvalidOperationException("Because 1 is a perfect square, every integer can be reached by adding one equal to the integer.  This excepction should not be reached");

        }
    }
}
