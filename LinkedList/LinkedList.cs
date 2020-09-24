using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LinkedListNS
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public LinkedList()
        {
            head = null;
        }
        public T First()
        {
            return head.data;
        }
        public void AddFront(T data)
        {
            Node<T> node = new Node<T>(data);

            node.next = head;
            head = node;
            return;
        }
        public void AddAtIndex(int index, T data)
        {
            if (index > Size() || index < 1)
                throw new IndexOutOfRangeException("index is out of range");

            if (index == 1)
                AddFront(data);

            Node<T> node = new Node<T>(data);
            Node<T> pointer = head;

            // If we haven't checked the case of index < size, then in the while we would have add - && pointer != null, than outside while check if index != 1 then out of range
            while (index-- != 0)
            {
                if (index == 1)
                {
                    node.next = pointer.next;
                    pointer.next = node;
                }
                pointer = pointer.next;
            }
        }
        public void AddEnd(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
                return;
            }

            Node<T> pointer = head;
            while (pointer.next != null)
            {
                pointer = pointer.next;
            }
            pointer.next = node;
        }
        public int Size()
        {
            int counter = 0;
            Node<T> pointer = head;

            while (pointer != null)
            {
                pointer = pointer.next;
                counter++;
            }

            return counter;
        }
        public bool Empty()
        {
            return head != null;
        }
        public T ValueAt(int index)
        {
            if (index > Size())
            {
                throw new IndexOutOfRangeException("index is out of range");
            }

            Node<T> pointer = head;

            while (index != 1)
            {
                pointer = pointer.next;
                index--;
            }
            return pointer.data;
        }
        public T PopFirst()
        {
            if (head == null)
            {
                throw new NullReferenceException();
            }

            T value = head.data;
            head = head.next;

            return value;
        }
        public T PopBack()
        {
            if (head == null) throw new NullReferenceException();

            T value = head.data;

            if (head.next == null) // more than 1 element on the list
            {
                head = null;
                return value;
            }

            Node<T> pointer = head.next;
            Node<T> prev = head;

            while(pointer.next != null)
            {
                pointer = pointer.next;
                prev = prev.next;
            }

            value = pointer.data;
            prev.next = null;

            return value;
        }
        public void DeleteAt(int index)
        {
            if (head == null) throw new NullReferenceException();

            Node<T> pointer = head;

            while(index != 0)
            {
                index--;
                if(index == 1)
                {
                    pointer.next = pointer.next.next;
                    return;
                }
                pointer = pointer.next;
            }
        }
    }
}
