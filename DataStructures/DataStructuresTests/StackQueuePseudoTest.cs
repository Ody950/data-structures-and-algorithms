

using System;
using Xunit;
using StackQueue;
using study1_delet;

namespace stack_queue_pseudo_Test
{
  public class UnitTest2
  {
    [Fact]
    public void Test1()    //Can successfully Enqueue onto a Queue-Pseudo
    {


      stack_queue_pseudo QueuePseudo = new stack_queue_pseudo();

      QueuePseudo.Enqueue(1);
      QueuePseudo.Enqueue(2);
      QueuePseudo.Enqueue(3);
      QueuePseudo.Enqueue(4);

      Assert.Equal(1, QueuePseudo.Dequeue());
    }



  }
}
