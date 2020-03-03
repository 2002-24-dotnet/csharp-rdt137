using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      
      var gs = new GetString();
      string str = gs.GetStr();
      
      var rv = new Reverse();
      string sReverse = rv.ReverseString(str);

      if (str == sReverse)
        Console.WriteLine("The text is a Palindrome!");
      else
        Console.WriteLine("The text isn't a Palindrome :(");
    }
  }
}
