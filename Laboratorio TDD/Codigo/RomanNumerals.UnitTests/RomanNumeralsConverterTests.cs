using FluentAssertions;

namespace RomanNumerals.UnitTests;

public class RomanNumeralsConverterTests
{
    [SetUp]
    public void Setup(){
    }

    [Test]
    public void Convert_WhenNumber1IsPassed_ReturnsI() {
        var result = RomanNumeralsConverter.Translate(3);
        result.Should().Be("III");
    }
}
