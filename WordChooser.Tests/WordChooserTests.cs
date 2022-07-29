using System;
using NUnit.Framework;
using NSubstitute;

namespace WordGame;

public class WordChooserTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WordChooser_GetRandomWordFromDictionary_ReturnsRandomWord()
    {
        Random fakeRand = Substitute.For<Random>();
        fakeRand.Next(Arg.Any<int>()).Returns(0);
        
        WordChooser wordChooser = new WordChooser(fakeRand);
        Assert.That(wordChooser.GetRandomWordFromDictionary(), Is.EqualTo("MAKERS"));
    }
}
