using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player who always roles one higher than the other player
  public class OneHigherPlayer : Player
  {
    public override void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      int otherRoll = other.Roll();
      int myRoll;

      if (other.DiceSize == otherRoll)
      {
        myRoll = otherRoll;
      }
      else
      {
        myRoll = otherRoll + 1;
      }

      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} Wins!");
      }
      else if (myRoll < otherRoll)
      {
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