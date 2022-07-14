using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.Helpers
{
    public static class AssertBinaryTrees
    {
        public static void AreEqualValue(TreeNode expectedRoot, TreeNode actualRoot)
        {
            if(expectedRoot == null && actualRoot == null)
            {
                return;
            }
            else if(
                expectedRoot == null && actualRoot != null ||
                expectedRoot != null && actualRoot == null
                )
            {
                Assert.Fail($"Expected is {expectedRoot}.  Actual root {actualRoot}");
            }
            else
            {
                Assert.AreEqual(expectedRoot.val, actualRoot.val);
            }

            AreEqualValue(expectedRoot.left, actualRoot.left);
            AreEqualValue(expectedRoot.right, actualRoot.right);
        }
    }
}
