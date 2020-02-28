using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepositoryGeneric<T> where T : AAudio
  {
    public static readonly List<T> _lib = new List<T>();
  }
}