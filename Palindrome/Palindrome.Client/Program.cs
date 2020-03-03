using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse rv = new Reverse();
            string str = rv.GetString();
            str = str.Replace(" ", String.Empty);
            str = str.ToLower();
            string sReverse = rv.ReverseString(str);
            if (str == sReverse)
            {
              Console.WriteLine("The text is a Palindrome!");
            }
            else
              Console.WriteLine("The text isn't a Palindrome :(");
        }
    }
}
