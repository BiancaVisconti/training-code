using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Singletons
{
  // middle step to single object
  // public static class AudioPlayer
  // {
  //   public static void Play()
  //   {
  //     Console.WriteLine("blah");

  //   }
  // }
  public class AudioPlayer : APlayer
  {

    private static AudioPlayer _ap = new AudioPlayer();
   
    private AudioPlayer(){}

    //
    // public static AudioPlayer GetInstance()
    // {
    //   return _ap;
    // }


    //property
    public static AudioPlayer Instance
    {
      get
      {
        return _ap;
      }
    }

    public void Play()
    {

    }

    public void Stop()
    {
      throw new NotImplementedException();
    }
  }
}