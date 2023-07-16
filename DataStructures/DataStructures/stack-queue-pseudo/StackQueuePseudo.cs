
using StackQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1_delet
{
  public class stack_queue_pseudo
  {
    StackClass Stack1 = new StackClass();
    StackClass Stack2 = new StackClass();


    public void Enqueue(int value)
    {
      Stack1.Push(value);
    }


    public int Dequeue()
    {

      if (Stack1.IsEmpty())
      {
        throw new Exception("Empty Queue");
      }

      while (Stack1.Top != null)
      {
        Stack2.Push(Stack1.Pop());
      }

      int ThePop = Stack2.Pop();

      while (Stack2.Top != null)
      {
        Stack1.Push(Stack2.Pop());
      }

      return ThePop;
    }
  }
}
