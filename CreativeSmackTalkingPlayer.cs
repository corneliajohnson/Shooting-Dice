using System;
using System.Collections.Generic;

namespace ShootingDice
{
  // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
  public class CreativeSmackTalkingPlayer : Player
  {
    public CreativeSmackTalkingPlayer()
    {
      List<string> tauntStrings = new List<string>(){
            "Here come the boom!", "You aint got nothing on me!", "If your not first you're last!", "I'm like that!"
        };
      Random randomTaunt = new Random();
      int index = randomTaunt.Next(tauntStrings.Count);
      Console.WriteLine(tauntStrings[index]);
    }
  }
}