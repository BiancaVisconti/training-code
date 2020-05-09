using System;
using System.Collections.Generic;

namespace FizzBuzz.Domain
{
  public class Calculations
  {

    public int Fizz = 0;

    public int Buzz = 0;

    public int FizzBuzz = 0;

    private int num1 = 3;

    private int num2 = 5;

    public List<string> list2 = new List<string>();
    public void Calculate(int i)
    {
      if (i%num1 == 0)
      {
        if (i%num2 == 0)
        {
          list2.Add("FizzBuzz");
          FizzBuzz++;
        }
        else
        {
          list2.Add("Fizz");
          Fizz++;
        }
      }
      else if (i%num2 == 0)
      {
        list2.Add("Buzz");
        Buzz++;
      }
      else
      {
        list2.Add("None");
      }

    }
  }
}