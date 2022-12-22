using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.MeetingRoomsII
{
    /*
     * Meeting Rooms
     * 
     * Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if a person could attend all meetings.
     * 
     * https://leetcode.com/problems/meeting-rooms/
     */
    public class Solution
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            var list = new List<int[]>();

            foreach (var entry in intervals)
            {
                list.Add(entry);
            }

            list.Sort((a, b) => a[0].CompareTo(b[0]));

            for (var i = 0; i < list.Count - 1; i++)
            {
                if (list[i][1] > list[i + 1][0])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
