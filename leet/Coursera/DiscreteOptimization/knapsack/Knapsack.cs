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

            //Greedy(problem);
            DynamicProgramming(Problem);

            return this;
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

        private void Greedy(KnapsackProblem p)
        {
            // Effeciency, weight, position
            var effecientItemList = new List<int[]>();

            for (var i = 0; i < p.Items.Count; ++i)
            {
                effecientItemList.Add(new int[] { p.Items[i][0], p.Items[i][1], i });
            }

            effecientItemList.Sort((a, b) => ((double)b[0] / b[1]).CompareTo((double)a[0] / a[1]));

            var weight = 0;

            for (var i = 0; i < effecientItemList.Count; ++i)
            {
                if (weight + effecientItemList[i][1] <= p.Weight)
                {
                    weight += effecientItemList[i][1];
                    p.Value += effecientItemList[i][0];
                    p.Selected[effecientItemList[i][2]] = 1;
                }
            }

            p.IsOptimal = 0;
        }

        private void DynamicProgramming(KnapsackProblem p)
        {
            var dp = new int[p.Weight + 1][];

            // Create table
            for(var i = 0; i < dp.Length; ++i)
            {
                dp[i] = new int[p.Items.Count + 1];
            }
         
            // Fill out table
            for(var col = 1; col < dp[0].Length; ++col)
            {
                for(var row = 1; row < dp.Length; ++row)
                {
                    var value = p.Items[col-1][0];
                    var weight = p.Items[col-1][1];
                    var valueIfNotIncluded = dp[row][col - 1];

                    if (weight <= row)
                    {
                        var valueIfItemIncluded = dp[row - weight][col - 1] + value;
                        dp[row][col] = Math.Max(valueIfNotIncluded, valueIfItemIncluded);
                    }
                    else
                    {
                        dp[row][col] = valueIfNotIncluded;
                    }

                }
            }

            // Trace back
            var r = dp.Length - 1;
            var c = dp[r].Length - 1;
            var v = 0;

            while(c > 0)
            {
                if(dp[r][c] == dp[r][c - 1])
                {
                    p.Selected[c - 1] = 0;
                }
                else
                {
                    p.Selected[c - 1] = 1;
                    r -= p.Items[c - 1][1];
                    v += p.Items[c - 1][0];
                }

                --c;
            }

            p.IsOptimal = 1;
            p.Value = v;
        }
    }
}
