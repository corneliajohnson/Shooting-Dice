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
      Result(other, myRoll, otherRoll);
    }
  }
}