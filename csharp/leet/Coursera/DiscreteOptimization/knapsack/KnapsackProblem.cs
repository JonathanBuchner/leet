using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.knapsack
{
    public class KnapsackProblem
    {
        public Int64 Value { get; set; }
        public short IsOptimal { get; set; }
        public int[] Selected { get; set; }
        //value, weight
        public List<int[]> Items { get;}
        public int Weight { get; }

        public KnapsackProblem(List<int[]> inputs, int weight)
        {
            this.Items = inputs;
            this.Weight = weight;
            Value = 0;
            IsOptimal = 0;
            Selected = new int[inputs.Count];
        }
    }
}
