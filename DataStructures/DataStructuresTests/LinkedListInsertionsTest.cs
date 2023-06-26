
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
      list.InsertBefore(10, 13);
      Assert.Equal("Head -> [5] -> [13] -> [10] -> [15] -> [20] -> NULL", list.ToString());
    }

    [Fact]
    public void InsertBeforeTestFirstOfLinkedList()
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
      Assert.Equal("Head -> [5] -> [17] -> [10] -> [15] -> [20] -> NULL", list.ToString());
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

  }
}
