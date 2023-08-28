using System;

namespace InsertionSort
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[] testArray = { 8, 6, 7, 5};
      InsertionSort(testArray);
    }

    public static void InsertionSort(int[] myArray)
    {
      for (int i = 1; i < myArray.Length; i++)
      {
        int j = i - 1;
        int temp = myArray[i];

        while (j >= 0 && temp < myArray[j])
        {
          myArray[j + 1] = myArray[j];
          j = j - 1;
        }

        myArray[j + 1] = temp;
      }
      return myArray;
    }
  }
}
