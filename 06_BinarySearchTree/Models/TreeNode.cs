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

        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node != null &&
                Node == node.Node &&
                EqualityComparer<TreeNode>.Default.Equals(this.Left, node.Left) &&
                EqualityComparer<TreeNode>.Default.Equals(this.Right, node.Right))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            var hashCode = 989432594;

            hashCode = hashCode * -1521134295 + this.Node.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<TreeNode>.Default.GetHashCode(this.Left);
            hashCode = hashCode * -1521134295 + EqualityComparer<TreeNode>.Default.GetHashCode(this.Right);

            return hashCode;
        }
    }
}
