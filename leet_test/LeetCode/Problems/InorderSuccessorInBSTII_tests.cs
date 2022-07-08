using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.InorderSuccessorInBSTII;
using leet_test.Helpers;
using leet.LeetCode.Models.NodeParent;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class InorderSuccessorInBSTII_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
                2,1,3
            };
            var node = BinaryTreeParentNodeHelper.MakeTree(tree, 1);
            var expected = 2;

            var actual = sut.InorderSuccessor(node);

            Assert.AreEqual(expected, actual.val);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
                5,3,6,2,4,null,null,1
            };
            var node = BinaryTreeParentNodeHelper.MakeTree(tree, 1);
            Node expected = null;

            var actual = sut.InorderSuccessor(node);

            Assert.AreEqual(expected, actual);
        }
    }
}
