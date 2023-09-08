using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.HashTables.GroupShiftedStrings;
using System.Linq;

namespace leet_test.LeetCode.Modules.HashTables
{
    [TestClass]
    public class GroupStrings_tests
    {
        [TestMethod]
        public void GroupStrings_CanSortStrings()
        {
            var sut = new Solution();
            var input = new string[] { "abc", "bcd", "acef", "xyz", "az", "ba", "a", "z" };
            var expected = new List<IList<string>>();
            /*expected.Add(new List<string>() { "acef" });
            expected.Add(new List<string>() { "a", "z" });
            expected.Add(new List<string>() { "abc", "bcd", "xyz" });*/
            expected.Add(new List<string>() { "az", "ba" });

            var actual = sut.GroupStrings(input);

            foreach (var elist in expected)
            {
                var match = false;

                foreach (var alist in actual)
                {
                    if (!alist.Except(elist).ToList().Any() && !elist.Except(alist).ToList().Any())
                    {
                        match = true;
                        break;
                    }
                }

                Assert.IsTrue(match);
            }
        }
    }
}
