using leet.LeetCode.Models;
using leet_test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using leet.LeetCode.Problems.BalanceABinarySearchTree;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class BalanceABinarySearchTree_tests
    {
        public static IEnumerable<(TreeNode input, TreeNode expected)> Cases()
        {
            yield return (
                BinaryTreeHelper.MakeTree(new int?[] { 1, null, 2, null, 3, null, 4, null, null }),
                BinaryTreeHelper.MakeTree(new int?[] { 3, 2, 4, 1 })
            );

            yield return (
                BinaryTreeHelper.MakeTree(new int?[] { 2, 1, 3 }),
                BinaryTreeHelper.MakeTree(new int?[] { 2, 1, 3 })
            );
        }


        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void BalanceBinaryTreeTests(TreeNode input, TreeNode expected)
        {
            var SUT = new Solution();

            var actual = SUT.BalanceBST(input);

            AssertBinaryTrees.AreEqualValue(expected, actual);
        }

    }
}
