
using System.Collections;
using RepeatedWordLab;
using RepeatedWord = RepeatedWordLab.Hashtable;

namespace TestProject1
{
  public class UnitTest1
  {
    [Fact]
    public void NoRepeatsTest()
    {
      Hashtable hashtable = new Hashtable(1024);
      string testString = "Odai";
      Assert.Equal("no repeats", hashtable.RepeatedWord(testString));
    }

    [Fact]
    public void TestExampleOne()
    {
      Hashtable hashtable = new Hashtable(1024);
      string testString = "Once upon a time there was a brave princess who";
      Assert.Equal("a", hashtable.RepeatedWord(testString));
    }

    [Fact]
    public void TestExampleTwo()
    {
      Hashtable hashtable = new Hashtable(1024);
      string testString = "It was a queer sultry summer the summer they electrocuted the Rosenbergs and I didn’t know what I was doing in New York";
      Assert.Equal("summer", hashtable.RepeatedWord(testString));
    }
  }
}

