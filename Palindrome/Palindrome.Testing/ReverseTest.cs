using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
  public class ReverseTest
  {
    [Fact]
    public void Test_Reverse()
    {
      string s = "Was it a car or a cat I saw";
      s = s.Replace(" ", String.Empty);
      s = s.ToLower();

      Reverse rv = new Reverse();
      string expected = rv.ReverseString(s);

      string actual = s;

      Assert.True(expected == actual);
    }
  }
}
