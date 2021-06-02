using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeNode : ICloneable
    {
        public long Node { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public object Clone()
        {
            var cloneTreeNode = new TreeNode();
            cloneTreeNode.Node = this.Node;
            cloneTreeNode.Left = this.Left;
            cloneTreeNode.Right = this.Right;

            return cloneTreeNode;
        }
    }
}
