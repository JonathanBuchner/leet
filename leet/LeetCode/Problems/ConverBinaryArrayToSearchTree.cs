using leet.LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.ConverBinaryArrayToSearchTree
{
    /*
     * Convert Sorted Array to Binary Search Tree
     * 
     * Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
     * 
     * https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
     */
    public class Solution
    {
        private int[] nums;

        public TreeNode SortedArrayToBST(int[] nums)
        {
            this.nums = nums;

            if (nums.Length == 0)
            {
                return null;
            }
            else if (nums.Length == 1)
            {
                return new TreeNode(nums[0]);
            }

            return Split(0, nums.Length - 1);
        }

        private TreeNode Split(int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            else if (start == end)
            {
                return new TreeNode(nums[start]);
            }
            else if (start + 1 == end)
            {
                return new TreeNode(nums[end], new TreeNode(nums[start]));
            }

            //[0, 1, 2 ,3 ,4 ,5]

            var middle = (end - start) / 2 + start;
            var treeNode = new TreeNode(nums[middle]);
            treeNode.left = Split(start, middle - 1);
            treeNode.right = Split(middle + 1, end);

            return treeNode;
        }
    }
}
