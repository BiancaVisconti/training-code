using System;

namespace Digimon
{
    internal class Digimon
    {

      //public string name { get => name; set => name = value; }

      public string name;

      public Digimon(string name)
      {
        this.name = name;

      }

  }
    internal class Program
    {
      public static void Main(string[] args)
        {
          Console.WriteLine("Hello Digimon!");
          Digimon d1 = new Digimon("bianca");
          Digimon d2 = new Digimon("silvana");
          var p = new Program();
          p.Fight(d1, d2);
          
        }

      //if Fight is static, it doesn't work
      public void Fight(Digimon a, Digimon b)
        {
          System.Console.WriteLine("{0} fights {1}", a.name, b.name);
        }

    }
}
