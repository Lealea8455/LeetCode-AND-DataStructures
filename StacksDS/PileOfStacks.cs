using System;
using System.Collections.Generic;
using System.Text;
using LinkedListNS;

namespace StacksAndQueuesDS
{
    public class PileOfStacks
    {
        List<ArrayStack<int>> StacksList;
        int currentStackPosition;
        int top;
        private readonly int threshold;

        public PileOfStacks(int threshold)
        {
            this.threshold = threshold;
            currentStackPosition = 0;
            top = 0;
            StacksList = new List<ArrayStack<int>>
            {
                new ArrayStack<int>(threshold)
            };
        }

        public void Push(int value)
        {
            int[] currentStack = StacksList[currentStackPosition].MyStack;

            if(top != currentStack.Length)
            {
                currentStack[top] = value;
                top++;
                //top = (top % currentStack.Length) + 1;
            }
            else
            { 
                StacksList.Add(new ArrayStack<int>(threshold));
                currentStackPosition++;
                top = 0;
                StacksList[currentStackPosition].MyStack[top] = value;
                top += 1;
            }
        }

        public int Pop()
        {
            int value = StacksList[currentStackPosition].MyStack[top-1];

            if (top == 0)
            {
                if(currentStackPosition != 0) throw new Exception();

                currentStackPosition--;
                top = threshold;
            }
            else
            {
                top--;
            }

            return value;
        }
    }
}
