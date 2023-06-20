


using System;
using System.Reflection;


namespace Challenge3
{
  public class Whiteboard3
  {



    public static void Main()
    {
      int[] arr = { 2, 3, 4, 10, 40 };

      int x = 10;

      int result = TheChallenge3(arr, x);

      if (result == -1)
      {
        Console.WriteLine("Element is not in the array (-1)");
      }
      else
      {
        Console.WriteLine("The index of the array’s element : " + result);
      }
    }


    public static int TheChallenge3(int[] arr, int x)
    {
      int low = 0;
      int high = arr.Length - 1;
      int mid = 0;

      while (low <= high)
      {
        mid = (high + low) / 2;

        if (arr[mid] < x)
        {
          low = mid + 1;
        }

        else if (arr[mid] > x)
        {
          high = mid - 1;
        }

        else
        {
          return mid;
        }
      }

      return -1;
    }



  }


}








