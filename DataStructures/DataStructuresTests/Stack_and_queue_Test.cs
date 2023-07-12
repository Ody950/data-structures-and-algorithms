


using System;
using Xunit;
using StackQueue;

namespace stack_and_queue_Test
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()    //Can successfully push onto a stack
    {
      StackClass stack = new StackClass();
      stack.Push(1);
      Assert.Equal(1, stack.Top.Value);
    }


    [Fact]
    public void Test2()    //Can successfully push multiple values onto a stack
    {
      StackClass stack = new StackClass();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);
      Assert.Equal(4, stack.Top.Value);
    }


    [Fact]
    public void Test3()    //Can successfully pop off the stack
    {
      StackClass stack = new StackClass();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      stack.Pop();

      Assert.Equal(3, stack.Top.Value);
    }


    [Fact]
    public void Test4()    //Can successfully empty a stack after multiple pops
    {
      StackClass stack = new StackClass();
      stack.Push(1);
      stack.Push(2);


      stack.Pop();
      stack.Pop();

      Assert.True(stack.IsEmpty());
    }


    [Fact]
    public void Test5()    //Can successfully peek the next item on the stack
    {
      StackClass stack = new StackClass();
      stack.Push(1);
      stack.Push(2);


      Assert.Equal(2, stack.peek());
    }



    [Fact]
    public void Test6()    //Can successfully instantiate an empty stack
    {
      StackClass stack = new StackClass();

      Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void Test7()    //Calling pop or peek on empty stack raises exception
    {
      StackClass stack = new StackClass();

      Assert.Throws<Exception>(() => stack.peek());
      Assert.Throws<Exception>(() => stack.Pop());

    }

    [Fact]
    public void Test8()    //Can successfully enqueue into a queue
    {
      QueueClass queue = new QueueClass();
      queue.Enqeue(1);
      Assert.Equal(1, queue.Front.Value);
    }


    [Fact]
    public void Test9()    //Can successfully enqueue multiple values into a queue
    {
      QueueClass queue = new QueueClass();
      queue.Enqeue(1);
      queue.Enqeue(2);
      queue.Enqeue(3);
      queue.Enqeue(4);

      Assert.Equal(4, queue.Back.Value);
    }


    [Fact]
    public void Test10()    //Can successfully dequeue out of a queue the expected value
    {
      QueueClass queue = new QueueClass();
      queue.Enqeue(1);
      queue.Enqeue(2);
      queue.Enqeue(3);
      queue.Enqeue(4);

      int x = queue.Dequeue();

      Assert.Equal(1, x);
    }


    [Fact]
    public void Test11()    //Can successfully peek into a queue, seeing the expected value
    {
      QueueClass queue = new QueueClass();
      queue.Enqeue(1);
      queue.Enqeue(2);
      queue.Enqeue(3);
      queue.Enqeue(4);


      Assert.Equal(1, queue.peek());
    }


    [Fact]
    public void Test12()    //Can successfully empty a queue after multiple dequeues
    {
      QueueClass queue = new QueueClass();

      queue.Enqeue(1);
      queue.Enqeue(2);
      queue.Enqeue(3);
      queue.Enqeue(4);
      queue.Dequeue();
      queue.Dequeue();
      queue.Dequeue();
      queue.Dequeue();
      Assert.True(queue.IsEmpty());
    }



    [Fact]
    public void Test13()    //Can successfully instantiate an empty queue
    {
      QueueClass queue = new QueueClass();

      Assert.True(queue.IsEmpty());
    }

    [Fact]
    public void Test14()    //Calling dequeue or peek on empty queue raises exception
    {
      QueueClass queue = new QueueClass();

      Assert.Throws<Exception>(() => queue.peek());
      Assert.Throws<Exception>(() => queue.Dequeue());

    }
  }
}


