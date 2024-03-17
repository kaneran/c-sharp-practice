using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    // Example Binary tree data structure:
    //          1
    //         / \
    //        7   9
    //       / \   \
    //      2   6   9
    //         / \  /
    //        5  11 5
    public static class BinaryTree
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Value { get; set; }
        }

        private static void InsertNodeLeft(Node current, Node newNode)
        {
            current.Left = newNode;
        }
        private static void InsertNodeRight(Node current, Node newNode)
        {
            current.Right = newNode;
        }

        private static Node CreateBinaryTree()
        {
            var rootNode = new Node() { Value = 1 };
            var leftNode = new Node() { Value = 7 };
            var rightNode = new Node() { Value = 9 };
            InsertNodeLeft(rootNode, leftNode);
            InsertNodeRight(rootNode, rightNode);

            var leftNode2 = new Node() { Value = 2 };
            var rightNode2 = new Node() { Value = 6 };
            InsertNodeLeft(leftNode, leftNode2);
            InsertNodeRight(leftNode, rightNode2);

            var leftNode3 = new Node() { Value = 5 };
            var rightNode3 = new Node() { Value = 11 };
            InsertNodeLeft(rightNode2, leftNode3);
            InsertNodeRight(rightNode2, rightNode3);

            var rightNode4 = new Node() { Value = 9 };
            InsertNodeRight(rightNode, rightNode4);

            var leftNode4 = new Node() { Value = 5 };
            InsertNodeLeft(rightNode4, leftNode4);

            return rootNode;
        }

        public static void TraverseBinaryTree()
        {
            var rootNode = CreateBinaryTree();
            ProcessNodePostOrder(rootNode);
        }

        private static void ProcessNodePreOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                ProcessNodePreOrder(node.Left);
                ProcessNodePreOrder(node.Right);
            }
        }

        private static void ProcessNodeInOrder(Node node)
        {
            if (node != null)
            {
                ProcessNodeInOrder(node.Left);
                Console.WriteLine(node.Value);
                ProcessNodeInOrder(node.Right);
            }
        }

        private static void ProcessNodePostOrder(Node node)
        {
            if (node != null)
            {
                ProcessNodePostOrder(node.Left);
                ProcessNodePostOrder(node.Right);
                Console.WriteLine(node.Value);
            }
        }

    }
}
