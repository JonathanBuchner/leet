using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.Coursera.DiscreteOptimization.knapsack;

namespace leet_test.Coursera.DiscreteOptimization
{
    [TestClass]
    public class Knapsack_tests
    {
        [TestMethod]
        public void CanSolve()
        {
            // worth, weight
            var input_items = new List<int[]>()
            {
                new int[]{ 7,3},
                new int[]{ 10,5},
                new int[]{ 10,5},
                new int[]{ 13,8},
                new int[]{ 1,2},
                new int[]{ 1,2},
                new int[]{ 1,2},
            };
            var input_weight = 10;
            var sut = new Knapsack();
            /*var expected_value = 18;
            var expected_isOptimal = 0;
            var expected_items = new int[]
            {
                1, 1, 0, 0, 1, 0, 0
            };*/

            var expected_value = 20;
            var expected_isOptimal = 1;
            var expected_items = new int[]
            {
                0, 1, 1, 0, 0, 0, 0
            };

            var knapsack = sut.Solve(input_items, input_weight);

            Assert.IsTrue(knapsack.Problem.Value >= expected_value);
            Assert.IsTrue(knapsack.Problem.IsOptimal >= expected_isOptimal);
            CollectionAssert.AreEqual(expected_items, knapsack.Problem.Selected);

        }

        [TestMethod]
        public void CanSolve2()
        {
            // worth, weight
            var input_items = new List<int[]>()
            {
                new int[]{ 10,5},
                new int[]{ 13,8},
                new int[]{ 1,2},
                new int[]{ 1,2},
                new int[]{ 1,2},
                new int[]{ 10,5},
                new int[]{ 7,3},
            };
            var input_weight = 10;
            var sut = new Knapsack();
            /* var expected_value = 18;
            var expected_isOptimal = 0;
            var expected_items = new int[]
            {
                1, 0, 0, 1, 0, 0, 1
            };*/
            var expected_value = 20;
            var expected_isOptimal = 1;
            var expected_items = new int[]
            {
                1, 0, 0, 0, 0, 1, 0
            };


             var knapsack = sut.Solve(input_items, input_weight);

            Assert.IsTrue(knapsack.Problem.Value >= expected_value);
            Assert.IsTrue(knapsack.Problem.IsOptimal >= expected_isOptimal);
            CollectionAssert.AreEqual(expected_items, knapsack.Problem.Selected);

        }
    }
}
