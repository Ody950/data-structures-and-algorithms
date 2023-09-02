
using System;
using Xunit;
using MergeSort;



namespace MergeSort
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      MergeSort mergeSortArray = new MergeSort();

      int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
      int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };
      Assert.Equal(mergeSortArray.MergeSortArray(test), expected);
    }
    [Fact]
    public void Test2()
    {
      MergeSort mergeSortArray = new MergeSort();

      int[] test = new int[] { -8, -4, -23, -42, -16, -15 };
      int[] expected = new int[] { -42, -23, -16, -15, -23, -8, -4 };
      Assert.Equal(mergeSortArray.MergeSortArray(test), expected);
    }
    [Fact]
    public void Test3()
    {
      MergeSort mergeSortArray = new MergeSort();

      int[] test = new int[] { 5 };
      int[] expected = new int[] { 5 };
      Assert.Equal(mergeSortArray.MergeSortArray(test), expected);
    }
    
  }
}
