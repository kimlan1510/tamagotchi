using System.Collections.Generic;
namespace tamagotchi.Objects
{
  public class tamagotchi
  {
    private string _name;
    private string _food;
    private int _time;
    private string _activity;
    private int energy = 70;
    private int attention = 70;
    public food(string foodType, int time)
    {
      SetFood(foodType);
      SetTime(time);
    }

    public play(string activity, int time)
    {
      SetActivity(activity);
      SetTime(time);
    }

    public sleep(int time)
    {
      SetTime(time);
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name){
      _name = name;
    }
    public string GetFood()
    {
      return _food;
    }

    public int GetTime()
    {
      return _time;
    }

    public string GetActivity()
    {
      return _activity;
    }

    public void SetFood(string food)
    {
      _food = food;
    }

    public void SetTime(int time)
    {
      _time = time;
    }

    public void SetActivity(string activity)
    {
      _activity = activity;
    }

    public tamagotchi(string name)
    {
      SetName(name);

    }
    public int GetFood()
    {
      return _food;
    }

    public int GetSleep()
    {
      return _sleep;
    }

    public int GetPlay()
    {
      return int _play;
    }

    public static tamagotchi CalEnergy(food, sleep, play, time)
    {
      if (energy >= 100) {
        energy = 100;
        energy = food + sleep - play - time;
      }
      else{
        energy = food + sleep - play - time;
      }
      return energy;
    }

    public static tamagotchi CalAttention(play)
    {
      if (attention >= 100) {
        attention = 100;
        attention = play ;
      }
      else{
        attention = play;
      }
      return attention;
    }

    public static tamagotchi TimeCountDown()
  }
}
