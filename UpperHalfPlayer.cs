using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player whose role will always be in the upper half of their possible rolls
  public class UpperHalfPlayer : Player
  {
    public override void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      int otherRoll = other.Roll();
      int myRoll = new Random().Next(DiceSize / 2, DiceSize + 1);
      Result(other, myRoll, otherRoll);
    }
  }
}