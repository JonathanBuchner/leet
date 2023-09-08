using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.coloring
{
    public class MapColoringProblem
    {
        public int TotalNodes { get; }
        public int TotalEdges { get; }
        public List<int[]> Edges { get; }

        public MapColoringProblem(int totalNodes, int totalEdges, List<int[]> edges)
        {
            TotalNodes = totalNodes;
            TotalEdges = totalEdges;
            Edges = edges;
        }
    }
}
