using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StacksAndQueuesDS;

namespace StacksAndQuesesTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void PileOfStacksDS()
        {
            PileOfStacks setOfStacks = new PileOfStacks(2);

            setOfStacks.Push(42);
            setOfStacks.Push(12);
            setOfStacks.Push(25);
            setOfStacks.Push(3);

            setOfStacks.Pop();
            setOfStacks.Pop();


        }
    }
}
