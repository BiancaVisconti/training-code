using System;
using System.Linq;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage.Adapters;
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client
{
    internal class Program
    {
        private static readonly AudioRepository _ar = new AudioRepository();
        private static void Main(string[] args)
        {
          //all of these show delegate
           PlayBook();
          // PlayMovie();
          // ShowPhoto();
          // PlaySong();
          // PlaySitcom();


          // PlayAudio();
          // PlayVideo();


          FileAdapter.Write(_ar.List().ToList());
        }

        private static void PlayBook()
        {
          var b = new Book();

          //Ddelegate part 1
          //b.Read(HowToRead.Upper);
          //b.ReadAction((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
          //b.ReadFunction((string s) => { Console.WriteLine(s.ToUpperInvariant()); return string.Empty; });
          //b.ReadDelegate((string s) => { Console.WriteLine(s);});

          //delegate part 2
          //b.ReadDelegate(UseCasingDelegate);
          //b.ReadDelegate2(UseCasingDelegate2);

          //event

          //nothing happens if we Open() first
          //b.Open();
          b.BookEvent += UseEvent;
          b.Open();

        }

        public static void UseEvent(string s)
        {
          Console.WriteLine(s);
        }

        private static void UseCasingDelegate(string s)
        {
          Console.WriteLine(s);
        }

        private static string UseCasingDelegate2()
        {
          return "delegate rules!!!";
        }

        private static void PlaySong()
        {
          var s = new Song();

          s.SongDelegate((string s) => { Console.WriteLine(s);});
        }

        private static void PlayMovie()
        {
          var m = new Movie();
          
          m.PlayMovieDelegate((string m) => { Console.WriteLine(m);});
        }

        private static void PlaySitcom()
        {
          var s = new Sitcom();

          s.PlaySitcomDelegate((string s) => { Console.WriteLine(s);});
        }

        private static void ShowPhoto()
        {
          var p = new Photo();

          p.PhotoDelegate((string p) => { Console.WriteLine(p);});
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
          var ar = new AudioRepository();

          //where do we use them, ar2 and ar3?
          var ar2 = new AudioRepositoryGeneric<Song>();
          var ar3 = new AudioRepositoryGeneric<Book>();

          try
          {
            foreach (var item in ar.List())
            {
              ap.Play(item);
            }
            
          }
          catch (NullReferenceException err)
          {
            //No necesito var exp = err; es solo para que no reclame
            var exp = err;
            Console.WriteLine("No playlist for you");
          }
          catch (IndexOutOfRangeException err)
          {
            var exp = err;
            Console.WriteLine("No song for you");
          }
          catch (Exception ex)
          {
            //throw;
            throw new Exception("error", ex);
          }
          finally
          {
            GC.Collect();
          }

        }

        private static void PlayVideo()
        {
          
        //var vp = VideoPlayer.GetInstance();

        //the csharp way
        var vp = VideoPlayer.Instance;
        //create VideoColection
        var vr = new VideoRepository();
        var vr2 = new VideoRepositoryGeneric<Movie>();
        var vr3 = new VideoRepositoryGeneric<Sitcom>();

        try
          {
            foreach (var item in vr.List())
            {
              vp.Play(item);
            }
          }
          catch (NullReferenceException err)
          {
            var exp = err;
            Console.WriteLine("No playlist for you");
          }
          catch (IndexOutOfRangeException err)
          {
            var exp = err;
            Console.WriteLine("No video for you");
          }
          catch (Exception ex)
          {
            //throw;
            throw new Exception("error", ex);
          }
          finally
          {
            GC.Collect();
          }

        }
    }
}
