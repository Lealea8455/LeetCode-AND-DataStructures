using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreesDS;

namespace TreesTests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Add()
        {
            Tree tree = new Tree();

            tree.Add(6);
            tree.Add(25);
            tree.Add(4);

            int expected = 4;
            int actual = tree.Root.LeftNode.Data;

            Assert.AreEqual(actual, expected);
        }
    }
}
