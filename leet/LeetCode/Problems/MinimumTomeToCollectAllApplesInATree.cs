using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MinimumTomeToCollectAllApplesInATree
{
    /*
     * Minimum Time to Collect All Apples in a Tree
     * 
     * Given an undirected tree consisting of n vertices numbered from 0 to n-1, which has some apples in their vertices. You spend 1 second to walk over one edge of the tree. Return the minimum time in seconds you have to spend to collect all apples in the tree, starting at vertex 0 and coming back to this vertex.
     * 
     * The edges of the undirected tree are given in the array edges, where edges[i] = [ai, bi] means that exists an edge connecting the vertices ai and bi. Additionally, there is a boolean array hasApple, where hasApple[i] = true means that vertex i has an apple; otherwise, it does not have any apple.
     * 
     * https://leetcode.com/problems/minimum-time-to-collect-all-apples-in-a-tree/description/
     */
    public class Node
    {
        public int Current { get; set; }
        public int Parent { get; set; }
        public bool Visited { get; set; }

        public Node(int current, int parent, bool visited)
        {
            Current = current;
            Parent = parent;
            Visited = visited;
        }
    }

    public class Solution
    {
        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            var dict = new Dictionary<int, Node>();
            var count = 0;
            dict.Add(0, new Node(0, -1, false));

            for (var i = 0; i < edges.Length; i++)
            {
                if (!dict.ContainsKey(edges[i][1]))
                {
                    dict.Add(edges[i][1], new Node(edges[i][1], edges[i][0], false));
                }
                else
                {
                    dict.Add(edges[i][0], new Node(edges[i][0], edges[i][1], false));
                }
            }

            for (var i = 1; i < hasApple.Count; i++)
            {
                if (hasApple[i])
                {
                    var k = dict[i];

                    while (k.Visited == false)
                    {
                        count++;
                        k.Visited = true;

                        if (k.Parent == 0)
                        {
                            break;
                        }
                        k = dict[k.Parent];
                    }
                }
            }

            return count * 2;
        }
    }
}
