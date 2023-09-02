using System;


namespace MergeSort
{
  public class MergeSort
  {
    public int[] MergeSortArray(int[] arr)
    {
      int n = arr.Length;

      if (n > 1)
      {
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i = 0; i < mid; i++)
          left[i] = arr[i];

        for (int i = mid; i < n; i++)
          right[i - mid] = arr[i];

        MergeSortArray(left);
        MergeSortArray(right);
        Merge(left, right, arr);
      }
      return arr;

    }
    public void Merge(int[] left, int[] right, int[] arr)
    {
      int i = 0;
      int j = 0;
      int k = 0;

      while (i < left.Length && j < right.Length)
      {
        if (left[i] <= right[j])
        {
          arr[k] = left[i];
          i = i + 1;
        }
        else
        {
          arr[k] = right[j];
          j = j + 1;
        }
        k = k + 1;
      }
      if (i == left.Length)
      {
        while (j < right.Length)
        {
          arr[k] = right[j];
          j++;
          k++;
        }
      }
      else
      {
        while (i < left.Length)
        {
          arr[k] = left[i];
          i++;
          k++;
        }
      }
    }
  }
}
