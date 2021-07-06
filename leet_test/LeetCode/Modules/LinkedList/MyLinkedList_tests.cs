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
    }
}
