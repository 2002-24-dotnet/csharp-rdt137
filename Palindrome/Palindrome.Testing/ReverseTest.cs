using System;
using Xunit;
//using Palindrome.Domain;

namespace Palindrome.Testing
{
  public class ReverseTest
  {
    [Fact]
    public void Test_Reverse()
    {
      string expected = sReverse;

      string actual = s;

      Assert.True(expected == actual);
    }
  }
}
