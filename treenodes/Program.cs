using System;
using static System.Console;

namespace program
{
    class Program
    {
        public class Node
        {
            public int? val;
            public Node? Left = null;
            public Node? Right = null;
            public Node(int? Val){ 
                if(Val == null){
                    val = 0;
                }else{
                    val = Val;
                }
            } 
        }
        public static int j = 0;
        public class Tree
        {
            Node? tree;
            public Tree() => tree = null;

            public Node Create(int? head){
                tree = new Node(head);
                return tree;
            }

            public void PreOrder(Node? tree)
            {
                if (tree != null)
                {
                    Write(tree.val + "  ");
                    PreOrder(tree.Left);
                    PreOrder(tree.Right);
                }
            }
            public void InvertedPreOrder(Node tree)
            {
                if (tree != null)
                {
                    Write(tree.val + "  ");
                    InvertedPreOrder(tree.Right);
                    InvertedPreOrder(tree.Left);
                }
            }
        }
        static void Main(String[] args)
        {
            Tree tree = new Tree();
            Node treeNode = tree.Create(9);

            treeNode.Left = new Node(7);
            treeNode.Right = new Node(11);

            treeNode.Left.Left = new Node(null);
            treeNode.Left.Right = new Node(10);

            treeNode.Left.Right.Left = new Node(4);
            treeNode.Left.Right.Right = new Node(null);

            treeNode.Right.Left = new Node(8);
            treeNode.Right.Right = new Node(null);

            treeNode.Right.Left.Left = new Node(null);
            treeNode.Right.Left.Right = new Node(13);

            WriteLine("PreOrder: ");
            tree.PreOrder(treeNode);
            WriteLine();
            WriteLine("Inverted PreOrder: ");
            tree.InvertedPreOrder(treeNode);
        }
    }
}
