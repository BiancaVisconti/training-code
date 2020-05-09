using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage.Repositories
{
  public class VideoRepository
  {
    private static readonly List<AVideo> _lib = new List<AVideo>()
    {
      new Movie() {Title = "Titanic"},
      new Movie() {Title = "Finding Nemo"},
      new Movie() {Title = "Las Chicas del Cable"}
    };

    public IEnumerable<AMedia> List()
    {
      return _lib;
    }
  }
}