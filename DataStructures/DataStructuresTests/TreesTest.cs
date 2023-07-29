

using System;
using Xunit;
using stackQueueBrackets;



namespace trees
{
  public class UnitTest1
  {

    [Fact]         //Can successfully instantiate an empty tree
    public void Test1()
    {
      BinaryTree testTree = new BinaryTree();

      Assert.Null(testTree.root);
    }


    [Fact]         //Can successfully instantiate an empty tree
    public void Test2()
    {
      BinaryTree testTree = new BinaryTree();

      testTree.root = new Node(76);

      Assert.NotNull(testTree.root);
    }



    [Fact]
    public void Test3()   // Can successfully return a collection from a pre-order traversal
    {
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

      Assert.Equal(new List<int> { 1, 2, 4, 5, 3, 6, 7 }, treeTest.preOrder(treeTest.root));
    }



    [Fact]
    public void Test4()   // Can successfully return a collection from an in-order traversal
    {
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

      Assert.Equal(new List<int> { 4, 2, 5, 1, 6, 3, 7 }, treeTest.inOrder(treeTest.root));
    }




    [Fact]
    public void Test5()   //For a Binary Search Tree, can successfully add a left child and right child properly to a node
    {

      BinarySearchTree treeTestx = new BinarySearchTree();

      treeTestx.Add(2);
      treeTestx.Add(1);
      treeTestx.Add(3);


      Assert.Equal(new List<int> { 2, 1, 3 }, treeTestx.postOrder(treeTestx.root));
    }



    [Fact]
    public void Test6()   //Returns true	false for the contains method, given an existing or non-existing node value
    {

      BinarySearchTree treeTest = new BinarySearchTree();

      treeTest.Add(2);
      treeTest.Add(1);
      treeTest.Add(3);



      Assert.True(treeTest.Contains(3));
      Assert.False(treeTest.Contains(16));
    }



  }
}
