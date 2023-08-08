

using System;
using Xunit;
using trees;
using static trees.Node;
using static trees.KAryTree;

namespace trees
{
  public class UnitTest1
  {

    [Fact]
    public void Test1()
    {
      KAryTree MyTree = new KAryTree();

      Exception ex = Assert.Throws<Exception>(() => MyTree.FizzBuzzTree(null));
      Assert.Equal("The Tree Is Empty!!", ex.Message);
    }



    [Fact]
    public void Test2()
    {
      KAryTree MyTree = new KAryTree();

      Node root = new Node("1");
      root.Children.Add(new Node("2"));
      root.Children[0].Children.Add(new Node("4"));
      root.Children[0].Children.Add(new Node("5"));
      root.Children[0].Children.Add(new Node("6"));
      root.Children.Add(new Node("3"));
      root.Children[1].Children.Add(new Node("7"));
      root.Children[1].Children.Add(new Node("8"));

      List<string> list = MyTree.FizzBuzzTree(root);

      Assert.Equal(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8" }, list);
    }
    [Fact]
    public void Test3()
    {
      KAryTree MyTree = new KAryTree();

      Node root = new Node("-1");
      root.Children.Add(new Node("-2"));
      root.Children[0].Children.Add(new Node("-4"));
      root.Children[0].Children.Add(new Node("5"));
      root.Children[0].Children.Add(new Node("-6"));
      root.Children.Add(new Node("-3"));
      root.Children[1].Children.Add(new Node("-7"));
      root.Children[1].Children.Add(new Node("-8"));

      List<string> list = MyTree.FizzBuzzTree(root);

      Assert.Equal(new List<string> { "-1", "-2", "Fizz", "-4", "Buzz", "Fizz", "-7", "-8" }, list);
    }
  }
}

