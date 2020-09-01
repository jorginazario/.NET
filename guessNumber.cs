using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      CONDITIONALS: if, if...else, else if
      SWITCH STATEMENT: switch (condition)
      TERNARY OPERATOR: (condition) ? true : false

      Good luck! */
      Random rnd = new Random();
      int num = rnd.Next(1,11);

      int guess = 5;//Convert.ToInt32(Console.ReadLine());

      while (guess != num)
      {
        if (guess > num)
        {
          Console.WriteLine("Too high!\n");
          guess = Convert.ToInt32(Console.ReadLine());
        }
        else if (guess < num)
        {
          Console.WriteLine("Too low...\n");
          guess = Convert.ToInt32(Console.ReadLine());
        }
      }
      Console.WriteLine($"The number was {guess}! You got it!");
      
    }
  }
}
