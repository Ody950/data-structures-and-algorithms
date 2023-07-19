using System;
using Xunit;
using AnimalShelter;


namespace AnimalShelter
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      AnimalShelter theAnimal = new AnimalShelter();

      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Cat("cat"));
      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Cat("cat"));
      theAnimal.Enqueue(new Dog("Dog"));



      string Expected = "dog";
      string Actual = theAnimal.Dequeue("dog");
      Assert.Equal(Expected, Actual);
    }

    [Fact]
    public void Test2()
    {
      AnimalShelter theAnimal = new AnimalShelter();
      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Cat("cat"));
      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Cat("cat"));
      theAnimal.Enqueue(new Dog("Dog"));

      Assert.Null(theAnimal.Dequeue("Horse"));
    }


  }
}

