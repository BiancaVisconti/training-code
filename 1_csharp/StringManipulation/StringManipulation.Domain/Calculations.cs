using System;
using System.Collections.Generic;

namespace StringManipulation.Domain
{

  public class Calculations
  {
    public void NumberOfCharacters(string s)
    {
      int numChar = s.Length;

      Console.WriteLine($"The word has {numChar} character(s)");

    }

    public static bool isConsonant(char ch)
    {
      ch = Char.ToLower(ch);

      return !(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == ' ' || ch == '!' || ch == '?');
    }

    public static bool isVowel(char ch)
    {
      ch = Char.ToLower(ch);

      return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
    }

    public void NumberOfConsonants(string s)
    {
     int count = 0;
     for (int i = 0; i < s.Length; i++)
     {
         if (isConsonant(s[i]))
         {
           ++count;
         }
     }

     Console.WriteLine($"The string has {count} consonant(s)");

    }

    public void NumberOfVowels(string s)
    {
     int count = 0;
     for (int i = 0; i < s.Length; i++)
     {
         if (isVowel(s[i]))
         {
           ++count;
         }
     }

     Console.WriteLine($"The string has {count} vowel(s)");

    }

    public void NumberOfWords(string s)
    {
      int count = 0;
      string[] words = s.Split(' ');
      
      count = words.Length;

      Console.WriteLine($"The string has {count} word(s)");
    }

    public void NumberRepeatedChar(string s)
    {
      int count= 0;
      char[] chars = s.ToCharArray();
      Dictionary<char, int> RepeatedCharCount = new Dictionary<char, int>();

      for (int i = 0; i < chars.Length; i++)
      {
          if (RepeatedCharCount.ContainsKey(chars[i]))
          {
            RepeatedCharCount[chars[i]]++;
            if (RepeatedCharCount[chars[i]]==2)
            {
              count++;
            }
          }
          else
          {
            RepeatedCharCount.Add(chars[i], 1);
          }
      }

      Console.WriteLine($"The string has {count} character(s) repeated");


    }

    public string ReverseString(string s)
    {
      char[] chars = s.ToCharArray();

      Array.Reverse(chars);

      return new String(chars);

    }
  }

}