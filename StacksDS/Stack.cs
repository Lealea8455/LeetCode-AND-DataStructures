using System;
using System.Threading;
using LinkedListNS;

namespace StacksAndQueuesDS
{
    public class Stack<T>
    {
        Node<T> top;

        public Stack() {
            top = null;
        }
        
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);

            node.next = top;
            top = node;
        }

        public Node<T> Pop()
        {
            if(top == null)
            {
                return null;
            }

            Node<T> popedNode = new Node<T>();
            popedNode = top;
            top = top.next;

            return popedNode;
        }
    }
}
