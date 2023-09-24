
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Join
{
  public class LinkedList
  {
    public Node Head { get; set; } = null;
    public Node Current { get; set; }
    public LinkedList() { } 
    public LinkedList(Node node) 
    {
      Head = node;
    }
    public void Append(Object key, Object value)
    {
      if (Head == null)
      {
        Node node = new Node(key, value);
        Head = node;
      }
      else
      {
        Current = Head;

        while (Current.Next != null)
        {
          Current = Current.Next;
        }

        Node node = new Node(key, value);

        Current.Next = node;
      }
    }
    public Object Find(Object key)
    {
      Current = Head;
      while (Current != null)
      {
        if (Current.Key.Equals(key))
        {
          return Current.Value;
        }
        else
        {
          Current = Current.Next;
        }
      }
      return null;
    }
  }
}
