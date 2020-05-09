using System;
using System.Collections;
using System.Collections.Generic;
using FizzBuzz.Domain;

namespace FizzBuzz.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          FizzBuzz();

        }

        public static void FizzBuzz()
        {
          Console.Write("Enter integer: ");
          int num;
          num = Int32.Parse(Console.ReadLine());

          List<int> list = new List<int>();
          var c = new Calculations();
          for (int i = 0; i <= num ; i++)
          {
              list.Add(i);
              Console.Write($"{i} ");
              c.Calculate(i);
          }

          Console.WriteLine();
          Console.WriteLine($"N° Fizz: {c.Fizz}");
          Console.WriteLine($"N° Buzz: {c.Buzz}");
          Console.WriteLine($"N° FizzBuzz: {c.FizzBuzz}");
        
          foreach (var item in c.list2)
          {
              Console.Write($"{item} ");
          }
          Console.WriteLine();

        }
      
    }
}
