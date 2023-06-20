

using Challenge1;
using System.Security.Principal;
using Xunit;

namespace testrevers
{
  public class UnitTest1
  {
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { -1, -2, -3, -4, -5 }, new int[] { -5, -4, -3, -2, -1 })]
    [InlineData(new int[] { }, null)]
    public void TestReverse(int[] arr, int[] expectedarr)
    {
      Assert.Equal(expectedarr, Whiteboard.Reverse(arr));
    }

  }
}
