using AnimalShelter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalShelter
{
  public class AnimalShelter
  {

    AnimalQueue Cat = new AnimalQueue();
    AnimalQueue Dog = new AnimalQueue();


    public void Enqueue(Animal animal)
    {
      animal.Name = animal.Name.ToLower();

      if (animal.Type == "cat")
      {
        Cat.Enqueue(animal.Name);
      }
      else if (animal.Type == "dog")
      {
        Dog.Enqueue(animal.Name);
      }
      else
      {
        Console.WriteLine("only dog and cat");
      }
    }


    public string Dequeue(string pref)
    {
      pref = pref.ToLower();

      if (pref == "cat")
      {
        string ThePrefC = Cat.Dequeue();
        return ThePrefC;
      }
      else if (pref == "dog")
      {
        string ThePrefD = Dog.Dequeue();
        return ThePrefD;
      }
      else
      {
        return null;
      }
    }

    public string Print()
    {
      string CatStr = Cat.ToString();

      string DogStr = Dog.ToString();

      return ($"the cat ${CatStr} and the dog ${DogStr}");

    }





  }
}

