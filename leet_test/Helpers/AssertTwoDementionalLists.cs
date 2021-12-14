using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace leet_test.Helpers
{
    public static class AssertTwoDementionalLists
    {
        public static void AreMatch(IList<IList<string>> expected, IList<IList<string>> actual)
        { 
            foreach (var elist in expected)
                {
                    var passes = false;

                    foreach (var alist in actual)
                    {
                        if (Enumerable.SequenceEqual(alist.OrderBy(t => t), elist.OrderBy(t => t)))
                        {
                            passes = true;
                            break;
                        }
                    }

                Assert.IsTrue(passes);
            }
        }
        public static void AreMatch(List<List<int>> expected, List<List<int>> actual)
        {
            foreach (var elist in expected)
            {
                var passes = false;

                foreach (var alist in actual)
                {
                    if (Enumerable.SequenceEqual(alist.OrderBy(t => t), elist.OrderBy(t => t)))
                    {
                        passes = true;
                        break;
                    }
                }

                Assert.IsTrue(passes);
            }
        }
    }
}
