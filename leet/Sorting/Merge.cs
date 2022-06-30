using System;
using System.Collections.Generic;
using System.Text;

namespace leet.Sorting
{
    public static class Merge
    {
        public static int[] Sort(int[] arr)
        {
            if(arr.Length < 2)
            {
                return arr;
            }
            else if (arr.Length == 2)
            {
                if (arr[0] > arr[1])
                {
                    var temp = arr[0];
                    arr[0] = arr[1];
                    arr[1] = temp;
                }

                return arr;
            }

            var middle = arr.Length / 2;
            var rightLength = arr.Length % 2 == 0 ? middle : middle + 1;
            var left = new int[middle];
            var right = new int[rightLength];

            Array.Copy(sourceArray: arr, sourceIndex: 0, destinationArray: left, destinationIndex: 0, length: middle);
            Array.Copy(sourceArray: arr, sourceIndex: middle, destinationArray: right, destinationIndex: 0, length: rightLength );
            var sortedL = Sort(left);
            var sortedR = Sort(right);

            var i = 0;
            var j = 0;
            var k = 0;
            var sorted = new int[arr.Length];

            while (i < sortedL.Length && j < sortedR.Length )
            {
                if (sortedL[i] < sortedR[j])
                {
                    sorted[k] = sortedL[i];
                    i++;
                }
                else
                {
                    sorted[k] = sortedR[j];
                    j++;
                }
                k++;
            }

            while(i < sortedL.Length)
            {
                sorted[k] = sortedL[i];
                i++;
                k++;
            }

            while (j < sortedR.Length)
            {
                sorted[k] = sortedR[j];
                j++;
                k++;
            }

            return sorted;
        }
    }
}
