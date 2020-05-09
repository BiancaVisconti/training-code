using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MovieWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")] // route template, http://localhost:5001/api/weatherforecast
    public class WMovieController : ControllerBase
    {
        private static readonly List<MovieModel> _mml = new List<MovieModel>();
        
        [HttpGet]
        public IActionResult Get()
        {
          return Ok(_mml); // response message = data + http status code
        }

        [HttpPost]
        public IActionResult Post(MovieModel model)
        {
          if(ModelState.IsValid)
          {
            _mml.Add(model);
            return Ok();
          }

          return BadRequest(model);
        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}
