using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Movie : AVideo
  {
    
    public delegate void MovieDelegate(string s);

    public void PlayMovieDelegate(MovieDelegate d)
    {
      var text = "Play movie from delegate";

      d(text);
    }
  }
}