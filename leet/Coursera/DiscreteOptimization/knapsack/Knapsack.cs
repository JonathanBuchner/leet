using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization.knapsack
{
    public class Knapsack
    {
        public KnapsackProblem P { get; set; }

        public Knapsack Solve(List<int[]> inputs, int weight)
        {
            P = new KnapsackProblem(inputs, weight);

            //Greedy(problem);
            //DynamicProgramming();
            DepthFirstBranchAndBound();

            return this;
        }

        public Knapsack PrintProblem()
        {
            Console.WriteLine($"{P.Value} {P.IsOptimal}");
            var sb = new StringBuilder();

            foreach(var selected in P.Selected)
            {
                sb.Append(String.Concat(selected, " "));
            }

            Console.WriteLine(sb.ToString());

            return this;
        }

        private void Greedy()
        {
            // Effeciency, weight, position
            var effecientItemList = new List<int[]>();

            for (var i = 0; i < P.Items.Count; ++i)
            {
                effecientItemList.Add(new int[] { P.Items[i][0], P.Items[i][1], i });
            }

            effecientItemList.Sort((a, b) => ((double)b[0] / b[1]).CompareTo((double)a[0] / a[1]));

            var weight = 0;

            for (var i = 0; i < effecientItemList.Count; ++i)
            {
                if (weight + effecientItemList[i][1] <= P.Weight)
                {
                    weight += effecientItemList[i][1];
                    P.Value += effecientItemList[i][0];
                    P.Selected[effecientItemList[i][2]] = 1;
                }
            }

            P.IsOptimal = 0;
        }

        private void DynamicProgramming()
        {
            var dp = new int[P.Weight + 1][];

            // Create table
            for(var i = 0; i < dp.Length; ++i)
            {
                dp[i] = new int[P.Items.Count + 1];
            }
         
            // Fill out table
            for(var col = 1; col < dp[0].Length; ++col)
            {
                for(var row = 1; row < dp.Length; ++row)
                {
                    var value = P.Items[col-1][0];
                    var weight = P.Items[col-1][1];
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
                    P.Selected[c - 1] = 0;
                }
                else
                {
                    P.Selected[c - 1] = 1;
                    r -= P.Items[c - 1][1];
                    v += P.Items[c - 1][0];
                }

                --c;
            }

            P.IsOptimal = 1;
            P.Value = v;
        }

        private void DepthFirstBranchAndBound()
        {
            // Sort
            var eList = new List<int[]>();
            //value, weight, index

            for (var i = 0; i < P.Items.Count; ++i)
            {
                eList.Add(new int[] { P.Items[i][0], P.Items[i][1], i });
            }

            eList.Sort((a, b) => ((double)b[0] / b[1]).CompareTo((double)a[0] / a[1]));
            var estimate = GetEstimate(eList, 0, P.Weight);
            var list = new List<int>() { 0 , P.Weight }; // First item on list is the list value

            var solution = Branch(list, eList, 0);

            P.IsOptimal = 1;
            P.Value = solution[0];
            for(var i = 2; i < solution.Count; ++i )
            {
                P.Selected[solution[i]] = 1;
            }
        }

        private int DFBCurrentBest = 0;
        // List
        // - First item is value
        // - Second itme is remainingWeight
        // Then a list of chosen indexs
        // Elist is items sorted by effeciency
        // e is the current index in the eList

        private List<int> Branch(List<int> list, List<int[]> eList, int e)
        {
            
            if(e >= eList.Count)
            {
                return list;
            }

            var estimate = GetEstimate(eList, e, list[1]);

            var left = new List<int>() { 0 };
            // Add item
            if( 
                e + 1 < eList.Count &&
                list[1] - eList[e][1] >= 0 &&
                list[0] + estimate > DFBCurrentBest
              ) 
            {
                var copiedList = new List<int>();

                for (var i = 0; i < list.Count; ++i)
                {
                    copiedList.Add(list[i]);
                }
                copiedList[0] += eList[e][0];  // Add value
                copiedList[1] -= eList[e][1];  // Add weight
                copiedList.Add(eList[e][2]);              // Add index
                DFBCurrentBest = Math.Max(DFBCurrentBest, copiedList[0]);
                left = Branch(copiedList, eList, e + 1);
            }

            // No Add
            var right = Branch(list, eList, e + 1);

            return left[0] > right[0] ? left : right; 
        }

        private int GetEstimate(List<int[]> eList, int start, int remainingWeight)
        {
            // Get Estimate
            var estimate = 0;
            var k = start;

            while (remainingWeight > 0 && k < eList.Count)
            {
                if (eList[k][1] < remainingWeight)
                {
                    estimate += eList[k][0];
                    remainingWeight -= eList[k][1];
                }
                else
                {
                    // value * remainWeight / weight
                    estimate += eList[k][0] * remainingWeight / eList[k][1] + 1;
                    break;
                }

                k++;
            }

            return estimate;
        }
    }
}
