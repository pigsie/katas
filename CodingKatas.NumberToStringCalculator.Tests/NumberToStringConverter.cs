namespace CodingKatas.NumberToStringCalculator.Tests
{
    public class NumberToStringConverter
    {
        public string Convert(int numberToConvert)
        {
            //TODO use a factory
            if (numberToConvert < 10)
            {
                var unit = new Unit(numberToConvert);
                return unit.AsString();
            }

            if (numberToConvert > 10 && numberToConvert < 20)
            {
                var teen = new Teen(numberToConvert);
                return teen.AsString();
            }

            if (numberToConvert >= 20 && numberToConvert < 100)
            {
                var doubleDigit = new DoubleDigit(numberToConvert);
                return doubleDigit.AsString();
            }
            
            return string.Empty;
        }
    }
}