using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A player the prompts the user to enter a number for a roll
  public class HumanPlayer : Player
  {
    public override void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      Console.Write($"Enter a nember between 1 and {DiceSize}:   ");

      int myRoll = int.Parse(Console.ReadLine());

      int otherRoll = other.Roll();

      Result(other, myRoll, otherRoll);
    }

  }
}