using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tests
    {
        static void Main(string[] args)
        {
            //1. Create binary tree and add elements.
            TreeNode tree = null;
            var BST = new BinarySearchTree();

            tree = BST.AddElement(tree, 10);
            tree = BST.AddElement(tree, 5);
            tree = BST.AddElement(tree, 30);
            tree = BST.AddElement(tree, 22);

            //2. Find elements
            Console.WriteLine(BST.FindElement(tree, 22));
            Console.WriteLine(BST.FindElement(tree, 5));
            Console.WriteLine(BST.FindElement(tree, 999));
        }
    }
}
