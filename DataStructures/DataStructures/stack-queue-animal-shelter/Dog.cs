using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
  public class Dog : Animal
  {
    public Dog(string name)
    {

      this.Name = name;
      this.Type = "dog";
    }
  }
}
