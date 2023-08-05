

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees
{
  public class BreadthFirst
  {
    public List<int> TheBreadthFirst(BinaryTree Tree)
    {
      if (Tree.root == null)
      {
        throw new Exception(" The tree is Empty");
      }

      Node current = Tree.root;
      Queue<Node> NewQueue = new Queue<Node>();
      List<int> NewList = new List<int>();
      NewQueue.Enqueue(current);

      while (NewQueue.Count > 0)
      {
        current = NewQueue.Dequeue();
        NewList.Add(current.Value);

        if (current.Left != null)
        {
          NewQueue.Enqueue(current.Left);
        }
        if (current.Right != null)
        {
          NewQueue.Enqueue(current.Right);
        }
      }
      return NewList;
    }
  }
}

