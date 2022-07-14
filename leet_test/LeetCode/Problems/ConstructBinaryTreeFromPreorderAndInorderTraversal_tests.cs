using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.ConstructBinaryTreeFromPreorderAndInorderTraversal;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class ConstructBinaryTreeFromPreorderAndInorderTraversal_tests
    {
        [TestMethod]
        public void Example1()
        {
            var sut = new Solution();
            var preorder = new int[]
            {
                3,9,20,15,7
            };
            var inorder = new int[]
            {
                9, 3, 15, 20, 7
            };
            var expected_input = new int?[]
            {
                3,9,20,null,null,15,7
            };
            var expected = Helpers.BinaryTreeHelper.MakeTree(expected_input);

            var actual = sut.BuildTree(preorder, inorder);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Example2()
        {
            var sut = new Solution();
            var preorder = new int[]
            {
                   -1
            };
            var inorder = new int[]
            {
                   -1
            };
            var expected_input = new int?[]
            {
                   -1
            };
            var expected = Helpers.BinaryTreeHelper.MakeTree(expected_input);

            var actual = sut.BuildTree(preorder, inorder);

            Assert.AreEqual(expected, actual);
        }
    }
}
