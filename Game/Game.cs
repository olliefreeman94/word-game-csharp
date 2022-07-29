using System.Text;

namespace WordGame;

public class Game
{
  private string _hiddenWord;
  private int _attempts = 10;
  private readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};

  public Game()
  {
    this._hiddenWord = GetRandomWordFromDictionary();
  }
  public Game(string givenWord)
  {
    this._hiddenWord = givenWord;
  }
  public string GetWordToGuess()
  {
    StringBuilder builder = new StringBuilder();
    for (int i = 0; i < this._hiddenWord.Length; i++)
    {
      char currentLetter = this._hiddenWord[i];
      if (i == 0)
      {
        builder.Append(currentLetter);
      }
      else
      {
        builder.Append("_");
      }
    }
    return builder.ToString();
  }

  public int GetRemainingAttempts()
  {
    return this._attempts;
  }

  private string GetRandomWordFromDictionary()
  {
    Random rnd = new Random();
    return DICTIONARY[rnd.Next(DICTIONARY.Length)];
  }
}
