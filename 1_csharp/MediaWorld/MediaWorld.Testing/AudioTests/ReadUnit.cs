using System.Collections.Generic;
using System.Linq;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Storage.Adapters;
using Xunit;

namespace MediaWorld.Testing.AudioTests
{
  public class ReadUnit
  {
    //this is what fred had, only works if in the FileAdapter there is only one ., not two
    private IEnumerable<AMedia> fa = FileAdapter.Read("../../../../medialib.xml");

    //private IEnumerable<AMedia> fa = FileAdapter.Read("../medialib.xml");

    [Fact]
    public void Test_ReturnsList()
    {
      // arrange, set it up, go find what you are going to test
      var sut = new FileAdapter();
      var expected = 4;


      // act, run what you want to test
      var actual = fa;

      // assert, lets check against what we think it's suppose to happen
      Assert.True(expected <= actual.Count());
    }

    [Fact]
    public void Test_ReturnsNull()
    {
      var actual = fa;

      Assert.False(actual == null);
    }
  }
}