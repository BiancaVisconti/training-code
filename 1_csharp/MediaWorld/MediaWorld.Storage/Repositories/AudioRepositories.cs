using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepository
  {
    private static readonly List<AAudio> _lib = new List<AAudio>()
    {
      new Song() { Title = "Fly On"},
      new Song() { Title = "Forever Young"},
      new Book() { Title = "E.T."},
      new Book() { Title = "Little Women"}
    };

    public IEnumerable<AMedia> List()
    {
      return _lib;
    }
  }
}