using System;
using System.ComponentModel;

namespace TreesDS
{
    public class Tree
    {
        public TreeNode Root { get; set; }

        public Tree()
        {
            this.Root = null;
        }

        private void AddHelper(TreeNode root, int value)
        {
            TreeNode newNode = new TreeNode(value);

            if (root == null)
            {
                this.Root = newNode;
                return;
            }

            if (root.Data > value)
            {
                if(root.LeftNode == null)
                {
                    root.LeftNode = newNode;
                }
                else
                {
                    AddHelper(root.LeftNode, value);
                }
            } else
            {
                if(root.RightNode == null)
                {
                    root.RightNode = newNode;
                }
                else
                {
                    AddHelper(root.RightNode, value);
                }
            }
        } 
        public void Add(int value)
        {
            //if (this.Root == null)
            //{
            //    this.Root = new TreeNode(value);
            //} else
            //{
                this.AddHelper(this.Root, value);
            //}
            
        }
    }
}
