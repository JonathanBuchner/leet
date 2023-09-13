/***
 * Teemo Attacking
 * 
 * Our hero Teemo is attacking an enemy Ashe with poison attacks! When Teemo attacks Ashe, Ashe gets poisoned for a exactly duration seconds. More formally, an attack at second t will mean Ashe is poisoned during the inclusive time interval [t, t + duration - 1]. If Teemo attacks again before the poison effect ends, the timer for it is reset, and the poison effect will end duration seconds after the new attack.
 * 
 * You are given a non-decreasing integer array timeSeries, where timeSeries[i] denotes that Teemo attacks Ashe at second timeSeries[i], and an integer duration.
 * 
 * Return the total number of seconds that Ashe is poisoned.
 * 
 * https://leetcode.com/problems/teemo-attacking/description/
 */
class TeemoAttacking {
    public int findPoisonedDuration(int[] timeSeries, int duration) {
        var total = 0;
        
        if (timeSeries.length == 0)
        {
            return 0;
        }

        if (timeSeries.length == 1)
        {
            return duration;
        }
        
        for (var i = 0; i < timeSeries.length - 1; i++)
        {
            total += Math.min(timeSeries[i + 1] - timeSeries[i], duration);
        }

        total += duration;

        return total;
    }
}