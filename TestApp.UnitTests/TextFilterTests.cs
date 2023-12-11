using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { "frog", "horse" };
        string input = "The dog and cat are animals.";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo("The dog and cat are animals."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "dog", "cat" };
        string input = "The dog and cat are animals.";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo("The *** and *** are animals."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { };
        string input = "The dog and cat are animals.";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo("The dog and cat are animals."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { "dog", "cat", " " };
        string input = "The dog and cat are animals.";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo("The*****and*****are*animals."));
    }
}
