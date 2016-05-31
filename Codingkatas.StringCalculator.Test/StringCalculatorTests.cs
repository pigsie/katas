using FluentAssertions;
using NUnit.Framework;

namespace Codingkatas.StringCalculator.Test
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private CodingKatas.StringCalculator _calculator;

        [SetUp]
        public void RunsBeforeEachMethod()
        {
            _calculator = new CodingKatas.StringCalculator();
        }

        [Test]
        public void ReturnsZeroWhenStringIsEmpty()
        {
            var convertedNumber = _calculator.Add(string.Empty);

            convertedNumber.Should().Be(0);
        }

        [TestCase("one", ExpectedResult = 1)]
        [TestCase("two", ExpectedResult = 2)]
        [TestCase("three", ExpectedResult = 3)]
        [TestCase("four", ExpectedResult = 4)]
        [TestCase("five", ExpectedResult = 5)]
        [TestCase("six", ExpectedResult = 6)]
        [TestCase("seven", ExpectedResult = 7)]
        [TestCase("eight", ExpectedResult = 8)]
        [TestCase("nine", ExpectedResult = 9)]
        public int ReturnsStringAsNumberWhenStringIsAUnitValue(string unitToConvert)
        {
            var convertedNumber = _calculator.Add(unitToConvert);

            return convertedNumber;
        }

        [Test]
        public void Returns3WhenStringIsTwoNumbersWhichAddUpToThree()
        {
            var convertedNumber = _calculator.Add("one,two");

            convertedNumber.Should().Be(3);
        }
    }
}
