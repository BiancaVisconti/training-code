using System.ComponentModel.DataAnnotations;
using MovieWorld.Client.Attribute;

namespace MovieWorld.Client.Models
{
  public class MovieModel
  {
    [Required(ErrorMessage = "Please fill out a title")]
    [StringLength(150)]
    public string Title { get; set; }

    [Required(ErrorMessage = "Please fill out a genre")]
    [DataType(DataType.Text)]
    [GenreAttribute(ErrorMessage = "Letters only please")]
    public string Genre { get; set; } 
  }
}