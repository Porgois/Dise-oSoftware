using FluentAssertions;

namespace RomanNumerals.UnitTests;

public class RomanNumeralsConverterTests
{
    [SetUp]
    public void Setup(){}

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    [TestCase(8, "VIII")]
    [TestCase(9, "IX")]
    [TestCase(10, "X")]
    [TestCase(11, "XI")]
    [TestCase(12, "XII")]
    [TestCase(13, "XIII")]
    [TestCase(14, "XIV")]
    [TestCase(15, "XV")]
    [TestCase(20, "XX")]
    [TestCase(29, "XXIX")]
    [TestCase(30, "XXX")]
    [TestCase(40, "XL")]
    [TestCase(50, "L")]
    [TestCase(60, "LX")]
    [TestCase(70, "LXX")]
    [TestCase(80, "LXXX")]
    [TestCase(90, "XC")]
    [TestCase(100, "C")]
    [TestCase(294, "CCXCIV")]
    [TestCase(2019, "MMXIX")]

    public void Convert_WhenArabicNumberIsPassed_ReturnsRomanNumber(int numberArabic, string numberRoman)
    {
        var result = RomanNumeralsConverter.Translate(numberArabic);
        result.Should().Be(numberRoman);
    }
}
