using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.RobotCollisions
{
    public class Solution
    {
        public class Robot
        {
            public int Position { get; }
            public int Health { get; set; }
            public char Direction { get; }
            public int Original_position { get;  }
            
            public Robot(int position, int health, char direction, int original_position)
            {
                this.Position = position;
                this.Health = health;
                this.Direction = direction;
                this.Original_position = original_position;
            }
        }


        public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {
            var arr = GetRobotsArray(positions, healths, directions);
            ProcessRobots(arr);

            return GetResult(arr);
        }

        private Robot[] GetRobotsArray(int[] positions, int[] healths, string directions)
        {
            var result = new List<Robot>();

            for (var i = 0; i < positions.Length; i++)
            {
                result.Add(new Robot(positions[i], healths[i], directions[i], i));
            }

            result.Sort((x, y) => x.Position.CompareTo(y.Position));

            return result.ToArray();
        }

        private void ProcessRobots(Robot[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i].Direction == 'L')
                {
                    for (var k = i - 1; k >= 0; k--)
                    {
                        if (arr[k] != null && arr[k].Direction == 'R')
                        {
                            if (arr[k].Health == arr[i].Health)
                            {
                                arr[k] = null;
                                arr[i] = null;
                                break;
                            }
                            else if (arr[k].Health > arr[i].Health)
                            {
                                arr[k].Health--;
                                arr[i] = null;
                                break;
                            }
                            else
                            {
                                arr[k] = null;
                                arr[i].Health--;
                            }

                        }
                    }
                }
            }
        }

        private IList<int> GetResult(Robot[] arr)
        {
            var list = arr.ToList();
            list.RemoveAll(a => a == null);
            list.Sort((a, b) => a.Original_position.CompareTo(b.Original_position));
            List<int> result = list.Select(item => item.Health).ToList();

            return result;
        }
    }
}
