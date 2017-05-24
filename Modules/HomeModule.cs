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

      Get["/view_tamagotchi/{id}"] = parameters => {
        pet newPet = pet.Find(parameters.id);
        return View["view_tamagotchi.cshtml", newPet];
      };

      Get["/pet_feed"] = _ => View["pet_feed.cshtml"];

      Post["/create_pet"] = _ => {
        pet newPet = new pet(Request.Form["name"],70, 70);
        return View["create_pet.cshtml", newPet];
      };
    }
  }
}
