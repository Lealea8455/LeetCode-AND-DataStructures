using System;
using LinkedListNS;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace LinkedListQuestions
{
    static public class ListQuestions<T> 
    {
        private static bool IsMiddleOffOddList { get; set; } = false;
        static public Node<T> RemoveDuplicates(Node<T> head)
        {
            HashSet<T> unique = new HashSet<T>();

            Node<T> pointer = head;

            while (pointer != null)
            {
                if (!unique.Contains(pointer.data))
                {
                    unique.Add(pointer.data);
                }
                pointer = pointer.next;
            }

            pointer = head;
            Node<T> prev = null;

            foreach (T value in unique)
            {
                pointer.data = value;
                prev = pointer;
                pointer = pointer.next;
            }

            prev.next = null;
            return head;
        }
        static public Node<T> RemoveDuplicates2(Node<T> node)
        {

            Hashtable table = new Hashtable();
            Node<T> prev = node;

            while (node != null)
            {
                if (table.ContainsKey(node.data))
                {
                    prev.next = node.next;
                }
                else
                {
                    table.Add(node.data, true);
                    prev = node;
                }

                node = node.next;
            }

            return node;
        }
        static public Node<T> RemoveDuplicates3(Node<T> node)
        {
            Node<T> pointer = node;
            Node<T> prev = node;
            Node<T> iterator = node.next;

            while (pointer.next != null)
            {
                while (iterator != null)
                {
                    if (iterator.data.Equals(pointer.data))
                    {
                        iterator = iterator.next;
                        prev.next = iterator;
                        continue;
                    }
                    else
                    {
                        prev = iterator;
                        iterator = iterator.next;
                    }
                }
                iterator = pointer.next;
                pointer = pointer.next;
                prev = pointer;
            }

            return node;
        }
        static public T ValueAtIndexFromEnd(int index, Node<T> node)
        {
            int listSize = 0;
            Node<T> pointer = node;

            while (pointer != null)
            {
                listSize++;
                pointer = pointer.next;
            }

            pointer = node;

            for (int i = 0; i < listSize - index; i++)
            {
                pointer = pointer.next;
            }

            return pointer.data;
        }
        static public void DeleteNodeByGivenNode(Node<T> nodeToRemove)
        {
            if (nodeToRemove == null || nodeToRemove.next == null) return;
   
            nodeToRemove.data = nodeToRemove.next.data;
            nodeToRemove.next = nodeToRemove.next.next;

        }
        static public bool IsListPalindrom(Node<T> node)
        {
            if (node == null) return false;
            if (node.next == null) return true;

            Node<T> middleNode;

            middleNode = GetMiddleNode(node);
            middleNode = Reverse(middleNode);

            if(IsMiddleOffOddList == true)
            {
                middleNode = middleNode.next;
            }

            Node<T> tmp = node;

            while (middleNode != null)
            {
                if(!EqualityComparer<T>.Default.Equals(middleNode.data, tmp.data))
                {
                    return false;
                }
                middleNode = middleNode.next;
                tmp = tmp.next;
            }

            return true;
        }
        static public Node<T> GetMiddleNode(Node<T> node)
        {

            Node<T> fast = node; 
            Node<T> slow = node;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            if (fast != null)
            {
                IsMiddleOffOddList = true;
            }
            
            return slow;
        }
        static public Node<T> Reverse(Node<T> node)
        {
            Node<T> prev = null;
            Node<T> curr = node;

            while(curr != null)
            {
                var tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }

            return prev;
        }

        static public int SumOfElementsInList(Node<int> node)
        {
            Node<int> pointer = node;
            int sum = 0;
            int index = 0;

            while (pointer != null)
            {
                sum += (int)(pointer.data * Math.Pow(10, index));
                index++;
                pointer = pointer.next;
            }

            return sum;
        }
        static public Node<int> SumOfNumbersRepresentedByLists(Node<int> nodeNumber1, Node<int> nodeNumber2)
        {
            LinkedListNS.LinkedList<int> sumList = new LinkedListNS.LinkedList<int>();
            Node<int> result;

            int sum1 = SumOfElementsInList(nodeNumber1);
            int sum2 = SumOfElementsInList(nodeNumber2);

            int totalSum = sum1 + sum2;

            while (totalSum != 0)
            {
                sumList.AddFront(totalSum % 10);
                totalSum /= 10;
                
            }
            result = sumList.head;

            return result; 
        }
    }
} 
