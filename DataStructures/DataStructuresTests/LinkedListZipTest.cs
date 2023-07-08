

using System;
using Xunit;
using SinglyLinkedLists;
namespace SinglyLinkedListTest
{
  public class UnitTest1
  {
    [Fact]
    public void EmptylinkedTest()

    {

      LinkedList list = new LinkedList();
      Assert.Equal("Head -> NULL", list.ToString());

    }


    public void InsertBeforeTestmiddleOfLinkedList()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.InsertBefore(5, 13);
      Assert.Equal("Head -> [13] -> [5] -> [10] -> [15] -> [20] -> NULL", list.ToString());
    }

    [Fact]
    public void InsertBeforeTestFirstOfLinkedList()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.InsertBefore(15, 13);
      Assert.Equal("Head -> [5] -> [10] -> [13] -> [15] -> [20] -> NULL", list.ToString());
    }


    [Fact]

    public void InsertAfterTestTestmiddleOfLinkedList()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.InsertAfter(15, 17);
      Assert.Equal("Head -> [5] -> [10] -> [15] -> [17] -> [20] -> NULL", list.ToString());
    }


    public void InsertAfterTestFirstOfLinkedList()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.InsertAfter(5, 17);
      Assert.Equal("Head -> [17] -> [5] -> [10] -> [15] -> [20] -> NULL", list.ToString());
    }

    [Fact]
    public void ReturnTrueTest()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      bool expected = true;
      Assert.Equal(expected, list.Includes(15));
    }

    [Fact]
    public void ReturnFalseTest()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      bool expected = false;
      Assert.Equal(expected, list.Includes(18));
    }


    [Fact]

    public void CollectionValuesTest()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.Append(25);
      list.Append(30);
      list.Append(35);
      list.Append(40);
      Assert.Equal("Head -> [5] -> [10] -> [15] -> [20] -> [25] -> [30] -> [35] -> [40] -> NULL", list.ToString());
    }


    //Where k is greater than the length of the linked list
    [Fact]
    public void KthTest()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.Append(25);
      list.Append(30);
      list.Append(35);
      list.Append(40);
      Assert.Equal(0, list.Kth(10));
    }



    //Where k and the length of the list are the same
    [Fact]
    public void KthTest2()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.Append(25);
      list.Append(30);
      list.Append(35);
      list.Append(40);
      Assert.Equal(5, list.Kth(8));
    }


    //Where k is not a positive integer
    [Fact]
    public void KthTest3()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.Append(25);
      list.Append(30);
      list.Append(35);
      list.Append(40);
      Assert.Equal(0, list.Kth(-8));
    }


    //Where the linked list is of a size 1
    [Fact]
    public void KthTest4()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      Assert.Equal(5, list.Kth(1));
    }




    //“Happy Path” where k is not at the end, but somewhere in the middle of the linked list
    [Fact]
    public void KthTest5()
    {
      LinkedList list = new LinkedList();
      list.Append(5);
      list.Append(10);
      list.Append(15);
      list.Append(20);
      list.Append(25);
      list.Append(30);
      list.Append(35);
      list.Append(40);
      Assert.Equal(25, list.Kth(4));
    }


    // LinkedList Zip Test
    [Fact]
    public void LinkedListZipTest1()
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

      Assert.Equal("Head -> [5] -> [1] -> [10] -> [11] -> [15] -> [111] -> [20] -> [1111] -> [25] -> [11111] -> NULL", listeC.ToString());
    }

    // LinkedList Zip Test the listB is null
    [Fact]
    public void LinkedListZipTes2()
    {
      LinkedList listA = new LinkedList();
      listA.Append(5);
      listA.Append(10);
      listA.Append(15);
      listA.Append(20);
      listA.Append(25);

      LinkedList listB = new LinkedList();

      LinkedList liste = new LinkedList();
      LinkedList listeC = liste.LinkedListZip(listA, listB);

      Assert.Equal("Head -> [5] -> [10] -> [15] -> [20] -> [25] -> NULL", listeC.ToString());
    }


    // LinkedList Zip Test the listA is null

    [Fact]
    public void LinkedListZipTes3()
    {
      LinkedList listA = new LinkedList();


      LinkedList listB = new LinkedList();
      listB.Append(1);
      listB.Append(11);
      listB.Append(111);
      listB.Append(1111);
      listB.Append(11111);
      LinkedList liste = new LinkedList();

      LinkedList listeC = liste.LinkedListZip(listA, listB);

      Assert.Equal("Head -> [1] -> [11] -> [111] -> [1111] -> [11111] -> NULL", listeC.ToString());
    }

    // LinkedList Zip Test, the lists dont have the same node number 
    [Fact]
    public void LinkedListZipTest4()
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


      LinkedList liste = new LinkedList();
      LinkedList listeC = liste.LinkedListZip(listA, listB);

      Assert.Equal("Head -> [5] -> [1] -> [10] -> [11] -> [15] -> [20] -> [25] -> NULL", listeC.ToString());
    }
  }
}


