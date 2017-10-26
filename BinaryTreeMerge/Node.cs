using System;

namespace BinaryTreeMerge
{
    public class Node
    {
        int data;
        public Node left;
        public Node right;

        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        // Helper method that allocates a new node
        public static Node NewNode(int data)
        {
            return new Node(data, null, null);
        }

        // Given a binary tree, print its node inorder
        public static void InOrderSearch(Node node)
        {
            if (node == null)
                return;

            // recurse left side
            InOrderSearch(node.left);

            // print out the data of the node
            Console.Write("{0}", node.data);

            // recurse right side
            InOrderSearch(node.right);
        }

        // Merge two binary trees
        public static Node MergeBinaryTrees(Node t1, Node t2)
        {
            if(t1 == null)
            {
                return t2;
            }
            if(t2 == null)
            {
                return t1;
            }
            t1.data += t2.data;
            t1.left = MergeBinaryTrees(t1.left, t2.left);
            t1.right = MergeBinaryTrees(t1.right, t2.right);
            return t1;
        }
    }
}
