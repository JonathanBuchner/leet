using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.HashTables.MinimumIndexSumofTwoLists;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class MinimumIndexSumofTwoLists_tests
    {
        [TestMethod]
        [DataRow(
            new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new string[] {"Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"},
            new string[] { "Shogun"}
        )]
        [DataRow(
            new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new string[] { "KFC", "Shogun", "Burger King" },
            new string[] { "Shogun" }
        )]
        [DataRow(
            new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new string[] { "KFC", "Burger King", "Tapioca Express", "Shogun" },
            new string[] { "KFC", "Burger King", "Tapioca Express", "Shogun" }
        )]
        [DataRow(
            new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new string[] { "KNN", "KFC", "Burger King", "Tapioca Express", "Shogun" },
            new string[] { "KFC", "Burger King", "Tapioca Express", "Shogun" }
        )]
        [DataRow(
            new string[] { "KFC" },
            new string[] { "KFC" },
            new string[] { "KFC" }
        )]


        public void FindRestaurant(string[] input1, string[] input2, string[] expected)
        {
            var sut = new Solution();

            var actual = sut.FindRestaurant(input1, input2);

            CollectionAssert.AreEqual(expected, actual);        }
    }
}
