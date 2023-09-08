using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using leet.LeetCode.Modules.Queue_Stack;

namespace leet_test.LeetCode.Modules.Queues_Stacks
{
    [TestClass]
    public class DesignACirculuarQueue_tests
    {
        [TestMethod]
        public void Test1()
        {
            // ["MyCircularQueue", "enQueue", "enQueue", "enQueue", "enQueue", "Rear", "isFull", "deQueue", "enQueue", "Rear"]
            // [[3],[1],[2],[3],[4],[],[],[],[4],[]]
            var sut = new MyCircularQueue(3);

            var result1 = sut.EnQueue(1); //True
            var result2 = sut.EnQueue(2); //True
            var result3 = sut.EnQueue(3); //True
            var result4 = sut.EnQueue(4); //False
            var result5 = sut.Rear(); // 3
            var result6 = sut.IsFull(); // true
            var result7 = sut.DeQueue(); // true
            var result8 = sut.EnQueue(4); // true
            var result9 = sut.Rear(); // 4

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(false, result4);
            Assert.AreEqual(3, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(true, result7);
            Assert.AreEqual(true, result8);
            Assert.AreEqual(4, result9);
        }

        [TestMethod]
        public void Test2()
        {

            var sut = new MyCircularQueue(81);
            var result1 = sut.EnQueue(69);  // true
            var result2 = sut.DeQueue();    // true
            var result3 = sut.EnQueue(92);  // true
            var result4 = sut.EnQueue(12);  // true
            var result5 = sut.DeQueue();    // true
            var result6 = sut.IsFull();     // true
            var result7 = sut.IsFull();     // true
            var result8 = sut.Front();      //True

            Assert.AreEqual(12, result8);
        }
    }
}
