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
        private static List<long> treeAsArray = new List<long>();

        public TreeNode AddElement(TreeNode tree, long value)
        {
            if (tree == null)
            {
                tree = new TreeNode
                {
                    Node = value
                };
            }
            else if (value < tree.Node)
            {
                tree.Left = AddElement(tree.Left, value);
            }
            else if (value >= tree.Node)
            {
                tree.Right = AddElement(tree.Right, value);
            }

            return tree;
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

        public TreeNode DeleteElement(TreeNode tree, long element)
        {
            //TO DO: Find elements and clone NEW object SKIPPED element

            Traverse(tree, element);

            if (isFound == true)
            {
                isFound = false;

                treeAsArray.Clear();
                TraverseAndReturnElements(tree);
                treeAsArray.Remove(element);
            }
            else
            {
                throw new ArgumentException("There is no such kind of element to delete!");
            }

            TreeNode result = null;
            for (int i = 0; i < treeAsArray.Count; i++)
            {
                result = AddElement(result, treeAsArray[i]);
            }

            return result;
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

        private void TraverseAndReturnElements(TreeNode tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                treeAsArray.Add(tree.Node);
            }

            TraverseAndReturnElements(tree.Left);
            TraverseAndReturnElements(tree.Right);
        }
    }
}

//Based on: https://gist.github.com/aaronjwood/7e0fc962c5cd898b3181
