using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = new string[] { "hello" };
        // Act
        string reslt = RepeatStrings.Repeat(input);

        // Assert
        Assert.That (reslt, Is.EqualTo("hellohellohellohellohello"));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = new string[] { "hello", "son" };
        // Act
        string reslt = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(reslt, Is.EqualTo("hellohellohellohellohellosonsonson"));
    }
}
