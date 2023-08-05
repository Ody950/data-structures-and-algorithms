


using System;
using Xunit;
using trees;



namespace trees
{
  public class UnitTest1
  {
    BreadthFirst newBreadthFirst = new BreadthFirst();

    //Test 1
    [Fact]
    public void Test1()
    {
      BinaryTree NewTree = new BinaryTree();

      NewTree.root = (new Node(2));
      NewTree.root.Left = (new Node(7));
      NewTree.root.Right = (new Node(5));
      NewTree.root.Left.Left = (new Node(2));
      NewTree.root.Left.Right = (new Node(6));
      NewTree.root.Right.Left = (new Node(9));
      NewTree.root.Right.Right = (new Node(5));
      NewTree.root.Left.Left.Right = (new Node(11));
      NewTree.root.Right.Right.Left = (new Node(4));

      List<int> MyList = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

      Assert.Equal(MyList, newBreadthFirst.TheBreadthFirst(NewTree));
    }

    //Test 2
    [Fact]
    public void Test2()
    {
      BinaryTree NewTree = new BinaryTree();

      NewTree.root = (new Node(-2));
      NewTree.root.Left = (new Node(7));
      NewTree.root.Right = (new Node(5));
      NewTree.root.Left.Left = (new Node(-2));
      NewTree.root.Left.Right = (new Node(6));
      NewTree.root.Right.Left = (new Node(-9));
      NewTree.root.Right.Right = (new Node(5));
      NewTree.root.Left.Left.Right = (new Node(-11));
      NewTree.root.Right.Right.Left = (new Node(-4));

      List<int> MyList = new List<int> { -2, 7, 5, -2, 6, -9, 5, -11, -4 };

      Assert.Equal(MyList, newBreadthFirst.TheBreadthFirst(NewTree));
    }



    //Test 3
    [Fact]
    public void Test3()
    {
      BinaryTree NewTree = new BinaryTree();

      Exception ex = Assert.Throws<Exception>(() => newBreadthFirst.TheBreadthFirst(NewTree));
      Assert.Equal(" The tree is Empty", ex.Message);
    }
  }
}

