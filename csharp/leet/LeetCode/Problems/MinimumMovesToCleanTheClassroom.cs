using System;
using System.Collections.Generic;

/**
 * 3568. Minimum Moves to Clean the Classroom
 * 
 * https://leetcode.com/problems/minimum-moves-to-clean-the-classroom/description/?envType=daily-question&envId=2026-09-01
 */

namespace leet.LeetCode.Problems.MinimumMovesToCleanTheClassroom
{
    public class Solution
    {
        private readonly char StartingPosition = 'S';
        private readonly char Litter = 'L';
        private readonly char Reset = 'R';
        private readonly char Obstacal = 'X';

        public int MinMoves(string[] classroom, int energy)
        {
            var litterLocations = GetLitterLocations(classroom);
            var start = FindStart(classroom);

            if (start.Item1 == -1 || start.Item2 == -1)
            {
                return -1;
            }

            if (litterLocations.Count == 0)
            {
                return 0;
            }

            return CleanUp(classroom, energy, start, litterLocations);
        }

        private (int, int) FindStart(string[] classroom)
        {
            for (var i = 0; i < classroom.Length; i++)
            {
                for (var k = 0; k < classroom[i].Length; k++)
                {
                    if (classroom[i][k] == StartingPosition)
                    {
                        return (i, k);
                    }
                }
            }

            return (-1, -1);
        }

        private Dictionary<(int, int), int> GetLitterLocations(string[] classroom)
        {
            var litterLocations = new Dictionary<(int, int), int>();
            var litterIndex = 0;

            for (var i = 0; i < classroom.Length; i++)
            {
                for (var k = 0; k < classroom[i].Length; k++)
                {
                    if (classroom[i][k] == Litter)
                    {
                        litterLocations[(i, k)] = litterIndex;
                        litterIndex++;
                    }
                }
            }

            return litterLocations;
        }

        private int CleanUp(
            string[] classroom,
            int energy,
            (int, int) start,
            Dictionary<(int, int), int> litterLocations)
        {
            var queue = new Queue<Pos>();

            var visited = new Dictionary<(int, int, int), int>();

            var allLitterMask = (1 << litterLocations.Count) - 1;

            queue.Enqueue(new Pos(
                start.Item1,
                start.Item2,
                0,
                energy));

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                var squareChar = classroom[item.X][item.Y];

                if (squareChar == Obstacal)
                {
                    continue;
                }

                if (item.Energy < 0)
                {
                    continue;
                }

                if (squareChar == Reset)
                {
                    item.Energy = energy;
                }

                if (squareChar == Litter)
                {
                    var litterIndex = litterLocations[(item.X, item.Y)];

                    item.LitterMask =
                        item.LitterMask | (1 << litterIndex);

                    if (item.LitterMask == allLitterMask)
                    {
                        return item.Steps;
                    }
                }

                var state =
                    (item.X, item.Y, item.LitterMask);

                if (visited.ContainsKey(state) &&
                    visited[state] >= item.Energy)
                {
                    continue;
                }

                visited[state] = item.Energy;

                AddSquaresToQueue(queue, item, classroom);
            }

            return -1;
        }

        private void AddSquaresToQueue(
            Queue<Pos> queue,
            Pos pos,
            string[] classroom)
        {
            if (pos.X - 1 >= 0)
            {
                var nPos =
                    pos.GetCopyAndIncreaseStepsDecreaseEnergy();

                nPos.X--;
                queue.Enqueue(nPos);
            }

            if (pos.X + 1 < classroom.Length)
            {
                var nPos =
                    pos.GetCopyAndIncreaseStepsDecreaseEnergy();

                nPos.X++;
                queue.Enqueue(nPos);
            }

            if (pos.Y - 1 >= 0)
            {
                var nPos =
                    pos.GetCopyAndIncreaseStepsDecreaseEnergy();

                nPos.Y--;
                queue.Enqueue(nPos);
            }

            if (pos.Y + 1 < classroom[0].Length)
            {
                var nPos =
                    pos.GetCopyAndIncreaseStepsDecreaseEnergy();

                nPos.Y++;
                queue.Enqueue(nPos);
            }
        }

        class Pos
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int LitterMask { get; set; }
            public int Steps { get; set; }
            public int Energy { get; set; }

            public Pos(
                int x,
                int y,
                int litterMask,
                int energy)
            {
                X = x;
                Y = y;
                LitterMask = litterMask;
                Energy = energy;
                Steps = 0;
            }

            public Pos(
                int x,
                int y,
                int litterMask,
                int energy,
                int steps)
                : this(x, y, litterMask, energy)
            {
                Steps = steps;
            }

            public Pos GetCopyAndIncreaseStepsDecreaseEnergy()
            {
                return new Pos(
                    X,
                    Y,
                    LitterMask,
                    Energy - 1,
                    Steps + 1);
            }
        }
    }
}

