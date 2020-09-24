using System;
using System.Collections.Generic;
using System.Text;

namespace TreesDS
{
    public class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
        public int Data { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}
