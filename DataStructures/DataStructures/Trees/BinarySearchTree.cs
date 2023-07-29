
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trees;

namespace trees
{
  public class BinarySearchTree : BinaryTree
  {

    public void Add(int value)
    {
      Node theNode = new Node(value);

      if (root == null)
      {
        root = theNode;
      }
      Node current = root;
      Node parent = null;

      while (current != null)
      {
        if (value == current.Value)
        {
          return;
        }
        else if (value < current.Value)
        {
          parent = current;
          current = current.Left;
        }
        else
        {
          parent = current;
          current = current.Right;
        }
      }

      if (parent.Value > value)
      {
        parent.Left = theNode;
      }
      else
      {
        parent.Right = theNode;
      }
    }

    public bool Contains(int value)
    {
      Node TheNode = root;
      while (TheNode != null)
      {
        if (TheNode.Value == value)
        {
          return true;
        }
        if (TheNode.Value > value)
        {
          TheNode = TheNode.Left;
        }
        else
        {
          TheNode = TheNode.Right;
        }
      }
      return false;
    }

  }
}
