
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trees;

namespace trees
{
  public class BinaryTree
  {

    public List<int> TheList = new List<int>();

    public Node root;

    //Can successfully instantiate an empty tree
    public BinaryTree()
    {
      root = null;

    }
    // an successfully instantiate a tree with a single root node
    public BinaryTree(Node newNode)
    {
      root = newNode;
    }


    public int[] preOrder(Node root) // root >> left >> right
    {
      if (root == null)
      {
        throw new Exception(" The tree is Empty");
      }

      TheList.Add(root.Value);

      if (root.Left != null)
      {
        preOrder(root.Left);
      }

      if (root.Right != null)
      {
        preOrder(root.Right);
      }
      return TheList.ToArray();
    }


    public int[] inOrder(Node root)  // left >> root >> right
    {
      if (root == null)
      {
        throw new Exception(" The tree is Empty");
      }


      if (root.Left != null)
      {
        inOrder(root.Left);

      }

      TheList.Add(root.Value);

      if (root.Right != null)
      {
        inOrder(root.Right);
      }
      return TheList.ToArray();
    }

    public int[] postOrder(Node root)  // left >> right >> root
    {
      if (root == null)
      {
        throw new Exception(" The tree is Empty");
      }


      if (root.Left != null)
      {
        postOrder(root.Left);

      }

      if (root.Right != null)
      {
        postOrder(root.Right);
      }

      TheList.Add(root.Value);
      return TheList.ToArray();
    }


    public int TheMax(BinaryTree tree)
    {

      if (tree.root.Value == null)
      {
        return 0;
      }

      int[] treeValues = preOrder(tree.root);

      int max = treeValues[0];
      foreach (int x in treeValues)
      {
        if (x > max)
          max = x;
      }

      return max;
    }


  }
}
