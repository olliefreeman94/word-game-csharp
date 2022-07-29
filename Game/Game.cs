using System.Text;

namespace WordGame;

public class Game
{
  private WordChooser _chooser = new WordChooser();
  private string _hiddenWord;
  private int _attempts = 10;

  public Game()
  {
    this._hiddenWord = this._chooser.GetRandomWordFromDictionary();
  }

  public Game(string givenWord)
  {
    this._hiddenWord = givenWord;
  }

  public Game(WordChooser chooser)
  {
    this._chooser = chooser;
    this._hiddenWord = _chooser.GetRandomWordFromDictionary();
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

}
