using leet.Coursera.DiscreteOptimization.anyint;
using leet.Coursera.DiscreteOptimization.knapsack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet
{
    public static class OutputDirector
    {
        public static string[] problems = new string[]
        {
            "AnyInt",
            "Knapsack"
        };
        public static string GetProblemFiles(string filePath, string[] args)
        {
            if (args.Length > 0)
            { 
                if(!File.Exists(filePath))
                {
                    throw new ArgumentException($"Cannot finde file {filePath}");
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

                    new Knapsack(filePath).Solve();
                    break;

                default:
                    throw new ArgumentException($"Cannot run {problem}.  It was not found on the list.");
                    
            }
        }
    }
}
