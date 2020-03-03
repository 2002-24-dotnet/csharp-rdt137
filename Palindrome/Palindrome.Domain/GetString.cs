using System;

namespace Palindrome.Domain
{
  public class GetString
  {
    public string GetStr()
    {
      var ar = new string[]{" ", ",", ".", "?", "!"};

      Console.Write("Enter a word or sentence to check if it's a Palindrome: ");
      var s = Console.ReadLine();
      
      foreach(string item in ar)
        s = s.Replace(item, String.Empty);

      s = s.ToLower();

      return s;
    }
  }
}