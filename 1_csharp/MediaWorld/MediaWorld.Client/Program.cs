using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;

namespace MediaWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          PlayAudio();

          PlayVideo();
        }

        private static void PlayAudio()
        {
          //first step
          //AudioPlayer ap = new AudioPlayer();
          //Console.WriteLine(ap);

          //middle step
          //AudioPlayer.Play();

          //var ap = AudioPlayer.GetInstance();

          //the csharp way
          var ap = AudioPlayer.Instance;
          var s = new Song();

          ap.Play(s);
        }

        private static void PlayVideo()
        {
          
          //var vp = VideoPlayer.GetInstance();

          //the csharp way
          var vp = VideoPlayer.Instance;
        }
    }
}
