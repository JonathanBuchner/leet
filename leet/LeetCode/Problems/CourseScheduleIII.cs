using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.CourseScheduleIII
{
    /*
     * Course Schedule III
     * 
     * There are n different online courses numbered from 1 to n. You are given an array courses where courses[i] = [durationi, lastDayi] indicate that the ith course should be taken continuously for durationi days and must be finished before or on lastDayi.
     * 
     * https://leetcode.com/problems/course-schedule-iii/
     */
    public class Solution
    {
        public int ScheduleCourse(int[][] courses)
        {
            Array.Sort(courses, (a, b) => b[1] - a[1]);
            var signup = new PriorityQueue<int, int>();
            var total = 0;

            for(var i = courses.Length - 1; i >= 0; i--)
            {
                var days = courses[i][0];
                var end = courses[i][1];

                if (total + days <= end)
                {
                    signup.Enqueue(days, days * -1);
                    total += days;
                }
                else if (signup.Count > 0)
                {
                    var worst = signup.EnqueueDequeue(days, days * -1);
                    total += days - worst;
                }
            }

            return signup.Count;
        }
    }
}
