using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.coloring
{
    public class MapColoringSolution
    {
        public int TotalColors { get;}
        public int IsOptimal { get;}
        public int[] Solution { get; }

        public MapColoringSolution(int totalColors, int isOptimal, int[] solution)
        {
            TotalColors = totalColors;
            IsOptimal = isOptimal;
            Solution = solution;
        }
    }
}
