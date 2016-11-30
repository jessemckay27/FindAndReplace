using Xunit;

namespace FindAndReplace.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void GetWord_EnterThreeWordsFindOneReplaceOne_match()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace(string "hello great big world", "world", "universe");
      Assert.Equal("hello great big universe", newFindAndReplace.MatchWord());
    }
  }
}
