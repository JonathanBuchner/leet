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
            //DepthFirstBranchAndBound();
            LimitedDiscrepancySearch();

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
            var arr = new int[] { 0 , P.Weight }; // First index is value, second is remaing weight

            DepthFirst(arr, eList, 0);

            P.IsOptimal = 1;
            P.Value = solution[0];
            for(var i = 2; i < solution.Length; ++i )
            {
                P.Selected[solution[i]] = 1;
            }
        }

        private int DFBCurrentBest = 0;
        private int[] solution = new int[] { 0 };
        // List
        // - First item is value
        // - Second itme is remainingWeight
        // Then a list of chosen indexs
        // Elist is items sorted by effeciency
        // e is the current index in the eList

        private void DepthFirst(int[] arr, List<int[]> eList, int e)
        {
            
            if(e >= eList.Count)
            {
                if(arr[0] > solution[0])
                {
                    solution = arr;
                }

                return;
            }

            var estimate = GetEstimate(eList, e, arr[1]);

            var left = new int[1];
            left[0] = 0;
            // Add item
            if( 
                e + 1 < eList.Count &&
                arr[1] - eList[e][1] >= 0 &&
                arr[0] + estimate > DFBCurrentBest
              ) 
            {
                var copy = new int[arr.Length + 1];

                Array.Copy(arr, 0, copy, 0, arr.Length);

                copy[0] += eList[e][0];  // Add value
                copy[1] -= eList[e][1];  // Add weight
                copy[copy.Length - 1] = eList[e][2];              // Add index
                DFBCurrentBest = Math.Max(DFBCurrentBest, copy[0]);
                DepthFirst(copy, eList, e + 1);
            }

            // No Add
            DepthFirst(arr, eList, e + 1);
        }

        private int GetEstimate(List<int[]> eList, int start, int remainingWeight)
        {

            // Get Estimate
            int estimate = 0;
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

        private int GetEstimate(int[][] eList, int start, int remainingWeight)
        {

            // Get Estimate
            int estimate = 0;
            var k = start;

            while (remainingWeight > 0 && k < eList.Length)
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

        private void LimitedDiscrepancySearch()
        {
            var queue = new LinkedList<int[]>();

            // Sort
            var eList = new int[P.Items.Count][];
            //value, weight, index

            for (var i = 0; i < P.Items.Count; ++i)
            {
                eList[i] = new int[] { P.Items[i][0], P.Items[i][1], i };
            }

            Array.Sort(eList, (a, b) => ((double)b[0] / b[1]).CompareTo((double)a[0] / a[1]));

            var list = new int[] { 0, P.Weight, -1 }; 
            // total value, remaing weight, e index

            queue.AddFirst(list);

            while(queue.Count > 0)
            {
                var q = queue.First;

                if (q.Value[2] >= eList.Length - 1 || q.Value[1] <= 0)
                {
                    if (q.Value[0] > solution[0])
                    {
                        DFBCurrentBest = q.Value[0];
                        solution = q.Value;
                    }

                    queue.RemoveFirst();
                }
                else
                {                
                    q.Value[2] += 1;
                    var e = q.Value[2];
                    // Next
                    var estimate = GetEstimate(eList, q.Value[2], q.Value[1]);

                    if (
                      q.Value[0] + estimate > DFBCurrentBest && // Remaining possible is above solution
                      q.Value[2] < eList.Length && // There are items remaining
                      q.Value[1] - eList[q.Value[2]][1] >= 0
                      )
                    {
                        var next = new int[q.Value.Length + 1];
                        Array.Copy(q.Value, 0, next, 0, q.Value.Length);
                        next[0] += eList[e][0];
                        next[1] -= eList[e][1];
                        next[2] = e;
                        next[next.Length - 1] = eList[e][2];

                        queue.AddFirst(next);
                    }
                }
            }

            P.IsOptimal = 1;
            P.Value = solution[0];
            
            for (var i = 3; i < solution.Length; ++i)
            {
                P.Selected[solution[i]] = 1;
            }
        }

        private void LimitedDiscrpancy()
        {

        }
    }
}
