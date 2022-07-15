using leet.Coursera.DiscreteOptimization.anyint;
using leet.Coursera.DiscreteOptimization.knapsack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.Coursera.DiscreteOptimization;
using leet.Coursera.DiscreteOptimization.coloring;

namespace leet
{
    public static class OutputDirector
    {
        public static string[] problems = new string[]
        {
            "AnyInt",
            "Knapsack",
            "Coloring",
        };
        public static string GetProblemFiles(string filePath, string[] args)
        {
            if (args.Length > 0)
            { 
                if(!File.Exists(args[0]))
                {
                    throw new ArgumentException($"Cannot find file {args[0]}.");
                }

                return args [0];

            }
            else
            {
                return filePath;
            }
        }

        public static void RunProblem(this string filePath, string problem)
        {
            if (!problems.Contains(problem))
            {
                throw new ArgumentException($"Cannot find problem named {problem}");
            }

            switch(problem)
            {
                case "AnyInt":
                    
                    new AnyInt();
                    break;

                case "Knapsack":

                    var input_items = ProblemArgumentReader.ReadInts(filePath);
                    var weight = input_items[0][1];
                    input_items.RemoveRange(0, 1);
                    new Knapsack().Solve(input_items, weight).PrintProblem();
                    break;

                case "Coloring":

                    var graph = ProblemArgumentReader.ReadInts(filePath);
                    var nodes = graph[0][0];
                    var edges = graph[0][1];
                    graph.RemoveRange(0, 1);
                    var mapColoringProblem = new MapColoringProblem(nodes, edges, graph); 
                    new MapColoring().Solve(mapColoringProblem).PrintProblem();
                    break;

                default:
                    throw new ArgumentException($"Cannot run {problem}.  It was not found on the list.");
                    
            }
        }
    }
}
