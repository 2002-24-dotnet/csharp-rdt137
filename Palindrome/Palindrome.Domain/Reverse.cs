using System;

namespace Palindrome.Domain
{
  public class Reverse
  {
    public string ReverseString(string s)
    {
      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      var sReverse = new string(arr);

      return sReverse;
    }

    
  }
}
