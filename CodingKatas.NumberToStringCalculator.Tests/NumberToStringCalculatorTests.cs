using FluentAssertions;
using NUnit.Framework;

namespace CodingKatas.NumberToStringCalculator.Tests
{
    [TestFixture]
    public class NumberToStringCalculatorTests
    {
        [Test]
        public void ConvertSingleNumberToString()
        {
            var converter = new NumberToStringConverter();

            var convertedNumber = converter.Convert(1);

            convertedNumber.Should().Be("one");
        }

        [Test]
        public void ConvertsTwoDigitNumberLessThanTwentyToString()
        {
            var converter = new NumberToStringConverter();

            var convertedNumber = converter.Convert(12);

            convertedNumber.Should().Be("twelve");
        }

        [TestCase(23, ExpectedResult = "twenty three")]
        [TestCase(35, ExpectedResult = "thirty five")]
        [TestCase(47, ExpectedResult = "fourty seven")]
        [TestCase(51, ExpectedResult = "fifty one")]
        [TestCase(69, ExpectedResult = "sixty nine")]
        [TestCase(78, ExpectedResult = "seventy eight")]
        [TestCase(84, ExpectedResult = "eighty four")]
        [TestCase(92, ExpectedResult = "ninety two")]
        [TestCase(96, ExpectedResult = "ninety six")]
        public string ConvertsTwoDigitNumberMoreThanTwentyToString(int numberToConvert)
        {
            var converter = new NumberToStringConverter();

            var convertedNumber = converter.Convert(numberToConvert);

            return convertedNumber;
        }

    }
};