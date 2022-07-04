using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.knapsack
{
    public class Knapsack
    {
        private List<int[]> inputs; 
        public Knapsack(string filePath)
        {
            inputs = ProblemArgumentReader.ReadInts(filePath);
        }

        public void Solve()
        {
            foreach (var item in inputs)
            {
                Console.WriteLine(item[0]);
            }
        }
    }
}
