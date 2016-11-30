using System.Collections.Generic;
using System;

namespace FindReplace.Objects
{
  public class FindAndReplace
  {
    private string _userManyWords;
    private string _userTarget;
    private string _userReplace;

    // private List<string> _manyWordsList = new List<string>{};
                         //may need to use parentheses    ();

    public FindAndReplace(string userManyWords, string userTarget, string userReplace)
    {
      _userManyWords = userManyWords;
      _userTarget = userTarget;
      _userReplace = userReplace;
    }

    public string MatchWord()
    {

      string[] manyWordsSplit = _userManyWords.Split(' ');
      for (int i = 0; i < manyWordsSplit.Length; i++)
      {
        if (manyWordsSplit[i] == _userTarget)
        {
          manyWordsSplit[i] = _userReplace;
        }
      }
      return string.Join(" ", manyWordsSplit);
    }
  }
}
