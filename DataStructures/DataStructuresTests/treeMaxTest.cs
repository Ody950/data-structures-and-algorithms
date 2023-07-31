

using System;
using Xunit;
using trees;



namespace trees
{
  public class UnitTest1
  {

    [Fact]
    public void Test7()   // one max value 
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

      Assert.Equal(7, treeTest.TheMax(treeTest));
    }


    [Fact]
    public void Test8()   //  equal several max value
    {
      Node n1 = new Node(8);
      Node n2 = new Node(3);
      Node n3 = new Node(8);
      Node n4 = new Node(4);
      Node n5 = new Node(8);
      Node n6 = new Node(1);
      Node n7 = new Node(8);

      BinaryTree treeTest = new BinaryTree(n1);
      treeTest.root.Left = n2;
      treeTest.root.Right = n3;
      treeTest.root.Left.Left = n4;
      treeTest.root.Left.Right = n5;
      treeTest.root.Right.Left = n6;
      treeTest.root.Right.Right = n7;

      Assert.Equal(8, treeTest.TheMax(treeTest));
    }

    [Fact]
    public void Test9()   // one max minus value 
    {
      Node n1 = new Node(-1);
      Node n2 = new Node(-2);
      Node n3 = new Node(-3);
      Node n4 = new Node(-4);
      Node n5 = new Node(-5);
      Node n6 = new Node(-6);
      Node n7 = new Node(-7);

      BinaryTree treeTest = new BinaryTree(n1);
      treeTest.root.Left = n2;
      treeTest.root.Right = n3;
      treeTest.root.Left.Left = n4;
      treeTest.root.Left.Right = n5;
      treeTest.root.Right.Left = n6;
      treeTest.root.Right.Right = n7;

      Assert.Equal(-1, treeTest.TheMax(treeTest));
    }



  }
}

