using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 2069. Walking Robot Simulation II
 * 
 * https://leetcode.com/problems/walking-robot-simulation-ii/description/?envType=daily-question&envId=2026-04-07
 */

namespace leet.LeetCode.Problems.WalkingRobotSimulationII
{
    public class Robot
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Direction dir;
        private int mod;


        public Robot(int width, int height)
        {
            this.width = width - 1;
            this.height = height - 1;
            dir = Direction.East;
            x = 0;
            y = 0;
            mod = GetMod(width, height);
        }

        private int GetMod(int width, int height)
        {
            return (width - 1) * 2 + (height - 1) * 2;
        }

        public void Step(int num)
        {
            num = ModNum(num);
            while (num > 0)
            {
                switch(dir) 
                {
                    case Direction.North:
                        y += num;
                        num = 0;
                        if (y > height)
                        {
                            num += y - height;
                            y = height;
                            dir = Direction.West;
                        }
                        break;

                    case Direction.East:
                        x += num;
                        num = 0;
                        if (x > width)
                        {
                            num += x - width;
                            x = width;
                            dir = Direction.North;
                        }
                        break;


                    case Direction.South:
                        y -= num;
                        num = 0;
                        if (y < 0)
                        {
                            num += Math.Abs(y);
                            y = 0;
                            dir = Direction.East;
                        }
                        break;

                    case Direction.West:
                        x -= num;
                        num = 0;
                        if (x < 0)
                        {
                            num += Math.Abs(x);
                            x = 0;
                            dir = Direction.South;
                        }
                        break;

                    default:
                        throw new NotSupportedException($"Direction {dir} is not supported.");
                }
            }
        }

        public int[] GetPos()
        {
            return new int[] { x, y };
        }

        public string GetDir()
        {
            return dir.ToString();
        }

        public enum Direction
        {
            North, East, South, West
        }

        private int ModNum(int num)
        {
            num = num % mod;

            if (num == 0)
            {
                switch (dir)
                {
                    case Direction.North:
                        dir = Direction.East;
                        break;

                    case Direction.East:
                        dir = Direction.South;
                        break;

                    case Direction.South:
                        dir = Direction.West;
                        break;

                    case Direction.West:
                        dir = Direction.North;
                        break;

                    default:
                        throw new NotSupportedException($"Direction {dir} is not supported.");
                }
            }

            return num;
        }
    }

    /**
     * Your Robot object will be instantiated and called as such:
     * Robot obj = new Robot(width, height);
     * obj.Step(num);
     * int[] param_2 = obj.GetPos();
     * string param_3 = obj.GetDir();
     */
}
