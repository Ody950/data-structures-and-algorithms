
using stackQueueBrackets;
using System;
using trees;

namespace stackQueueBrackets
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Node n1 = new Node(1);
      Node n2 = new Node(2);
      Node n3 = new Node(3);
      Node n4 = new Node(4);
      Node n5 = new Node(5);
      Node n6 = new Node(6);
      Node n7 = new Node(7);

      BinaryTree treeTest = new BinaryTree(n1);

      treeTest.root.Left = n2;
      treeTest.root.Right = n3;
      treeTest.root.Left.Left = n4;
      treeTest.root.Left.Right = n5;
      treeTest.root.Right.Left = n6;
      treeTest.root.Right.Right = n7;
      */

      BinarySearchTree treeTest = new BinarySearchTree();

      treeTest.Add(2);
      treeTest.Add(1);
      treeTest.Add(3);


      int[] results = treeTest.preOrder(treeTest.root);
      foreach (object i in results)
      {
        Console.Write($"[{i}]");
      }
    }
  }
}

