using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leet.LeetCode.Problems.KillProcess;

namespace leet_test.LeetCode.Problems
{
    [TestClass]
    public class KillProcess_tests
    {
        private static IEnumerable<(IList<int> pid, IList<int> ppid, int kill, IList<int> expected)> cases()
        {
            yield return (
                new List<int>() { 1, 3, 10, 5 },
                new List<int>() { 3, 0, 5, 3 },
                5,
                new List<int>() { 5, 10 } 
                );


            yield return (
                new List<int>() { 1 },
                new List<int>() { 0 },
                1,
                new List<int>() { 1 }
                );
        }

        [DataTestMethod]
        [DynamicData(nameof(cases), DynamicDataSourceType.Method)]
        public void KillProcess_basic_tests(IList<int> pid, IList<int> ppid, int kill, IList<int> expected)
        {
            var SUT = new Solution();

            var actual = SUT.KillProcess(pid, ppid, kill);

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
