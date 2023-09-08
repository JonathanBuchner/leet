using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace leet.sort
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            if (arr.Length <= 1) return;                    // 2 operations
            
            for(int i = 0; i < arr.Length - 1; i++)         // 2 operations per input
            {
                for (int j = 0; j < arr.Length - 1; j++)    // 2 operations per input
                {
                    if (arr[j] > arr[j + 1])                // 1 operations
                    {
                        var hold = arr[j];                  // 1 operations
                        arr[j] = arr[j + 1];                // 1 operations
                        arr[j + 1] = hold;                  // 1 operations
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            if (arr.Length < 1) return;

            int smallest = 0;
            int save = 0;
            int swap = -1;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                smallest = arr[i];
                int j = i + 1;
                
                while (j < arr.Length)
                {
                    if (smallest > arr[j])
                    {
                        smallest = arr[j];
                        swap = j;
                    }
                    j++;
                }

                if (smallest != arr[i])
                {
                    save = arr[i];
                    arr[i] = smallest;
                    arr[swap] = save;
                }
            }
        }

        public static void Insertion(int[] arr)
        {
            if (arr.Length < 1) return;

            int save;

            for(var i = 1; i < arr.Length; i++)
            {
                int j = i;
                
                while (arr[j - 1] > arr[j])
                {

                    save = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = save;

                    j--;

                    if (j == 0) break;
                }
            }
        }

        public static int[] Merge(int[] arr)
        {

            if (arr.Length <= 1) return arr;
            
            decimal length = arr.Length / 2;
            var middle = Convert.ToInt32(Math.Ceiling(length));

            var unsort1 = arr.Take(middle).ToArray();
            var unsort2 = arr.Skip(middle).ToArray();

            var sort1 = Merge(unsort1);
            var sort2 = Merge(unsort2);

            var combined = Combine(sort1, sort2);

            return combined;
        }

        public static int[] Combine(int[] sort1, int[] sort2)
        {
            var sorted = new int[sort1.Length + sort2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < sort1.Length && j < sort2.Length)
            {
                if(sort1[i] < sort2[j])
                {
                    sorted[k] = sort1[i];
                    i++;
                }
                else
                {
                    sorted[k] = sort2[j];
                    j++;
                }

                k++;
            }

            if (i < sort1.Length)
            {
                while (i < sort1.Length)
                {
                    sorted[k] = sort1[i];
                    i++;
                    k++;
                }
            }
            else
            {
                while (j < sort2.Length)
                {
                    sorted[k] = sort2[j];
                    j++;
                    k++;
                }
            }

            return sorted;
        }
    }
}
