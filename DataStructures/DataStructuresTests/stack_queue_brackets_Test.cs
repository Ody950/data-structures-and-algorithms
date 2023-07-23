

using System;
using Xunit;
using stackQueueBrackets;



namespace stackQueueBrackets
{
  public class UnitTest1
  {

    [Fact]
    public void Test1()
    {
      string test1 = "()[[Extra Characters]]";

      Assert.True(Brackets.BracketsV(test1));
    }

    [Fact]
    public void Test2()
    {
      string test2 = "{}(){}";

      Assert.True(Brackets.BracketsV(test2));
    }

    [Fact]
    public void Test3()
    {
      string test3 = "[({))}]";

      Assert.False(Brackets.BracketsV(test3));
    }

    [Fact]
    public void Test4()
    {
      string test4 = "[(({]))]";

      Assert.False(Brackets.BracketsV(test4));
    }


  }
}
