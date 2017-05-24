using Nancy;
using System.Collections.Generic;
using tamagotchi.Objects;

namespace tamagotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
    }
  }
}
