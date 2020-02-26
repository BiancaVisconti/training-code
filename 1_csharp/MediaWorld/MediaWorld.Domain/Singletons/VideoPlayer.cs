using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Singletons
{
  public class VideoPlayer : APlayer
  {
    private static VideoPlayer _vp = new VideoPlayer();

    public static VideoPlayer Instance
    {
      get{
        return _vp;
      }
    }

    //
    // public static VideoPlayer GetInstance()
    // {
    //   return _vp;
    // }
  }
}