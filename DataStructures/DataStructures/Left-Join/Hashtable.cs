
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Join
{
  public class Hashtable
  {
    public int Size { get; set; }
    public LinkedList[] Table { get; set; }
    public Hashtable(int size)
    {
      Size = size;
      Table = new LinkedList[size];
    }

    public int Hash(string key)
    {
      int total = 0;
      char[] letters = key.ToCharArray();

      for (int i = 0; i < letters.Length; i++)
      {
        total += letters[i];
      }

      int primeValue = total * 599;
      int index = primeValue % Table.Length;

      return index;
    }
    public void Set(string key, string value)
    {
      int index = Hash(key);

      if (Table[index] == null)
      {
        LinkedList ll = new LinkedList();
        Node newNode = new Node(key, value);
        ll.Append(newNode);
        Table[index] = ll;
      }
      else
      {
        Node newNode = new Node(key, value);
        Table[index].Append(newNode);
      }
    }

    public string Get(string key)
    {
      int index = Hash(key);
      var bucket = Table[index];
      bucket.Current = bucket.Head;
      Node current = bucket.Current;

      while (current.Key != key)
      {
        current = current.Next;
      }

      if (current.Key == key)
      {
        return current.Value;
      }
      return null;
    }


    public List<string> LeftJoin(Hashtable mapA, Hashtable mapB)
    {
      List<string> list = new List<string>();
      string temp = "";
      foreach (LinkedList item in mapA.Table)
      {
        if (item != null)
        {
          item.Current = item.Head;
          while (item.Current != null)
          {
            temp = (string)(mapB.Get(item.Current.Key)) ?? "NULL";
            temp = $"{(string)item.Current.Key}, {(string)item.Current.Value}, {temp}";
            list.Add(temp);
            temp = "";
            item.Current = item.Current.Next;
          }
        }
      }
      return list;
    }


  }
}
