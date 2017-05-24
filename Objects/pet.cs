using System.Collections.Generic;
namespace tamagotchi.Objects
{
  public class pet
  {
    private string _name;
    private string _food;
    private int _time;
    private string _activity;
    private int _energy;
    private int _attention;
    private int _id;
    private static List<pet> _yourpets = new List<pet>();
    public pet(string name, int energy, int attention)
    {
      SetName(name);
      SetEnergy(energy);
      SetAttention(attention);
      _yourpets.Add(this);
      _id = _yourpets.Count;
    }

    public int GetId()
    {
      return _id;
    }
    // public food(string foodType, int time)
    // {
    //   SetFood(foodType);
    //   SetTime(time);
    // }
    //
    // public play(string activity, int time)
    // {
    //   SetActivity(activity);
    //   SetTime(time);
    // }
    //
    // public sleep(int time)
    // {
    //   SetTime(time);
    // }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name){
      _name = name;
    }
    // public string GetFood()
    // {
    //   return _food;
    // }
    //
    // public int GetTime()
    // {
    //   return _time;
    // }
    //
    // public string GetActivity()
    // {
    //   return _activity;
    // }

    public int GetEnergy()
    {
      return _energy;
    }

    public int GetAttention()
    {
      return _attention;
    }

    public void SetEnergy(int energy)
    {
      _energy = energy;
    }

    public void SetAttention(int attention)
    {
      _attention = attention;
    }

    public static pet Find(int searchId)
    {
      return _yourpets[searchId - 1];
    }

    // public void SetFood(string food)
    // {
    //   _food = food;
    // }

    // public void SetTime(int time)
    // {
    //   _time = time;
    // }
    //
    // public void SetActivity(string activity)
    // {
    //   _activity = activity;
    // }
    //
    // public int GetFood()
    // {
    //   return _food;
    // }
    //
    // public int GetSleep()
    // {
    //   return _sleep;
    // }
    //
    // public int GetPlay()
    // {
    //   return int _play;
    // }

    // public static tamagotchi CalEnergy(food, sleep, play, time)
    // {
    //   if (energy >= 100) {
    //     energy = 100;
    //     energy = food + sleep - play - time;
    //   }
    //   else{
    //     energy = food + sleep - play - time;
    //   }
    //   return energy;
    // }
    //
    // public static tamagotchi CalAttention(play)
    // {
    //   if (attention >= 100) {
    //     attention = 100;
    //     attention = play ;
    //   }
    //   else{
    //     attention = play;
    //   }
    //   return attention;
    // }

  }
}
