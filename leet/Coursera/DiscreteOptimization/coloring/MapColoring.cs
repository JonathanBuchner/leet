using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.coloring
{
    public class MapColoring
    {
        private MapColoringProblem p;
        private MapColoringSolution s;

        public MapColoring Solve(MapColoringProblem problem)
        {
            p = problem;

            //Solutions
            Test();

            return this;
        }

        public MapColoring PrintProblem()
        {
            if(s == null)
            {
                throw new ArgumentException("No problem available to print");
            }

            Console.WriteLine($"{s.TotalColors} {s.IsOptimal}");
            var sb = new StringBuilder();

            foreach (var selected in s.Solution)
            {
                sb.Append(String.Concat(selected, " "));
            }

            Console.WriteLine(sb.ToString());

            return this;
        }

        private void Test()
        {
            var eg = new int[p.TotalNodes];

            for(var i = 0; i < eg.Length; ++i)
            {
                eg[i] = i + 1;
            }

            s = new MapColoringSolution(p.TotalNodes, 0, eg);
        }
    }
}
