using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.knapsack
{
    public class Knapsack
    {
        public KnapsackProblem Problem { get; set; }

        public Knapsack Solve(List<int[]> inputs, int weight)
        {
            Problem = new KnapsackProblem(inputs, weight);

            Greedy(Problem);

            return this;
        }

        private void Greedy(KnapsackProblem problem)
        {
            // Effeciency, weight, position
            var effecientItemList = new List<int[]>();

            for (var i = 0; i < problem.Items.Count; ++i)
            {
                effecientItemList.Add(new int[] {problem.Items[i][0], problem.Items[i][1], i });
            }

            effecientItemList.Sort((a, b) => ((double)b[0]/b[1]).CompareTo((double) a[0]/a[1]));

            var weight = 0;
            
            for (var i = 0; i < effecientItemList.Count; ++i)
            {
                if (weight + effecientItemList[i][1] <= problem.Weight)
                {
                    weight += effecientItemList[i][1];
                    problem.Value += effecientItemList[i][0];
                    problem.Selected[effecientItemList[i][2]] = 1;
                }
            }

            problem.IsOptimal = 0;
        }

        public Knapsack PrintProblem()
        {
            Console.WriteLine($"{Problem.Value} {Problem.IsOptimal}");
            var sb = new StringBuilder();

            foreach(var selected in Problem.Selected)
            {
                sb.Append(String.Concat(selected, " "));
            }

            Console.WriteLine(sb.ToString());

            return this;
        }
    }
}
