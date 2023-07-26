
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackQueueBrackets
{
  public class Brackets
  {
    public static bool BracketsV(string TheString)
    {

      StackClass TheStack = new StackClass();

      if (TheString == null)
        return true;

      for (int i = 0; i < TheString.Length; i++)
      {
        char temp = TheString[i];
        switch (temp)
        {
          case '(':
            TheStack.Push(')');
            break;
          case '[':
            TheStack.Push(']');
            break;
          case '{':
            TheStack.Push('}');
            break;
          case ')':
            if (!TheStack.peek().Equals(temp)) return false;
            TheStack.Pop();
            break;
          case ']':
            if (!TheStack.peek().Equals(temp)) return false;
            TheStack.Pop();
            break;
          case '}':
            if (!TheStack.peek().Equals(temp)) return false;
            TheStack.Pop();
            break;
          default:
            break;
        }
      }
      if (!TheStack.IsEmpty()) return false;
      return true;

    }

  }
}
