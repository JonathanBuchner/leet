using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Models.NodeParent
{
   public class Node
   {
        public int val { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node parent { get; set; }

        public Node(int val, Node left = null, Node right = null, Node parent = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            this.parent = parent;
        }
    }
}
