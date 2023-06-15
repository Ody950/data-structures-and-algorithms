
using System;
using System.Reflection;


namespace Challenge1
{
  public class Whiteboard
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 5, 5, 6, 6, 7, 7, 8 };


      Console.WriteLine(string.Join(", ", Reverse(arr)));
    }

    public static int[] Reverse(int[] arr)
    {
      if (arr.Length <= 0)
      {
        return null;
      }
      else
      {
        int[] newArr = new int[arr.Length];
        int index = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
          newArr[index] = arr[i];
          index++;
        }

        return newArr;

      }
    }
  }
}




























