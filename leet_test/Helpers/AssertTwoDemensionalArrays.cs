using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.Helpers
{
    public static class AssertTwoDemensionalArrays
    {
        public static void AreEqual(int[][] expected, int[][] actual)
        {
            for(var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
