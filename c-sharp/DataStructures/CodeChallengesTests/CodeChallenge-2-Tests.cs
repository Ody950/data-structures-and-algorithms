

using Challenge2;
using System.Security.Principal;
using Xunit;
namespace TestShiftt
{
  public class UnitTest2
  {
    [Theory]
    [InlineData(new int[] { }, 5, new int[] { 5 })]
    [InlineData(new int[] { -15, -13, -9, -6, -2, 0 }, -7, new int[] { -15, -13, -9, -7, -6, -2, 0 })]
    [InlineData(new int[] { 4, 5, 9, 15, 19 }, 13, new int[] { 4, 5, 9, 13, 15, 19 })]
    [InlineData(new int[] { }, null, new int[] { 0 })]


    public void TestShift(int[] arr, int integerX, int[] expectedarr)
    {
      Assert.Equal(expectedarr, Whiteboard2.ShiftArr(arr, integerX));

    }
  }
}

