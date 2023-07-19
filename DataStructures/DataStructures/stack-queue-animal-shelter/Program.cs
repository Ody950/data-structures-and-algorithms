using AnimalShelter;
using System;

namespace AnimalShelter
{
  class Program
  {
    static void Main(string[] args)
    {
      AnimalShelter theAnimal = new AnimalShelter();

      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Cat("cat"));
      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Dog("Dog"));
      theAnimal.Enqueue(new Dog("Dog"));

      Console.WriteLine(theAnimal.Dequeue("dog"));

      Console.WriteLine(theAnimal.Print());

    }
  }
}
