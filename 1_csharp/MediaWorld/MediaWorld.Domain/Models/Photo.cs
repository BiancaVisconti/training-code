using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Photo : AMedia
  {
    public delegate void ShowPhotoDelegate(string s);

    public void PhotoDelegate(ShowPhotoDelegate d)
    {
      var text = "Show photo from delegate";

      d(text);
    }
  }
}