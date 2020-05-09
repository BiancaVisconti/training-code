using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository
  {
    private static readonly PizzaBoxDbcontext _db = new PizzaBoxDbcontext();

    public List<Pizza> Get()
    {
      return _db.Pizza.ToList();
    }
  }
}