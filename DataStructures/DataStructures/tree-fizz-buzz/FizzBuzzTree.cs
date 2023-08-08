
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static trees.Node;

namespace trees
{

  public class KAryTree
  {

    public List<string> FizzBuzzTree(Node root)
    {
      List<string> listOfNode = new List<string>();
      if (root == null)
      {
        throw new Exception("The Tree Is Empty!!");
      }
      Queue<Node> theQueue = new Queue<Node>();
      theQueue.Enqueue(root);
      while (theQueue.Count > 0)
      {
        for (int i = 0; i < theQueue.Count(); i++)
        {
          int value = Convert.ToInt32(theQueue.First().Value);

          if (value % 15 == 0)
          {
            listOfNode.Add("FizzBuzz");
          }
          else if (value % 3 == 0)
          {
            listOfNode.Add("Fizz");
          }
          else if (value % 5 == 0)
          {
            listOfNode.Add("Buzz");
          }
          else
          {
            listOfNode.Add(theQueue.First().Value);
          }

          Node node = theQueue.Dequeue();
          foreach (Node item in node.Children)
          {
            theQueue.Enqueue(item);
          }
        }
      }
      return listOfNode;
    }

  }


}
