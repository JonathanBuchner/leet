using leet.Cormen.Chapter2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leet_test.Corment_tests.Chapter2
{
    [TestClass]
    public class Selection_sort_tests
    {
        #region Sort

        [TestMethod]
        public void If_input_is_empty_return_input()
        {
            var arr = new int[] { };
            var sut = new Selection_sort();

            sut.Sort(arr);

            Assert.AreEqual(0, arr.Length);
        }
 
        [TestMethod]
        public void If_input_length_is_equal_to_one__return_input()
        {
            var arr = new int[] { 5 };
            var sut = new Selection_sort();

            sut.Sort(arr);

            Assert.AreEqual(1, arr.Length);
        }

        [TestMethod]
        public void If_input_is_ordered_it_will_return_same_order()
        {
            var arr = new int[] { 1, 2, 3 };
            var exp = new int[] { 1, 2, 3 };
            var sut = new Selection_sort();

            sut.Sort(arr);

            CollectionAssert.AreEqual(exp, arr);
        }

        [TestMethod]
        public void It_will_order_a_reversed_list()
        {
            var arr = new int[] { 5, 4, 3, 2, 1 };
            var exp = new int[] { 1, 2, 3, 4, 5 };
            var sut = new Selection_sort();

            sut.Sort(arr);

            CollectionAssert.AreEqual(exp, arr);
        }

        [TestMethod]
        public void If_input_lenght_is_odd_it_will_order_the_list()
        {
            var arr = new int[] { 1, 3, 5, 7, 2, 4, 6 };
            var exp = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var sut = new Selection_sort();

            sut.Sort(arr);

            CollectionAssert.AreEqual(exp, arr);
        }

        [TestMethod]
        public void If_input_lenght_is_even_it_will_order_the_list()
        {
            var arr = new int[] { 2, 4, 6, 1, 3, 5 };
            var exp = new int[] { 1, 2, 3, 4, 5, 6 };
            var sut = new Selection_sort();

            sut.Sort(arr);

            CollectionAssert.AreEqual(exp, arr);
        }

        #endregion
    }
}
