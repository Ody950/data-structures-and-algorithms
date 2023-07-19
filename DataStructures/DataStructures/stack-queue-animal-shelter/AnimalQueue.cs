using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static AnimalShelter.Program;

namespace AnimalShelter
{
  public class AnimalQueue
  {

    public AnimalNode Front { get; set; }
    public AnimalNode Back { get; set; }


    public void Enqueue(string value)
    {
      if (Front == null)
      {
        AnimalNode NewNode = new AnimalNode(value);
        Front = Back = NewNode;
      }
      else
      {
        AnimalNode NewNode = new AnimalNode(value);
        Back.Next = NewNode;
        Back = NewNode;
      }

    }

    public string Dequeue()
    {
      if (Front == null)
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        AnimalNode currentPostion = Front;
        Front = Front.Next;
        currentPostion.Next = null;
        return currentPostion.Value;
      }

    }

    public string peek()
    {
      if (Back == null)
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        AnimalNode ThePeek = Front;
        return ThePeek.Value;
      }
    }
    public bool IsEmpty()
    {
      if (Front == null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string ToString()
    {
      AnimalNode Start = Front;
      string result = " We have ";
      int count = 0;
      while (Start != null)
      {
        count++;
        result += $"{Start.Value} number {count}, ";
        Start = Start.Next;
      }
      return result + $"The above is just the what we have in our shelter, available at this moment ";
    }

  }
}
