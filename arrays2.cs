using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      // The sourceArray and destinationArray parameters must have the same number of dimensions.
      string[] summerStrutCopy = new string[8];
      Array.Copy(summerStrut, summerStrutCopy, 8);
      Console.WriteLine($"{summerStrutCopy[7]}");

      //Reverse
      Array.Reverse(summerStrut);
      Console.WriteLine($"{summerStrut[0]}");

      // set all ratings to 0
      Array.Clear(ratings, 0, 8);
      Console.WriteLine(ratings[0]);
    }
  }
}
