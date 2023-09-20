using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIntersection.BinaryTree
{
  public class NodeTree
  {
    public int Value { get; set; }
    public NodeTree Right { get; set; }
    public NodeTree Left { get; set; }

    
    public NodeTree(int value)
    {
      Value = value;
      Left = Right = null;
    }
  }
}
