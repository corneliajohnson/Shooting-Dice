using System;
using System.Collections.Generic;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player who shouts a taunt every time they roll dice
  public class SmackTalkingPlayer : Player
  {
    public void NewTaunt()
    {
      List<string> tauntStrings = new List<string>(){
            "Here come the boom!", "You aint got nothing on me!", "If your not first you're last!", "I'm like that!"
        };
      Random randomTaunt = new Random();
      int index = randomTaunt.Next(tauntStrings.Count);
      Console.WriteLine($"{Name}:  {tauntStrings[index]}");
    }
  }
}