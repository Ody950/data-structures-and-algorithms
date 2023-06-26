
using System;

namespace SinglyLinkedLists
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.Append(25);

      Console.WriteLine("The linked list contained value 20?");
      Console.WriteLine(list.Includes(20));
      Console.WriteLine(list.ToString());

      list.InsertAfter(15, 17);
      Console.WriteLine(list.ToString());


      list.InsertAfter(20, 17);
      Console.WriteLine(list.ToString());

      list.InsertAt(15, 3);
      Console.WriteLine(list.ToString());

    }
  }



  public class Node
  {
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
      Data = data;
      Next = null;
    }
  }




  public class LinkedList
  {
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public Node Current { get; set; }


    public void Append(int value)
    {
      Node newNode = new Node(value);
      if (Head == null)
      {
        Head = newNode;
        Tail = newNode;
      }
      else
      {
        Tail.Next = newNode;
        Tail = newNode;
      }

    }


    // by position 

    public void InsertAt(int data, int position)
    {
      Node newNode = new Node(data);
      Node previousNode = null;
      Node currentNode = Head;
      int currentPostion = 0;

      while (currentNode != null && currentPostion < position)
      {
        previousNode = currentNode;
        currentNode = currentNode.Next;
        currentPostion++;

      }

      if (currentPostion == position)
      {
        previousNode.Next = newNode;
        newNode.Next = currentNode;

        if (currentNode == null)
        {
          Tail = newNode;
        }
      }
      else
      {
        Console.WriteLine("Posion out of range.");
      }
    }




    // by Value 

    public void InsertBefore(int value, int newValue)
    {
      Current = Head;
      if (Current != null)
      {
        if (Current.Data == value)
        {
          Node newNode = new Node(value);
          newNode.Next = Head;
          Head = newNode;

          return;
        }
        while (Current.Next != null)
        {
          if (Current.Next.Data == value)
          {
            Node newNode = new Node(newValue);
            newNode.Next = Current.Next;
            Current.Next = newNode;
            return;
          }
          Current = Current.Next;
        }
        Console.WriteLine($"{value} not found");
      }
      else
      {
        Console.WriteLine("Empty list");
      }
    }




    public void InsertAfter(int value, int newValue)
    {
      Current = Head;
      if (Current != null)
      {
        while (Current.Next != null)
        {
          if (Current.Data == value)
          {
            Node newNode = new Node(newValue);
            newNode.Next = Current.Next;
            Current.Next = newNode;
            return;
          }
          Current = Current.Next;
        }

        Console.WriteLine($"{value} not found");
      }
      else
      {
        Console.WriteLine("Empty list");
      }
    }





    public bool Includes(int value)
    {
      if (Head == null) return false;

      Node Current = Head;
      while (Current != null)
      {
        if (Current.Data == value) return true;
        Current = Current.Next;
      }
      return false;
    }





    public string ToString()
    {
      Node Start = Head;
      string result = "Head -> ";
      while (Start != null)
      {
        result += $"[{Start.Data}] -> ";
        Start = Start.Next;
      }
      return result + "NULL";
    }


  }
}


