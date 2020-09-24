using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesDS
{
    class ArrayStack<T>
    {
        internal T[] MyStack;
        private int TopIndex;

        public ArrayStack(int size)
        {
            MyStack = new T[size];
            TopIndex = 0;
        }

        public void Push(T value)
        {
            if(MyStack.Length == TopIndex)
            {
                return;
            }

            MyStack[TopIndex] = value;
            TopIndex += 1;
        }

        public T pop()
        {
            if (TopIndex == 0) throw new Exception("gavno");

            T value = MyStack[TopIndex - 1];
            TopIndex -= 1;

            return value;
        }
    }
}
