
using study1_delet;
using System;

namespace StackQueue
{
  class Program
  {
    static void Main(string[] args)
    {

      stack_queue_pseudo QueuePseudo = new stack_queue_pseudo();

      QueuePseudo.Enqueue(1);
      QueuePseudo.Enqueue(2);
      QueuePseudo.Enqueue(3);
      QueuePseudo.Enqueue(4);

      Console.WriteLine(QueuePseudo.Dequeue());



    }
  }
}
