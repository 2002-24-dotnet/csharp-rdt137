using System;

namespace Palindrome.Domain
{
  public class Reverse
  {
    public string sReverse;
    public string s;
    public string ReverseString(string s)
    {     
      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      sReverse = new string(arr);

      return sReverse;
    }

    public string GetString()
    {
      Console.Write("Enter word to check for Palindrome: ");
      s = Console.ReadLine();

      return s;
    }
  }
}
