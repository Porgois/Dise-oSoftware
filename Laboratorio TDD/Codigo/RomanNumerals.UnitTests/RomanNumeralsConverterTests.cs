using FluentAssertions;

namespace RomanNumerals.UnitTests;

public class RomanNumeralsConverterTests
{
    [SetUp]
    public void Setup(){
    }

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    [TestCase(8, "VIII")]
    [TestCase(9, "IX")]
    public void Convert_WhenArabicNumberIsPassed_ReturnsRomanNumber(int numberArabic, string numberRoman)
    {
        var result = RomanNumeralsConverter.Translate(numberArabic);
        result.Should().Be(numberRoman);
    }
}
