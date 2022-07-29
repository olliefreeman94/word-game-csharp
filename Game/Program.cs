using System.Text;

namespace WordGame;

internal class Program
{
  static void Main(string[] args)
  {
    Game game = new Game();
    System.Console.WriteLine("Welcome! Today the word to guess is:");
    System.Console.WriteLine(game.GetWordToGuess());
    System.Console.WriteLine($"You have {game.GetRemainingAttempts()} attempts remaining. Enter one letter to guess:");
  }
}
