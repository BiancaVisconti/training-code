using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MovieWorld.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  [EnableCors()]
  public class PokemonController : ControllerBase
  {
    private static readonly List<string> _poke = new List<string>();

    [HttpGet]
    public IActionResult Get()
    {
      var client = new HttpClient();
      return Ok(client.GetAsync("https://pokeapi.co/api/v2/pokemon/ditto/").GetAwaiter().GetResult().ToString());
    }

    [HttpPost]
    public IActionResult Post(string pokemon)
    {
      _poke.Add(pokemon);
      return Ok();
    }
  }
}