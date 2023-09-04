
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace SinglyLinkedLists
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList listA = new LinkedList();
      listA.Append(5);
      listA.Append(10);
      listA.Append(15);
      listA.Append(20);
      listA.Append(25);

      LinkedList listB = new LinkedList();
      listB.Append(1);
      listB.Append(11);
      listB.Append(111);
      listB.Append(1111);
      listB.Append(11111);

      LinkedList liste = new LinkedList();
      LinkedList listeC = liste.LinkedListZip(listA, listB);
      Console.WriteLine(listeC.ToString());

      /*
      Console.WriteLine("The linked list contained value 20?");
      Console.WriteLine(list.Includes(20));
      Console.WriteLine(list.ToString());

      list.InsertBefore(5, 77);
      Console.WriteLine(list.ToString());

      list.InsertAfter(15, 17);
      Console.WriteLine(list.ToString());


      list.InsertAfter(20, 17);
      Console.WriteLine(list.ToString());

      list.InsertAt(1, 3);
      Console.WriteLine(list.ToString());


      Console.WriteLine(list.Kth(6)); 
      */
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
          Node newNode = new Node(newValue);
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



    //  kth 
    public int Kth(int k)
    {
      if (Head == null)
      {
        Console.WriteLine("Empty list");
        return 0;
      }

      if (k < 0)
      {
        Console.WriteLine("k value should be more than zero");
        return 0;
      }

      Node Curent = Head;
      int C1 = 0;
      int C2 = 0;
      int Output = 1;

      while (Curent != null)
      {
        C1++;
        Curent = Curent.Next;
      }

      if (k > C1)
      {
        Console.WriteLine("the Node in list is less than the parameter");
        return 0;
      }

      Curent = Head;

      while (Curent != null)
      {
        C2++;
        if (C2 == (C1 - k + 1))
        {
          Output = Curent.Data;
          break;
        }
        else
        {
          Curent = Curent.Next;
        }
      }

      return Output;
    }


    public LinkedList LinkedListZip(LinkedList ListA, LinkedList ListB)
    {

      Node CurrentA = ListA.Head;
      Node CurrentB = ListB.Head;

      if (CurrentA == null)
      {
        return ListB;
      }

      if (CurrentB == null)
      {
        return ListA;
      }

      while (CurrentB != null)
      {
        Node whileNode = CurrentA.Next;
        CurrentA.Next = CurrentB;
        CurrentB = whileNode;
        CurrentA = CurrentA.Next;
      }
      return ListA;


    }


    
   public static bool IsPalindrome(ListNode head)
{
    // Check if the linked list is empty or has only one element
    if (head == null || head.Next == null)
        return true;

    // Step 1: Find the middle of the linked list
    ListNode slow = head; // Initialize a slow pointer to the head
    ListNode fast = head; // Initialize a fast pointer to the head

    while (fast != null && fast.Next != null)
    {
        slow = slow.Next; // Move the slow pointer one step
        fast = fast.Next.Next; // Move the fast pointer two steps
    }

    // At the end of this loop, 'slow' points to the middle of the linked list

    // Step 2: Reverse the second half of the linked list
    ListNode reversedSecondHalf = ReverseLinkedList(slow);

    // Step 3: Compare the first half with the reversed second half
    ListNode firstHalf = head; // Initialize a pointer to the head

    while (reversedSecondHalf != null)
    {
        if (firstHalf.Value != reversedSecondHalf.Value)
            return false; // If values do not match, it's not a palindrome

        firstHalf = firstHalf.Next; // Move the pointer in the first half
        reversedSecondHalf = reversedSecondHalf.Next; // Move the pointer in the reversed second half
    }

    // If the loop completes without returning false, it's a palindrome
    return true;
}

// Helper function to reverse a linked list
private static ListNode ReverseLinkedList(ListNode head)
{
    ListNode prev = null; // Initialize a 'prev' pointer to null
    ListNode current = head; // Start with the head of the linked list
    ListNode next;

    while (current != null)
    {
        next = current.Next; // Save the next node
        current.Next = prev; // Reverse the pointer direction
        prev = current; // Move 'prev' to the current node
        current = next; // Move 'current' to the next node
    }

    // At the end of this loop, 'prev' points to the new head of the reversed linked list
    return prev;
}

  }
}
