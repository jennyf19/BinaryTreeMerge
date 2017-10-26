using System;

namespace BinaryTreeMerge
{
    class Program
    {
        // Merge binary trees
        static void Main(string[] args)
        {
            Node root1 = Node.NewNode(1);
            root1.left = Node.NewNode(2);
            root1.right = Node.NewNode(3);
            root1.left.left = Node.NewNode(4);
            root1.left.right = Node.NewNode(5);
            root1.right = Node.NewNode(6);

            Node root2 = Node.NewNode(4);
            root2.left = Node.NewNode(1);
            root2.right = Node.NewNode(7);
            root2.left.left = Node.NewNode(3);
            root2.right.left = Node.NewNode(2);
            root2.right.right = Node.NewNode(6);

            Node root3 = Node.MergeBinaryTrees(root1, root2);
            Console.WriteLine("The merged binary tree is:\n");
            Node.InOrderSearch(root3);

            Console.ReadLine();
        }
    }
}
