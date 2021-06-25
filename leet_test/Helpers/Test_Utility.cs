using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace leet_test.sort_tests.Helpers
{
    public class Test_Utility
    {
        public static int[] Generate_Random_Numbers_In_Int_Array(int arraySize)
        {
            var arr = new int[arraySize];
            var rand = new Random();

            for (var i = 0; i < arr.Length; i++) arr[i] = rand.Next();

            return arr;
        }

        public static bool CheckIncreasesInValue(int[] arr)
        {
            if (arr.Length <= 1) return true;

            for(var i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }

            return true;
        }
    }
}
