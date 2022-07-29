namespace WordGame;

public class WordChooser
{
  private Random _rand;
  private readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};

  public WordChooser()
  {
    this._rand = new Random();
  }
  
  public WordChooser(Random rand)
  {
    this._rand = rand;
  }

  public virtual string GetRandomWordFromDictionary()
  {
    return DICTIONARY[this._rand.Next(DICTIONARY.Length)];
  }
}
