using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player who always rolls in the upper half of their possible role and
  //  who throws an exception when they lose to the other player
  public class SoreLoserUpperHalfPlayer : UpperHalfPlayer
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