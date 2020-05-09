using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Sitcom : AVideo
  {
    public delegate void SitcomDelegate(string s);

    public void PlaySitcomDelegate(SitcomDelegate d)
    {
      var text = "Play sitcom from delegate";

      d(text);
    }
  }
}