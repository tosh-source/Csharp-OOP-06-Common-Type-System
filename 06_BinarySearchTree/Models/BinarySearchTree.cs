using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    struct BinarySearchTree
    {
        private static bool isFound = false;

        public TreeNode AddElement(TreeNode root, int value)
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
                root.Left = AddElement(root.Left, value);
            }
            else if (value >= root.Node)
            {
                root.Right = AddElement(root.Right, value);
            }

            return root;
        }

        public string FindElement(TreeNode tree, long element)
        {
            Traverse(tree, element);

            if (isFound == true)
            {
                isFound = false;
                return "Element: " + element.ToString() + " was found!";
            }
            else
            {
                return "Element: " + element.ToString() + " was NOT found!";
            }
        }

        private void Traverse(TreeNode tree, long elementToStopProcess)
        {
            if (tree == null)
            {
                return;
            }
            else if (isFound == true)
            {
                return;
            }
            else if (elementToStopProcess == tree.Node)
            {
                isFound = true;
                return;
            }
            else
            {
                Traverse(tree.Left, elementToStopProcess);
                Traverse(tree.Right, elementToStopProcess);
            }
        }

    }
}

//Based on: https://gist.github.com/aaronjwood/7e0fc962c5cd898b3181
