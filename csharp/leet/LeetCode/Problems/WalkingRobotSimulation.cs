using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Walking Robot Simulation
 * 
 * https://leetcode.com/problems/walking-robot-simulation/editorial/?envType=daily-question&envId=2026-04-06
 */
namespace leet.LeetCode.Problems.WalkingRobotSimulation
{
    public class Solution
    {
        public class Robot
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double Max { get; set; }
            public Direction Dir { get; set; }

            public void TurnLeft()
            {
                switch (Dir)
                {
                    case Direction.NORTH:
                        Dir = Direction.WEST;
                        break;


                    case Direction.EAST:
                        Dir = Direction.NORTH;
                        break;


                    case Direction.SOUTH:
                        Dir = Direction.EAST;
                        break;


                    case Direction.WEST:
                        Dir = Direction.SOUTH;
                        break;

                    default:
                        throw new Exception($"Enum direction {Dir} not recognized.");
                }
            }

            public void TurnRight()
            {
                switch (Dir)
                {
                    case Direction.NORTH:
                        Dir = Direction.EAST;
                        break;


                    case Direction.EAST:
                        Dir = Direction.SOUTH;
                        break;


                    case Direction.SOUTH:
                        Dir = Direction.WEST;
                        break;


                    case Direction.WEST:
                        Dir = Direction.NORTH;
                        break;

                    default:
                        throw new Exception($"Enum direction {Dir} not recognized.");
                }
            }
        }

        public enum Direction
        {
            NORTH,
            EAST,
            SOUTH,
            WEST
        }

        public int RobotSim(int[] commands, int[][] obstacles)
        {
            var robot = Create();
            var obs_x = SetObstaclesX(obstacles);
            var obs_y = SetObstaclesY(obstacles);

            for (var i = 0; i < commands.Length; i++)
            {
                ProcessCommand(commands[i], robot, obs_x, obs_y);
                var curr_max = Math.Pow(robot.X, 2) + Math.Pow(robot.Y, 2);
                robot.Max = Math.Max(robot.Max, curr_max);
            }

            return (int)robot.Max;
        }

        public Robot Create()
        {
            return new Robot
            {
                X = 0,
                Y = 0,
                Dir = Direction.NORTH,
                Max = 0
            };
        }

        public IDictionary<int, SortedSet<int>> SetObstaclesX(int[][] obstacles)
        {
            var dict = new Dictionary<int, SortedSet<int>>();

            for (var i = 0; i < obstacles.Length; i++)
            {
                var x = obstacles[i][0];
                var y = obstacles[i][1];

                if (!dict.ContainsKey(x))
                {
                    dict.Add(x, new SortedSet<int>());
                }

                dict[x].Add(y);
            }

            return dict;
        }

        public IDictionary<int, SortedSet<int>> SetObstaclesY(int[][] obstacles)
        {
            var dict = new Dictionary<int, SortedSet<int>>();

            for (var i = 0; i < obstacles.Length; i++)
            {
                var x = obstacles[i][0];
                var y = obstacles[i][1];

                if (!dict.ContainsKey(y))
                {
                    dict.Add(y, new SortedSet<int>());
                }

                dict[y].Add(x);
            }

            return dict;
        }

        public void ProcessCommand(int command, Robot rob, IDictionary<int, SortedSet<int>> obs_x, IDictionary<int, SortedSet<int>> obs_y)
        {
            if (command == -2)
            {
                rob.TurnLeft();
            }
            else if (command == -1)
            {
                rob.TurnRight();
            }
            else if (command >= 1 && command <= 9)
            {
                MoveRobotForward(command, rob, obs_x, obs_y);
            }
            else
            {
                throw new Exception("Proccess command accepts -2, -1, 1-9");
            }
        }

        public void MoveRobotForward(int dist, Robot rob, IDictionary<int, SortedSet<int>> obs_x, IDictionary<int, SortedSet<int>> obs_y)
        {
            switch (rob.Dir)
            {
                case Direction.NORTH:
                    if (obs_x.ContainsKey(rob.X))
                    {
                        var sub_list = obs_x[rob.X].GetViewBetween(rob.Y + 1, rob.Y + dist);

                        if (sub_list.Count != 0)
                        {
                            dist = sub_list.Min - rob.Y - 1;
                        }
                    }
                    rob.Y += dist;


                    break;

                case Direction.EAST:
                    if (obs_y.ContainsKey(rob.Y))
                    {
                        var sub_list = obs_y[rob.Y].GetViewBetween(rob.X + 1, rob.X + dist);

                        if (sub_list.Count != 0)
                        {
                            dist = sub_list.Min - rob.X - 1;
                        }
                    }
                    rob.X += dist;

                    break;

                case Direction.SOUTH:
                    if (obs_x.ContainsKey(rob.X))
                    {
                        var sub_list = obs_x[rob.X].GetViewBetween(rob.Y - dist, rob.Y - 1);

                        if (sub_list.Count != 0)
                        {
                            dist = rob.Y - sub_list.Max - 1;
                        }
                    }
                    rob.Y -= dist;

                    break;

                case Direction.WEST:
                    if (obs_y.ContainsKey(rob.Y))
                    {
                        var sub_list = obs_y[rob.Y].GetViewBetween(rob.X - dist, rob.X - 1);

                        if (sub_list.Count != 0)
                        {
                            dist = rob.X - sub_list.Max - 1;
                        }
                    }
                    rob.X -= dist;

                    break;

                default:
                    throw new Exception($"Enum direction {rob.Dir} not recognized.");
            }
        }

    }
}
