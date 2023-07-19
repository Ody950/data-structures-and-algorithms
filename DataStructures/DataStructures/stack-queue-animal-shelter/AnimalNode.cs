using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
  public class AnimalNode
  {
    public string Value { get; set; }
    public AnimalNode Next { get; set; }
    public AnimalNode(string value)
    {
      Value = value;
      Next = null;
    }
  }
}
