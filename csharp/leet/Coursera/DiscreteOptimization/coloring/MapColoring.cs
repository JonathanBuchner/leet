using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.coloring
{
    public class MapColoring
    {
        private MapColoringProblem p;
        private MapColoringSolution s;

        public MapColoring Solve(MapColoringProblem problem)
        {
            p = problem;

            //Solutions
            //Test();
            LogicalSolution();


            return this;
        }

        public MapColoring PrintProblem()
        {
            if (s == null)
            {
                throw new ArgumentException("No problem available to print");
            }

            Console.WriteLine($"{s.TotalColors} {s.IsOptimal}");
            var sb = new StringBuilder();

            foreach (var selected in s.Solution)
            {
                sb.Append(String.Concat(selected, " "));
            }

            Console.WriteLine(sb.ToString());

            return this;
        }

        private void Test()
        {
            var eg = new int[p.TotalNodes];

            for (var i = 0; i < eg.Length; ++i)
            {
                eg[i] = i + 1;
            }

            s = new MapColoringSolution(p.TotalNodes, 0, eg);
        }

        private void LogicalSolution()
        {
            var node = new Node[p.TotalNodes];
            var sortedDict = new SortedDictionary<int, List<Node>>();

            for(var i = 0; i < node.Length; ++i)
            {
                node[i] = new Node();
            }

            for(var i = 0; i < p.Edges.Count; ++i)
            {
                var left = p.Edges[i][0];
                var right = p.Edges[i][1];

                node[left].Edges.Add(node[right]);
                node[right].Edges.Add(node[left]);
            }

            for(var i = 0; i < node.Length; ++i)
            {
                var count = node[i].Edges.Count;
                if (sortedDict.ContainsKey(count))
                {
                    sortedDict[count].Add(node[i]);
                }
                else
                {
                    sortedDict.Add(count, new List<Node>() { node[i] });
                }
            }

            var totalColors = 0;

            foreach(var edgeset in sortedDict)
            {
                var lists = edgeset.Value;

                for(var i = 0; i < lists.Count; ++i)
                {
                    var n = lists[i];
                    var color = 0;
                    
                    while(true)
                    {
                        var cando = true;

                        for(var k = 0; k < n.Edges.Count; ++k)
                        {
                            if(color == n.Edges[k].Color)
                            {
                                cando = false;
                            }
                        }

                        if(!cando)
                        {
                            ++color;
                        }
                        else
                        {
                            n.Color = color;
                            totalColors = Math.Max(totalColors, color + 1);
                            break;
                        }  
                    }
                }
            }

            var solution = new int[node.Length];

            for(var i = 0; i < solution.Length; i++)
            {
                solution[i] = node[i].Color;
            }

            s = new MapColoringSolution(totalColors, 0, solution);
        }

        public class Node
        {
            public int Color { get; set; } = -1;
            public List<Node> Edges { get; set; } = new List<Node>();
        }
    }
}
