using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.GasStation
{
    /*
     * Gas Station
     * 
     * There are n gas stations along a circular route, where the amount of gas at the ith station is gas[i].  You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from the ith station to its next (i + 1)th station. You begin the journey with an empty tank at one of the gas stations. Given two integer arrays gas and cost, return the starting gas station's index if you can travel around the circuit once in the clockwise direction, otherwise return -1. If there exists a solution, it is guaranteed to be unique
     * 
     * https://leetcode.com/problems/gas-station/description/
     */
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Length == 1)
            {
                return gas[0] - cost[0] >= 0 ? 0 : -1;
            }

            var p0 = 0;
            var p1 = 0;
            var tank = gas[p1];

            while (true)
            {
                tank -= cost[p1];
                p1 = p1 + 1 >= gas.Length ? 0 : p1 + 1;

                if (tank < 0)
                {
                    if (p1 > p0)
                    {
                        p0 = p1;
                        tank = gas[p1];
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (p1 == p0)
                    {
                        return p1;
                    }
                    else
                    {
                        tank += gas[p1];
                    }
                }
            }
        }
    }
}
