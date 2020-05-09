using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Storage.Repositories
{
  public class VideoRepositoryGeneric<T> where T : AVideo
  {
    public static readonly List<T> _lib = new List<T>();

    public IEnumerable<AMedia> List()
    {
      return _lib;
    }
  }
}