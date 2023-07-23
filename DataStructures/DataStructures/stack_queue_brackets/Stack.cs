

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace stackQueueBrackets
{
  public class StackClass
  {
    public Node Top { get; set; }


    public void Push(int value)
    {
      Node NewNode = new Node(value);
      NewNode.Next = Top;
      Top = NewNode;

    }

    public int Pop()
    {
      if (Top == null)
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        Node currentPostion = Top;
        Top = Top.Next;
        currentPostion.Next = null;
        return currentPostion.Value;
      }

    }

    public int peek()
    {
      if (Top == null)
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        Node ThePeek = Top;
        return ThePeek.Value;
      }
    }
    public bool IsEmpty()
    {
      if (Top == null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

