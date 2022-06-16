using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace leet.LeetCode.Modules.Queue_Stack.MovingAverageFromDataStream
{
    public class MovingAverage
    {
        private int[] data;
        private int window;
        private int pos;

        public MovingAverage(int size)
        {
            data = new int[size];
            window = 0;
            pos = 0;
        }

        public double Next(int val)
        {
            if (window < data.Length)
            {
                window++;
            }

            pos++;

            if(pos == data.Length)
            {
                pos = 0;
            }

            data[pos] = val;

            double answer = 0;
            
            for(var i = 0; i < data.Length; i++)
            {
                answer+= data[i];
            }

            answer /= window;

            return answer;
        }
    }
}
