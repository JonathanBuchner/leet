using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leet.LeetCode.Modules.LinkedList;

namespace leet_test.LeetCode.Modules.LinkedList
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void Example1_Can_pass_leet_code_first_test_case()
        {
            //["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
            //[[],[1],[3],[1,2],[1],[1],[1]]
            var expected = 2;
            var expected2 = 3;
            var sut = new MyLinkedList();

            sut.AddAtHead(1);
            sut.AddAtTail(3);
            sut.AddAtIndex(1, 2);
            var actual = sut.Get(1);
            sut.DeleteAtIndex(1);
            var actual2 = sut.Get(1);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void Can_add_at_head()
        {
            var expected = 1;
            var expected2 = 2;
            var expected3 = 3;
            var sut = new MyLinkedList();

            sut.AddAtHead(3);
            sut.AddAtHead(2);
            sut.AddAtHead(1);
            var actual = sut.Get(0);
            var actual2 = sut.Get(1);
            var actual3 = sut.Get(2);


            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void Can_add_at_tail()
        {
            var expected = 1;
            var expected2 = 2;
            var expected3 = 3;
            var sut = new MyLinkedList();

            sut.AddAtTail(1);
            sut.AddAtTail(2);
            sut.AddAtTail(3);
            var actual = sut.Get(0);
            var actual2 = sut.Get(1);
            var actual3 = sut.Get(2);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void Can_add_at_index()
        {
            var expected = 0;
            var expected2 = 1;
            var expected3 = 2;
            var expected4 = 3;
            var expected5 = -1;


            var sut = new MyLinkedList();

            sut.AddAtIndex(0, 1);
            sut.AddAtIndex(0, 0);
            sut.AddAtIndex(2, 3);
            sut.AddAtIndex(2, 2);

            var actual = sut.Get(0);
            var actual2 = sut.Get(1);
            var actual3 = sut.Get(2);
            var actual4 = sut.Get(3);
            var actual5 = sut.Get(10);


            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
        }

        [TestMethod]
        public void Can_delete_at_index()
        {
            var expected = 2;
            var expected2 = 4;
            var sut = new MyLinkedList();

            sut.AddAtTail(1);
            sut.AddAtTail(2);
            sut.AddAtTail(3);
            sut.AddAtTail(4);
            sut.AddAtTail(5);
            sut.AddAtTail(6);
            sut.DeleteAtIndex(5);
            sut.DeleteAtIndex(0);
            sut.DeleteAtIndex(1);
            sut.DeleteAtIndex(20);
            var actual = sut.Get(0);
            var actual2 = sut.Get(1);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void TestCase1_Add_Then_Delete()
        {
            var sut = new MyLinkedList();

            sut.AddAtHead(1);
            sut.DeleteAtIndex(0);

            Assert.IsTrue(true);
        }
    }
}
