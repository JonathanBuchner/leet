using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.TwoSumIIIDataStructureDesign
{
    /*
     * Two Sum III - Data structure design
     * 
     * Design a data structure that accepts a stream of integers and checks if it has a pair of integers that sum up to a particular value.
     * 
     * https://leetcode.com/problems/two-sum-iii-data-structure-design/     
     */
    public class TwoSum
    {
        private List<int> list;

        public TwoSum()
        {
            list = new List<int>();
        }

        public void Add(int number)
        {
            list.Add(number);
        }
        
        public bool Find(int value)
        {
            var set = new HashSet<int>();
            
            foreach (var num in list)
            {
                var need = value - num;
                
                if(set.Contains(need))
                {
                    return true;
                }
                else
                {
                    set.Add(num);
                }
            }

            return false;
        }
    }
}
