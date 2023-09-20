using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIntersection.BinaryTree
{
  public class BinaryTree
  {

    public NodeTree Root { get; set; }
    public List<int> ArrayList = new List<int>();

    public BinaryTree(NodeTree node)
    {
      Root = node;
    }

    public BinaryTree()
    {

    }

    public int[] InOrder(NodeTree root)
    {
      try
      {
        if (root.Left != null)
        {
          InOrder(root.Left);
        }

        ArrayList.Add(root.Value);

        if (root.Right != null)
        {
          InOrder(root.Right);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }


      return ArrayList.ToArray();
    }
  }
}
