using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Microsoft.CountGoodNodesInBinaryTree;
using leet_test.Helpers;

namespace leet_test.LeetCode.Microsoft
{
    [TestClass]
    public class CountGoodNodesInBinaryTree_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var nodes = new int?[]
            {
                3,1,4,3,null,1,5
            };
            var root = BinaryTreeHelper.MakeTree(nodes);
            var expected = 4;

            var actual = sut.GoodNodes(root);

            Assert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var nodes = new int?[]
            {
                3,3,null,4,2
            };
            var root = BinaryTreeHelper.MakeTree(nodes);
            var expected = 3;

            var actual = sut.GoodNodes(root);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example3()
        {
            var sut = new Solution();
            var nodes = new int?[]
            {
                1
            };
            var root = BinaryTreeHelper.MakeTree(nodes);
            var expected = 1;

            var actual = sut.GoodNodes(root);

            Assert.AreEqual(expected, actual);
        }
    }
}
