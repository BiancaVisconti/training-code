using System;
using System.Collections.Generic;
using PizzaBox.Domain;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    {

        private static PizzaRepository _pr = new PizzaRepository();

        public static void Main(string[] args)
        {
            GetAllPizza();

        }

        private static void GetAllPizza()
        {

          foreach (var p in _pr.Get())
          {
            Console.WriteLine(p);
          }
        }

    }
}
