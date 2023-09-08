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
            var node = BinaryTreeParentNodeHelper.MakeTree(tree, 6);
            Node expected = null;

            var actual = sut.InorderSuccessor(node);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
                15, 6, 18, 3, 7, 17, 20, 2, 4, null, 13, null, null, null, null, null, null, null, null, 9
            };
            var node = BinaryTreeParentNodeHelper.MakeTree(tree, 15);
            var expected = 17;

            var actual = sut.InorderSuccessor(node);

            Assert.AreEqual(expected, actual.val);
        }

        [TestMethod]
        public void TestCase20()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
                15, 6, 18, 3, 7, 17, 20, 2, 4, null, 13, null, null, null, null, null, null, null, null, 9
            };
            var node = BinaryTreeParentNodeHelper.MakeTree(tree, 13);
            var expected = 15;

            var actual = sut.InorderSuccessor(node);

            Assert.AreEqual(expected, actual.val);
        }

        [TestMethod]
        public void TestCase21()
        {
            var sut = new Solution();
            var tree = new int?[]
            {
                6, 2, 8, 0, 4, 7, 9, null, null, 3, 5
            };
            var node = BinaryTreeParentNodeHelper.MakeTree(tree, 2);
            var expected = 3;

            var actual = sut.InorderSuccessor(node);

            Assert.AreEqual(expected, actual.val);
        }
    }
}
