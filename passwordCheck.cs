using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      BOOL TYPE: bool variableName
      COMPARISON OPERATORS: ==, <, >, <=, >=
      LOGICAL OPERATORS: &&, ||, !

      Good luck! */
      bool isUpper = false;
      bool numIncluded = false;
      bool symbolIncluded = false;
      string password = "Hello123#";
      for (int i=0; i<password.Length; i++){
        // Check for caps
        if (Char.IsUpper(password[i])) {
          isUpper = true;
          Console.WriteLine($"{password[i]} - is upper.");
        }
        // Check for num
        if (Char.IsNumber(password[i])){
          numIncluded = true;
          Console.WriteLine($"{password[i]} - is num.");
        }
        // Check for crazy character
        if (Char.IsPunctuation(password[i]) || Char.IsSymbol(password[i])){
          symbolIncluded = true;
          Console.WriteLine($"{password[i]} - is symbol.");
        }
      }
      bool answer = (isUpper && numIncluded && symbolIncluded);
      Console.WriteLine(Char.GetUnicodeCategory('!'));
      Console.WriteLine(answer);
    }
  }
}
