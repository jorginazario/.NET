using System;

namespace LoopsReview
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      while loop: while(){..} 
      do...while loop: do{...}while();
      for loop: for(int i=0; i<x; i++){}
      foreach loop: foreach(int item in list){}
      jump statements: break, continue, return

      Good luck! */

      string[] words = {"alpha", "hello", "amazing", "buffalo", "be great", "greatness"};
      int[] numList = {1,2,3,4,5,6};

      foreach (string word in words)
      {
        if (word[0] == 'a')
        {
          Console.WriteLine(word);
        }
      }
      
      bool val;
      for (int i=0; i<numList.Length; i++)
      {
        val = IsEven(numList[i]);
        if (val)
        {
          Console.WriteLine("Even");
        }
        else
        {
          Console.WriteLine("Odd");
        }
      }

      int j = 0;
      do
      {
        val = IsEven(numList[j]);
        if (val)
        {
          Console.WriteLine("Even");
        }
        else
        {
          Console.WriteLine("Odd");
        }
        j++;
      } while (j<numList.Length);

    }

    static bool IsEven(int num)
    {
      if (num % 2 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}
