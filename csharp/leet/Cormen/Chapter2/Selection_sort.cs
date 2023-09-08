using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace leet.Cormen.Chapter2
{
    // This was part of excercises 2.2-2
    public class Selection_sort
    {
        public void Sort(int[] input)
        {
            for (var i = 0; i < input.Length - 1; i++)
            {
                var smallest = Int32.MaxValue;
                var index = -1;
                
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < smallest)
                    {
                        smallest = input[j];
                        index = j;
                    }
                }

                if (input[i] > input[index])
                {
                    var temp = input[i];
                    input[i] = input[index];
                    input[index] = temp;
                }
            }
        }
    }
}
