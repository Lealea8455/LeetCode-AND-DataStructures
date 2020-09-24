using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListNS;
using System;
using System.Net.Http.Headers;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListCreationTests
    {
        [TestMethod]
        public void AddValuToBeginning()
        {
            LinkedList<int> list = new LinkedList<int>();

            int value1 = 43;
            int value2 = 11;
            int value3 = 26;
            int expected = 26;

            list.AddFront(value1);
            list.AddFront(value2);
            list.AddFront(value3);

            int actual = list.First();

            Assert.AreEqual(actual, expected, "insertion isn't right");
        }

        [TestMethod]
        public void AddValuToBeginningEmptyList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(7);

            int actual = list.First();
            int expected = 7;

            Assert.AreEqual(actual, expected, "insertion isn't right");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException),
         "Given index is out of list's range.")]
        public void AddValueAtIndex_IndexNotExists()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(4);
            list.AddFront(23);
            list.AddFront(9);
            list.AddAtIndex(5, 12);
        }

        [TestMethod]
        public void AddValueAtIndex()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(20);
            list.AddFront(8);
            list.AddFront(6);
            list.AddAtIndex(3, 5);

            int actual = list.head.next.next.data;
            int expected = 5;

            Assert.AreEqual(actual, expected, "Insertion is not correct");
        }

        [TestMethod]
        public void AddToEndOfList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(4);
            list.AddFront(23);
            list.AddFront(8);

            list.AddEnd(17);

            int expected = 17;
            int actual = list.head.next.next.next.data;

            Assert.AreEqual(actual, expected, "Insertion to end isn't correct");
        }

        [TestMethod]
        public void ValueAtIndex()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(4);
            list.AddFront(3);
            list.AddFront(2);
            list.AddFront(1);

            int expected = list.head.next.next.data;
            int actual = list.ValueAt(3);

            Assert.AreEqual(actual, expected, "Wrong value returned");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException),
         "Given index is out of list's range.")]
        public void ValueAtIndex_ValueGreaterThanList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(4);
            list.AddFront(3);
            list.AddFront(2);
            list.AddFront(1);
            list.ValueAt(12);
        }

        [TestMethod]
        public void RemoveFirst()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(4);
            list.AddFront(12);
            list.AddFront(9);

            int actual = list.PopFirst();
            int expected = 9;
            Assert.AreEqual(actual, expected, "Returned wrong value from PopFirst");

            int expected1 = 12;
            int actual1 = list.First();
            Assert.AreEqual(actual1, expected1, "Wrong first value, should be the second before pop");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void _EmptyList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.PopBack();
            list.DeleteAt(3);
            list.PopFirst();
        }

        [TestMethod]
        public void PopEndList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(34);
            list.AddFront(14);
            list.AddFront(3);

            int expected = 34;
            int actual = list.PopBack();

            Assert.AreEqual(actual, expected, "Wrong value returned");

            int actual2 = list.head.next.data;
            int expected2 = 14;

            Assert.AreEqual(actual2, expected2, "Didn't delete properly");

        }

        [TestMethod]
        public void DeleteValueAtIndex()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(4);
            list.AddFront(5);
            list.AddFront(12);
            list.AddFront(94);

            list.DeleteAt(2);

            int actual = list.head.next.data;
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }

    }
}
