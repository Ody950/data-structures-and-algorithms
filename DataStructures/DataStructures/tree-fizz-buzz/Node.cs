

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees
{
  public class Node
  {
    public string Value { get; set; }
    public List<Node> Children { get; set; }
    public Node()
    {
      Value = null;
    }
    public Node(string value)
    {
      Value = value;
      Children = new List<Node>();
    }
  }

}


