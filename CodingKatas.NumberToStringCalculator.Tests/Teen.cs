using System.Linq;

namespace CodingKatas.NumberToStringCalculator.Tests
{
    public class Teen : UnitBase
    {
        private readonly int _numberAsNumber;
        private readonly string _numberAsString;

        public Teen(string numberAsString)
        {
            _numberAsString = numberAsString.ToLower();
            PopulateLookup();
        }

        public Teen(int numberAsNumber)
        {
            _numberAsNumber = numberAsNumber;
            PopulateLookup();
        }

        public override int AsInt()
        {
            return _teens[_numberAsString];
        }

        public override string AsString()
        {
            var item = _teens.Single(x => x.Value == _numberAsNumber);
            return item.Key;
        }

        protected override void PopulateLookup()
        {
            _teens["ten"] = 10;
            _teens["eleven"] = 11;
            _teens["twelve"] = 12;
            _teens["thirteen"] = 13;
            _teens["fourteen"] = 14;
            _teens["fifteen"] = 15;
            _teens["sixteen"] = 16;
            _teens["seventeen"] = 17;
            _teens["eightteen"] = 18;
            _teens["nineteen"] = 19;
        }

    }
}