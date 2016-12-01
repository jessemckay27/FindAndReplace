using System.Collections.Generic;
using System;

namespace FindReplace.Objects
{
  public class FindAndReplace
  {
    private string _userManyWords;
    private string _userTarget;
    private string _userReplace;

    public FindAndReplace(string userManyWords, string userTarget, string userReplace)
    {
      _userManyWords = userManyWords;
      _userTarget = userTarget;
      _userReplace = userReplace;
    }

    public string MatchWord()
    {

      string[] _manyWordsSplit = _userManyWords.Split(' ');
      for (int i = 0; i < _manyWordsSplit.Length; i++)
      {
        if (_manyWordsSplit[i] == _userTarget)
        {
          _manyWordsSplit[i] = _userReplace;
        }
      }
      return string.Join(" ", _manyWordsSplit);
    }
  }
}
