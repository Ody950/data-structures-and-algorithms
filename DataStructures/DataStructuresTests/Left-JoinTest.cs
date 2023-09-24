using Left_Join;
using System;
using System.Collections.Generic;
using Xunit;

namespace Left_JoinTest
{
  public class UnitTest1
  {
    [Fact]
    public void TestMatch()
    {
      Hashtable tableOne = new Hashtable(1024);
      tableOne.Set("diligent", "employed");

      Hashtable tableTwo = new Hashtable(1024);
      tableTwo.Set("diligent", "idle");

      List<string> results = tableOne.LeftJoin(tableOne, tableTwo);

      List<string> expected = new List<string>();
      expected.Add("diligent, employed, idle");

      Assert.Equal(expected, results);
    }

    [Fact]
    public void TestNoMatch()
    {
      Hashtable tableOne = new Hashtable(1024);
      tableOne.Set("wrath", "anger");

      Hashtable tableTwo = new Hashtable(1024);

      List<string> results = tableOne.LeftJoin(tableOne, tableTwo);

      List<string> expected = new List<string>();
      expected.Add("wrath, anger, NULL");

      Assert.Equal(expected, results);
    }

  }
}
