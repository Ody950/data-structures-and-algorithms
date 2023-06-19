



using Challenge3;
using System.Security.Principal;
using Xunit;
namespace BinarySearch
{
  public class UnitTest2
  {
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 10, 40 }, 10, 3)]
    [InlineData(new int[] { 2, 3, 4, 10, 40 }, 5, -1)]
    public void TestBinarySearch(int[] arr, int x, int expected)
    {

      int result = Whiteboard3.TheChallenge3(arr, x);
      Assert.Equal(expected, result);
    }
  }
}
