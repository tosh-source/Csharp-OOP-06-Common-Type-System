using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BinarySearchTree.Models
{
    struct BinarySearchTree
    {
        public TreeNode AddNewElement(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode
                {
                    Node = value
                };
            }
            else if (value < root.Node)
            {
                root.Left = AddNewElement(root.Left, value);
            }
            else if (value >= root.Node)
            {
                root.Right = AddNewElement(root.Right, value);
            }

            return root;
        }
    }
}

//Based on: https://gist.github.com/aaronjwood/7e0fc962c5cd898b3181
