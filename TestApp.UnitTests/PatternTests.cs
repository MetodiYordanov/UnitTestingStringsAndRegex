using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("The dog is big.", 2, "tHe dOg iS BiG.tHe dOg iS BiG.")]
    [TestCase("Cat's name is Jake.", 1, "cAt's nAmE Is jAkE.")]
    //[TestCase()]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 2;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => { Pattern.GeneratePatternedString(input, repetitionFactor); });
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = -2;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => { Pattern.GeneratePatternedString(input, repetitionFactor); });
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 0;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => { Pattern.GeneratePatternedString(input, repetitionFactor); });
    }
}
