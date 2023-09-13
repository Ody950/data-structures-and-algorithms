
using System.Collections;
using HashtableLab;
using Hashtable = HashtableLab.Hashtable;

namespace TestProject1
{
  public class HashtableLabTest1
  {
    [Fact]
    public void HashTest01() // Can Successfully Hash A Key To An In Range Value
    {
      Hashtable table = new Hashtable(1024);
      int value = table.Hash("test1");
      Assert.True(value < table.Size);
    }

    [Fact]
    public void HashTest02() //Handle A Collision With in A HashTable
    {
      Hashtable table = new Hashtable(1024);

      table.Set("Test21", "Test21 text");
      table.Set("21Test", "Test22 text");

      int value1 = table.Hash("Test21");
      int value2 = table.Hash("21Test");

      Assert.Equal(value1, value2);
    }
    [Fact]
    public void SetTest() // Can Add Key-Value Pair To HashTable
    {
      Hashtable table = new Hashtable(1024);

      table.Set("Test3", "Test3 text");
      bool result = table.Has("Test3");

      Assert.True(result);
    }
    [Fact]
    public void GetTest01() // Can Retrieve A Value From A Bucket With Collisions
    {
      Hashtable table = new Hashtable(1024);

      table.Set("Test31", "Test31 text");
      table.Set("Test32", "Test32 text");

      string result1 = table.Get("Test31");
      string result2 = table.Get("Test32");

      string expected1 = "Test31 text";
      string expected2 = "Test32 text";

      Assert.Equal(expected1, result1);
      Assert.Equal(expected2, result2);
    }
    [Fact]
    public void GetTest02() // Can Retrieve Value Based On Key
    {
      Hashtable table = new Hashtable(1024);

      table.Set("Test3", "Test3 text");

      string result = table.Get("Test3");

      string expected = "Test3 text";

      Assert.Equal(expected, result);
    }
    [Fact]
    public void HasTest() // Can Determine If A Key Exists In A HashTable
    {
      Hashtable table = new Hashtable(1024);

      bool exists = table.Has("Test3");

      Assert.False(exists);
    }
  }
}

