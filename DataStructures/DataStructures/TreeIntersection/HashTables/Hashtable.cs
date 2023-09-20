
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableLab
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

    public bool Has(string key)
    {
      int index = Hash(key);

      if (Table[index] != null)
      {
        var bucket = Table[index];
        bucket.Current = bucket.Head;
        Node current = bucket.Current;

        while (current != null)
        {
          if (current.Key == key)
          {
            return true;
          }
          current = current.Next;
        }
        return false;
      }
      return false;
    }


    public IList<int> TreeIntersection(BinaryTree t1, BinaryTree t2)
    {
      IList<int> t1Vals = t1.InOrder(t1.Root);
      IList<int> t2Vals = t2.InOrder(t2.Root);
      List<int> sharedValues = new List<int>();
      Hashtable treeTable = new Hashtable(1024);

      foreach (int val in t1Vals)
      {
        treeTable.Set(val, val);
      }

      foreach (int val in t2Vals)
      {
        if (treeTable.Contains(val))
        {
          sharedValues.Add(val);
        }
      }

      return sharedValues;
    }

  }
}
