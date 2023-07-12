
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StackQueue.Program;

namespace StackQueue
{
  public class QueueClass
  {

    public Node Front { get; set; }
    public Node Back { get; set; }


    public void Enqeue(int value)
    {
      if (Front == null)
      {
        Node NewNode = new Node(value);
        Front = Back = NewNode;
      }
      else
      {
        Node NewNode = new Node(value);
        Back.Next = NewNode;
        Back = NewNode;
      }

    }

    public int Dequeue()
    {
      if (Front == null)
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        Node currentPostion = Front;
        Front = Front.Next;
        currentPostion.Next = null;
        return currentPostion.Value;
      }

    }

    public int peek()
    {
      if (Back == null)
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        Node ThePeek = Front;
        return ThePeek.Value;
      }
    }
    public bool IsEmpty()
    {
      if (Front == null)
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

