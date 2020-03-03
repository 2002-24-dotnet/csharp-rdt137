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
      Console.Write("Enter a word or sentence to check if it's a Palindrome: ");
      s = Console.ReadLine();
      s = s.Replace(" ", String.Empty);
      s = s.ToLower();

      return s;
    }
  }
}
