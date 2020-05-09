using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Song : AAudio
  {
    
    public delegate void PlaySongDelegate(string s);

    public void SongDelegate(PlaySongDelegate d)
    {
      var text = "Play song from delegate";

      d(text);

    }
  }
}