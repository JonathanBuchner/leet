using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.BinaryTreeRightSideView;
using leet_test.Helpers;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class BinaryTreeRightSideView_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
                1,2,3,null,5,null,4
            };
            var root = BinaryTreeHelper.MakeTree(tree);
            var expected = new List<int>
            {
                1,3,4
            };

            var actual = sut.RightSideView(root);

            CollectionAssert.AreEqual(expected, (List<int>)actual);
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
               1,null,3
            };
            var root = BinaryTreeHelper.MakeTree(tree);
            var expected = new List<int>
            {
                1,3
            };

            var actual = sut.RightSideView(root);

            CollectionAssert.AreEqual(expected, (List<int>)actual);
        }
    }
}
