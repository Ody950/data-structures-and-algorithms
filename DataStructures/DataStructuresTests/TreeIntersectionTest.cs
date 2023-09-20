using System;
using System.Collections.Generic;
using tree_intersection;
using TreeIntersection.BinaryTree;
using Xunit;

namespace TreeIntersectionTest
{
  public class UnitTest1
  {
    [Fact]
    public void TestWithMatches()
    {
      Hashtable ht = new Hashtable(1024);

      BinaryTree testTree1 = new BinaryTree();
      testTree1.Root = new NodeTree(1);
      testTree1.Root.Left = new NodeTree(2);
      testTree1.Root.Right = new NodeTree(3);
      testTree1.Root.Left.Left = new NodeTree(4);
      testTree1.Root.Left.Right = new NodeTree(6);

      BinaryTree testTree2 = new BinaryTree();
      testTree2.Root = new NodeTree(2);
      testTree2.Root.Left = new NodeTree(3);
      testTree2.Root.Right = new NodeTree(8);
      testTree2.Root.Left.Left = new NodeTree(6);
      testTree2.Root.Left.Right = new NodeTree(9);

      IList<int> expected = new List<int> { 6, 3, 2 };
      IList<int> results = ht.TreeIntersection(testTree1, testTree2);

      Assert.Equal(expected, results);
    }

    [Fact]
    public void TestWithoutMatches()
    {
      Hashtable ht = new Hashtable(1024);

      BinaryTree testTree1 = new BinaryTree();
      testTree1.Root = new NodeTree(1);
      testTree1.Root.Left = new NodeTree(2);
      testTree1.Root.Right = new NodeTree(3);
      testTree1.Root.Left.Left = new NodeTree(4);
      testTree1.Root.Left.Right = new NodeTree(5);

      BinaryTree testTree2 = new BinaryTree();
      testTree2.Root = new NodeTree(6);
      testTree2.Root.Left = new NodeTree(7);
      testTree2.Root.Right = new NodeTree(8);
      testTree2.Root.Left.Left = new NodeTree(9);
      testTree2.Root.Left.Right = new NodeTree(10);

      IList<int> expected = new List<int> { };
      IList<int> results = ht.TreeIntersection(testTree1, testTree2);

      Assert.Equal(expected, results);
    }

    [Fact]
    public void TestEmptyTrees()
    {
      Hashtable ht = new Hashtable(1024);

      BinaryTree testTree1 = new BinaryTree();
      BinaryTree testTree2 = new BinaryTree();

      IList<int> expected = new List<int> { };
      IList<int> results = ht.TreeIntersection(testTree1, testTree2);

      Assert.Equal(expected, results);
    }



  }
}
