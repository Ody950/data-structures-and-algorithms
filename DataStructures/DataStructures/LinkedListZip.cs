
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


    
  public static bool IsPalindrome(Node head)
{
    if (head == null || head.Next == null)
        return true;

    // Step 1: Find the middle of the linked list
    Node slow = head;
    Node fast = head;
    Node prevSlow = null;

    while (fast != null && fast.Next != null)
    {
        prevSlow = slow; // Keep track of the previous slow pointer
        slow = slow.Next;
        fast = fast.Next.Next;
    }

    // If 'fast' is not null, it means the list has an odd number of elements, so skip the middle node
    if (fast != null)
    {
        prevSlow.Next = slow.Next; // Skip the middle node
        slow = prevSlow.Next; // Move slow pointer to the new middle
    }

    // Step 2: Reverse the second half of the linked list
    Node reversedSecondHalf = ReverseLinkedList(slow);

    // Step 3: Compare the first half with the reversed second half
    Node firstHalf = head;
    while (reversedSecondHalf != null)
    {
        if (firstHalf.Value != reversedSecondHalf.Value)
            return false;

        firstHalf = firstHalf.Next;
        reversedSecondHalf = reversedSecondHalf.Next;
    }

    return true;
}

// Helper function to reverse a linked list
private static Node ReverseLinkedList(Node head)
{
    Node prev = null;
    Node current = head;
    Node next;

    while (current != null)
    {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;
    }

    return prev;
}

/////////////////////////////////////////////////////////////////////////////////////////////////
    Certainly, let's walk through how the modified code works for the linked list ({t}->{a}->{c}->{o}->{c}->{a}->{t}):

1. **Initialize the linked list**: You have a linked list with the following nodes: "t" -> "a" -> "c" -> "o" -> "c" -> "a" -> "t".

2. **Step 1: Find the middle of the linked list**:

   - Initialize `slow` and `fast` pointers to the head of the list, which is "t".

   - Iterate through the list using the two-pointer approach. `slow` moves one step at a time, and `fast` moves two steps at a time.

   - After a few iterations, `slow` and `fast` will meet at the middle node "o". The `while` loop stops.

   - Because the list has an odd number of elements, we also keep track of the `prevSlow` pointer, which points to the node just before the middle node.

3. **Skip the middle node (since the list is odd)**:

   - We skip the middle node "o" by updating the `prevSlow.Next` pointer to point to the node after the middle node. This effectively removes the middle node from the list. The list becomes: "t" -> "a" -> "c" -> "c" -> "a" -> "t".

4. **Step 2: Reverse the second half of the linked list**:

   - Call the `ReverseLinkedList` function with the new middle node "c". The reversed second half becomes: "t" -> "a" -> "c".

5. **Step 3: Compare the first half with the reversed second half**:

   - Initialize `firstHalf` pointer to the head, which is "t".

   - Compare the values of `firstHalf` and `reversedSecondHalf` nodes one by one while traversing the two halves.

   - In this case, the comparison proceeds as follows:

     - "t" (firstHalf) == "t" (reversedSecondHalf) - They match.
     - "a" (firstHalf) == "a" (reversedSecondHalf) - They match.
     - "c" (firstHalf) == "c" (reversedSecondHalf) - They match.

6. **Return `true`**: Since all values in the first half match the values in the reversed second half, the function returns `true`.

So, the function correctly identifies that the input linked list ({t}->{a}->{c}->{o}->{c}->{a}->{t}) is a palindrome and returns `true`.

  }
}
