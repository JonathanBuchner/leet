using System;

namespace leet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var problem = "AnyInt";

            OutputDirector
                .GetProblem(problem, args)
                .RunProblem();
            
        }
    }
}
