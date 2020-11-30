using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player that throws an exception when they lose to the other player
  // Where might you catch this exception????
  public class SoreLoserPlayer : Player
  {

    public override void Result(Player other, int myRoll, int otherRoll)
    {
      Console.WriteLine($"{Name} rolls a {myRoll}");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");
      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} Wins!");
      }
      else if (myRoll < otherRoll)
      {
        Console.WriteLine("Not Again");
        Console.WriteLine($"{other.Name} Wins!");
      }
      else
      {
        // if the rolls are equal it's a tie
        Console.WriteLine("It's a tie");
      }
    }



  }
}