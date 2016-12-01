using Nancy;
using System.Collections.Generic;
using FindReplace.Objects;

namespace FindReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/replace"] = _ =>
      {
        string userManyWords = Request.Form["userManyWords"];
        string userTarget = Request.Form["userTarget"];
        string userReplace = Request.Form["userReplace"];
        FindAndReplace newFindAndReplace = new FindAndReplace(userManyWords, userTarget, userReplace);
        return View["result.cshtml", newFindAndReplace];
      };
    }
  }
}
