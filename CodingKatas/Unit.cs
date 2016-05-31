using System.Linq;

namespace CodingKatas
{
    public class Unit : UnitBase
    {
        private readonly int _numberAsNumber;
        private readonly string _numberAsString;

        public Unit(string numberAsString)
        {
            _numberAsString = numberAsString.ToLower();
            PopulateLookup();
        }

        public Unit(int numberAsNumber)
        {
            _numberAsNumber = numberAsNumber;
            PopulateLookup();
        }

        public override int AsInt()
        {
            return _units[_numberAsString];
        }

        public override string AsString()
        {
            var item = _units.Single(x => x.Value == _numberAsNumber);
            return item.Key;
        }

        protected override void PopulateLookup()
        {
            _units["one"] = 1;
            _units["two"] = 2;
            _units["three"] = 3;
            _units["four"] = 4;
            _units["five"] = 5;
            _units["six"] = 6;
            _units["seven"] = 7;
            _units["eight"] = 8;
            _units["nine"] = 9;
        }


    }
}