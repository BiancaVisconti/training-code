using System;
using StringManipulation.Domain;

namespace StringManipulation.Client
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          StringManip();
        }

        public static void StringManip()
        {
          Console.Write("Enter string: ");
          string str;
          str = Console.ReadLine();

          var c = new Calculations();
          c.NumberOfCharacters(str);
          c.NumberOfConsonants(str);
          c.NumberOfVowels(str);
          c.NumberOfWords(str);
          c.NumberRepeatedChar(str);
          Console.WriteLine(c.ReverseString(str));
        }

    }
}
