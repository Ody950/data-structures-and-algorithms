
using System;
using System.Reflection;


namespace Challenge2
{
  public class Whiteboard2
  {


    static void Main(string[] args)
    {
      int[] arr = new int[] { 2, 9, 16, 26, 55, 70, 80 };
      int integerX = 33;

      Console.WriteLine(string.Join(", ", ShiftArr(arr, integerX)));


    }

    public static int[] ShiftArr(int[] arr, Int32 integerX)
    {
      int[] NewArray = new int[arr.Length + 1];

      if (arr.Length <= 0 && integerX == null)
      {
        return null;
      }
      else if (arr.Length <= 0 && integerX != null)
      {
        NewArray[0] = integerX;
        return NewArray;
      }
      else
      {
        for (int i = 0; i < arr.Length; i++)
        {
          if (integerX <= arr[i])
          {
            NewArray[i] = integerX;
            for (int j = i; j < arr.Length; j++)
            {
              NewArray[j + 1] = arr[j];
            }
            return NewArray;
            break;
          }
          else
          {
            NewArray[i] = arr[i];
          }

        }
        return NewArray;
      }
    }

  }
}







