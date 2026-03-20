using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.MinimumNumberOfSecondsToMakeMountainHeightZero;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class MinimumNumberOfSecondsToMakeMountainHeightZero_tests
    {
        public class TestCase()
        {
            public int InputMountainHeight { get; set; }
            public int[] WorkerTimes { get; set; }
            public long Expected { get; set; }
        }

        public static IEnumerable<object[]> Cases()
        {
            yield return new object[] {
                new TestCase()
                    {
                        InputMountainHeight = 4,
                        WorkerTimes = new int[] { 2, 1, 1 },
                        Expected = 3
                    }
            };
            yield return new object[] {
                new TestCase()
                    {
                        InputMountainHeight = 10,
                        WorkerTimes = new int[] { 3, 2, 2, 4 },
                        Expected = 12
                }
            };
            yield return new object[] {
                new TestCase()
                    {
                        InputMountainHeight = 100000,
                        WorkerTimes = new int[] { 1000000 },
                        Expected = 5000050000000000
                }
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(Cases), DynamicDataSourceType.Method)]
        public void TestCases_Basic(TestCase tc)
        {
            var SUT = new Solution();

            var actual = SUT.MinNumberOfSeconds(tc.InputMountainHeight, tc.WorkerTimes);

            Assert.AreEqual(tc.Expected, actual);
        }
    }
}
