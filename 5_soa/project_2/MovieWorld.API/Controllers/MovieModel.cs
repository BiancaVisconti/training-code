using System.ComponentModel.DataAnnotations;

namespace MovieWorld.API.Controllers
{
  public class MovieModel
  {
    [Required]
    public string Title { get; set; }
  }
}