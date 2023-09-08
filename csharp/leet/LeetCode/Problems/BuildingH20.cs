using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.BuildingH20
{
    /*
     * Building H20
     * 
     * There are two kinds of threads: oxygen and hydrogen. Your goal is to group these threads to form water molecules.There is a barrier where each thread has to wait until a complete molecule can be formed. Hydrogen and oxygen threads will be given releaseHydrogen and releaseOxygen methods respectively, which will allow them to pass the barrier. These threads should pass the barrier in groups of three, and they must immediately bond with each other to form a water molecule. You must guarantee that all the threads from one molecule bond before any other threads from the next molecule do.
     * 
     * https://leetcode.com/problems/building-h2o/
     */
    public class H2O
    {
        public H2O()
        {

        }

        public void Hydrogen(Action releaseHydrogen)
        {
            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();
        }

        public void Oxygen(Action releaseOxygen)
        {
            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();
        }
    }
}
