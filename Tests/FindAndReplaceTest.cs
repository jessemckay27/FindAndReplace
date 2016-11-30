using Xunit;

namespace FindReplace.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void GetWord_EnterThreeWordsFindOneReplaceOne_match()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace("hello great big world", "world", "universe");
      Assert.Equal("hello great big universe", newFindAndReplace.MatchWord());
    }
  }
}
