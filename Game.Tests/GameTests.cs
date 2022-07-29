using NSubstitute;

namespace WordGame;

public class GameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
      Game game = new Game("MAKERS");
      Assert.That(game.GetWordToGuess(), Is.EqualTo("M_____"));
    }

    [Test]
    public void Game_GetWordToGuess_ReturnsRandomWordToGuess()
    {
      WordChooser fakeChooser = Substitute.For<WordChooser>();
      fakeChooser.GetRandomWordFromDictionary().Returns("MAKERS");

      Game game = new Game(fakeChooser);
      Assert.That(game.GetWordToGuess(), Is.EqualTo("M_____"));
    }

    [Test]
    public void Game_GetRemainingAttempts_ReturnsRemainingAttempts()
    {
      Game game = new Game("MAKERS");
      Assert.That(game.GetRemainingAttempts(), Is.EqualTo(10));
    }
}
