using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ZigzagIterator
{
    public class ZigzagIterator
    {

        private bool do_first = true;
        private IList<int> v1;
        private IList<int> v2;
        private int v1_index;
        private int v2_index;

        public ZigzagIterator(IList<int> v1, IList<int> v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            v1_index = 0;
            v2_index = 0;
        }

        public bool HasNext()
        {
            return !(v1_index >= v1.Count && v2_index >= v2.Count);
        }

        public int Next()
        {
            if ((do_first && v1_index < v1.Count) || v2_index >= v2.Count)
            {
                v1_index++;
                do_first = false;
                return v1[v1_index - 1];
            }
            else
            {
                v2_index++;
                do_first = true;
                return v2[v2_index - 1];
            }
        }
    }

    /**
     * Your ZigzagIterator will be called like this:
     * ZigzagIterator i = new ZigzagIterator(v1, v2);
     * while (i.HasNext()) v[f()] = i.Next();
     */
}
