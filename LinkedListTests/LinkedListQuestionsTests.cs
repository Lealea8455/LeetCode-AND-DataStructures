using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListNS;
using LinkedListQuestions;
using System.ComponentModel;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListQuestionsTests
    {
        [TestMethod]
        public void RemoveDuplicatesTest()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(1);
            list.AddFront(5);
            list.AddFront(83);
            list.AddFront(1);
            list.AddFront(5);

            int expected1 = 5;
            int expected2 = 1;
            int expected3 = 83;

            list.head = ListQuestions<int>.RemoveDuplicates(list.head);

            int actual1 = list.head.data;
            int actual2 = list.head.next.data;
            int actual3 = list.head.next.next.data;

            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);
        }

        [TestMethod]
        public void RemoveDuplicates2Test()
        {

        }

        [TestMethod]
        public void ValutAtIndexFromEnd()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(3);
            list.AddFront(24);
            list.AddFront(6);
            list.AddFront(9);
            list.AddFront(15);
            list.AddFront(59);

            int expected = 6;

            int actual = ListQuestions<int>.ValueAtIndexFromEnd(3, list.head);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void DeleteNodeByGivenNode()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(3);
            list.AddFront(24);
            list.AddFront(6);

            Node<int> node = list.head.next;

            ListQuestions<int>.DeleteNodeByGivenNode(node);

            int expected1 = 6;
            int expected2 = 3;

            Assert.AreEqual(list.head.data, expected1);
            Assert.AreEqual(list.head.next.data, expected2);

        }

        [TestMethod]
        public void IsListPalindrom()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(3);
            list.AddFront(1);
            list.AddFront(1);
            list.AddFront(3);

            bool expected = true;

            bool actual = ListQuestions<int>.IsListPalindrom(list.head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMiddleNode()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(1);
            list.AddFront(5);
            list.AddFront(7);
            list.AddFront(23);
            list.AddFront(9);

            Node<int> expected = list.head.next.next;

            Node<int> actual = ListQuestions<int>.GetMiddleNode(list.head);

            Assert.AreEqual(expected.data, actual.data);
        }

        [TestMethod]
        public void ReverseList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFront(34);
            list.AddFront(12);
            list.AddFront(4);
            list.AddFront(9);

            int expected = 34;

            Node<int> actual = ListQuestions<int>.Reverse(list.head);

            Assert.AreEqual(expected, actual.data);

        }

        public void SumOfNumbersRepresentedByLists()
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();

            list1.AddFront(5);
            list1.AddFront(1);
            list1.AddFront(3);

            list2.AddFront(2);
            list2.AddFront(9);
            list2.AddFront(5);

            int expected = 808;

            Node<int> sumList = ListQuestions<int>.SumOfNumbersRepresentedByLists(list1.head, list2.head);
            int actual = sumList.data + sumList.next.data + sumList.next.next.data;

            Assert.AreEqual(expected, actual);
        }
    }
}
