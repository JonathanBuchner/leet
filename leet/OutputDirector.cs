using leet.Coursera.DiscreteOptimization.anyint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet
{
    public static class OutputDirector
    {
        public static string[] problems = new string[]
        {
            "anyInt"
        };
        public static string GetProblem(string inLineProblem, string[] args)
        {
            if (args.Length > 0)
            { 
                foreach (var prob in problems)
                {
                    if (args[0] == prob)
                    {
                        return args[0];
                    }
                }
                
                throw new ArgumentException($"{args[0]} does not match a problem on the list.");
            }
            else
            {
                return inLineProblem;
            }
        }

        public static void RunProblem(this string problem)
        {
            switch(problem)
            {
                case "anyInt":
                    
                    new AnyInt();
                    break;

                default:
                    throw new ArgumentException($"Cannot run {problem}.  It was not found on the list.");
                    
            }
        }
    }
}
