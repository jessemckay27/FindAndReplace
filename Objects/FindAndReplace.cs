using System.Collections.Generic;
using System;

namespace FindAndReplace.Objects
{
  public class FindAndReplace
  {
    private string _userManyWords;
    private string _userTarget;
    private string _userReplace;

    // private List<string> _manyWordsList = new List<string>{};
                         //may need to use parentheses    ();

    public MatchWord(string userManyWords, string userTarget, string userReplace)
    {
      _userManyWords = userManyWords;
      _userTarget = userTarget;
      _userReplace = userReplace;

      string[] manyWordsSplit = _userManyWords.Split(' ');
      foreach(string word in manyWordsSplit)
      {
        if(word == _userTarget)
        {
          _userTarget = _userReplace;
        }
      }
      string.Join(" ", manyWordsSplit);
    }
  }
}
