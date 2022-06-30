using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.sort;
using leet_test.sort_tests.Helpers;


namespace leet_test.sort
{
    [TestClass]
    public class Merge_tests
    {
        [TestMethod]
        public void TestsCanFail()
        {
            Assert.IsTrue(true);
            // Assert.Fail();
        }

        [TestMethod]
        public void Can_Sort_Empty()
        {
            var arr = new int[] { };

            var sorted = Sort.Merge(arr);

            Assert.AreEqual(sorted.Length, 0);
        }

        [TestMethod]
        public void Can_Sort_With_Length_One()
        {
            var arr = new int[] { 1 };

            var sorted = Sort.Merge(arr);

            Assert.AreEqual(sorted.Length, 1);
        }

        [TestMethod]
        public void Can_Sort_With_Length_Two()
        {
            var arr = new int[] { 2, 1 };
            var desired = new int[] { 1, 2 };

            var sorted = Sort.Merge(arr);

            CollectionAssert.AreEqual(sorted, desired);
        }

        [TestMethod]
        public void Can_Sort_With_Length_10()
        {
            var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var desired = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var sorted = Sort.Merge(arr);

            CollectionAssert.AreEqual(sorted, desired);
        }

        [TestMethod]
        public void Can_Sort_With_Length_Complex()
        {
            var arr = new int[] { 99999, 10, 44, -1111, 0, 2, 2, 2, -1 , 5, 6, 7, 8};
            var desired = new int[] { -1111, -1, 0, 2, 2, 2, 5, 6, 7, 8, 10, 44, 99999 };

            var sorted = Sort.Merge(arr);

            CollectionAssert.AreEqual(sorted, desired);
        }

        [TestMethod]
        public void Can_Sort_1000()
        {
            var arr = Test_Utility.Generate_Random_Numbers_In_Int_Array(1000);

            var sorted = Sort.Merge(arr);

            Assert.IsTrue(Test_Utility.CheckIncreasesInValue(sorted));
        }
    }
}
