using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RobotReturnToOrigin
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;

            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'L':
                        y--;
                        break;
                    case 'R':
                        y++;
                        break;
                    case 'U':
                        x--;
                        break;
                    case 'D':
                        x++;
                        break;
                }
            }

            if (x == 0 && y == 0) return true;

            return false;
        }
    }
}
