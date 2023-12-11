using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new ();

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "Some text for the exercise";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Some text for the exercise with url https://www.google.com";
        List<string> expected = new() { "https://www.google.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Mutiple urls in text https://www.google.com, http://facebook.com/home, https://somesite.org";
        List<string> expected = new() { "https://www.google.com", "http://facebook.com", "https://somesite.org" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Mutiple urls in text \"https://www.google.com\" and \"https://www.facebook.com\"";
        List<string> expected = new() { "https://www.google.com", "https://www.facebook.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
