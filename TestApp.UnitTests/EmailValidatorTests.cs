using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("someMail123@mail.com")]
    [TestCase("john.smith@gmail.bg")]
    [TestCase("funny-Bunny86@yahoo.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("someMail123@mail.c")]
    [TestCase("john.smith+gmail.bg")]
    [TestCase("funny-Bunny86@com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
