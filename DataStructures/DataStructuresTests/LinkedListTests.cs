

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


    [Fact]
    public void TestInsert()       
    {
      LinkedList list = new LinkedList();
      list.Insert(5);
      list.Insert(10);
      list.Insert(15);

      list.Insert(3);
      Assert.Equal("Head -> [3] -> [5] -> [10] -> [15] -> NULL", list.ToString());
    }


    [Fact]
    public void InsertBeforeTest()
    {
      LinkedList list = new LinkedList();
      list.Add(5);
      list.Add(10);
      list.Add(15);
      list.Add(20);
      list.InsertBefore(15, 13);
      Assert.Equal("Head -> [5] -> [10] -> [13] -> [15] -> [20] -> NULL", list.ToString());
    }


    [Fact]

    public void InsertAfterTest()
    {
      LinkedList list = new LinkedList();
      list.Add(5);
      list.Add(10);
      list.Add(15);
      list.Add(20);
      list.InsertAfter(15, 17);
      Assert.Equal("Head -> [5] -> [10] -> [15] -> [17] -> [20] -> NULL", list.ToString());
    }




    [Fact]
    public void ReturnTrueTest()
    {
      LinkedList list = new LinkedList();
      list.Add(5);
      list.Add(10);
      list.Add(15);
      list.Add(20);
      bool expected = true;
      Assert.Equal(expected, list.Includes(15));
    }

    [Fact]
    public void ReturnFalseTest()
    {
      LinkedList list = new LinkedList();
      list.Add(5);
      list.Add(10);
      list.Add(15);
      list.Add(20);
      bool expected = false;
      Assert.Equal(expected, list.Includes(18));
    }


    [Fact]

    public void CollectionValuesTest()
    {
      LinkedList list = new LinkedList();
      list.Add(5);
      list.Add(10);
      list.Add(15);
      list.Add(20);
      list.Add(25);
      list.Add(30);
      list.Add(35);
      list.Add(40);
      Assert.Equal("Head -> [5] -> [10] -> [15] -> [20] -> [25] -> [30] -> [35] -> [40] -> NULL", list.ToString());
    }

  }
}



