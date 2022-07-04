using System;
using leet.Coursera.DiscreteOptimization;

namespace leet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var problem = "Knapsack";
            var path = "../../../Coursera/DiscreteOptimization/knapsack/tmp.data";


            OutputDirector
                .GetProblemFiles(path, args)
                .RunProblem(problem);

        }
    }
}
