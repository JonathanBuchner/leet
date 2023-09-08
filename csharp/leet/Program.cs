using System;
using leet.Coursera.DiscreteOptimization;

namespace leet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var problem = "Coloring";
            var path = "../../../Coursera/DiscreteOptimization/coloring/tmp.data";

            OutputDirector
                .GetProblemFiles(path, args)
                .RunProblem(problem);
        }
    }
}
