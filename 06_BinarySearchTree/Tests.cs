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
            Console.WriteLine(BST.FindElement(tree, 10));

            //3.Clone Tree
            var cloneTree = new TreeNode();
            cloneTree = tree.Clone() as TreeNode;
            Console.WriteLine("IsEquals: " + cloneTree.Equals(tree));
            Console.WriteLine("IsRefEquals: " + object.ReferenceEquals(cloneTree, tree));

            var equalNotClonedTree = tree;
            Console.WriteLine("IsEquals: " + equalNotClonedTree.Equals(tree));
            Console.WriteLine("IsRefEquals: " + object.ReferenceEquals(equalNotClonedTree, tree));

            //Delete elements
            cloneTree = BST.DeleteElement(cloneTree, 5);
            Console.WriteLine("cloneTree: " + BST.ToString(cloneTree));
            Console.WriteLine("tree: " + BST.ToString(tree));
        }
    }
}
