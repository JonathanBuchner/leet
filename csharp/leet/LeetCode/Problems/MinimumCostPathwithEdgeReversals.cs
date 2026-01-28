using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumCostPathwithEdgeReversals
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-path-with-edge-reversals/description/?envType=daily-question&envId=2026-01-27
    /// You are given a directed, weighted graph with n nodes labeled from 0 to n - 1, and an array edges where edges[i] = [ui, vi, wi] represents a directed edge from node ui to node vi with cost wi
    /// 
    /// Each node ui has a switch that can be used at most once: when you arrive at ui and have not yet used its switch, you may activate it on one of its incoming edges vi → ui reverse that edge to ui → vi and immediately traverse it
    /// 
    /// The reversal is only valid for that single move, and using a reversed edge costs 2 * wi
    /// 
    /// Return the minimum total cost to travel from node 0 to node n - 1. If it is not possible, return -1.
    /// 
    /// </summary>
    public class Solution
    {
        public int MinCost(int n, int[][] edges)
        {
            var list = new List<IList<int>>();

            for (var i = 0; i < edges.Length; i++)
            {
                list.Add(edges[i].ToList());
                list.Add(new List<int>() {
                    edges[i][1],
                    edges[i][0],
                    edges[i][2] * 2
                });
            }

            var frontier = new PriorityQueue<IList<int>, int>();
            foreach (var item in list)
            {
                if (item[0] == 0)
                {
                    frontier.Enqueue(item, item[2]);
                }
            }

            list.RemoveAll(i => i[0] == 0);

            while (frontier.Count != 0)
            {
                var curr = frontier.Dequeue();
                
                if (curr[1] == n-1)
                {
                    return curr[2];
                }

                foreach (var item in list)
                {
                    if (curr[1] == item[0])
                    {
                        item[2] += curr[2];
                        frontier.Enqueue(item, item[2]);
                    }
                }

                list.RemoveAll(i => i[0] == curr[1]);
            }

            return -1;
        }
    }
}
