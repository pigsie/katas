using System;
using System.Linq;

namespace CodingKatas.NumberToStringCalculator.Tests
{
    public class DoubleDigit : UnitBase
    {
        private readonly int _numberAsNumber;
        private readonly string _numberAsString;

        public DoubleDigit(string numberAsString)
        {
            _numberAsString = numberAsString.ToLower();
            PopulateLookup();
        }

        public DoubleDigit(int numberAsNumber)
        {
            _numberAsNumber = numberAsNumber;
            PopulateLookup();
        }

        public override int AsInt()
        {
            return _tens[_numberAsString];
        }

        public override string AsString()
        {
            var tens = _tens.Single(x => Math.Floor((decimal) (_numberAsNumber / x.Value)) == 1).Key;
            var units  =  new Unit(_numberAsNumber % 10).AsString(); 
            return tens + " " + units;
        }

        protected override void PopulateLookup()
        {
            _tens["twenty"] = 20;
            _tens["thirty"] = 30;
            _tens["fourty"] = 40;
            _tens["fifty"] = 50;
            _tens["sixty"] = 60;
            _tens["seventy"] = 70;
            _tens["eighty"] = 80;
            _tens["ninety"] = 90;
        }
    }
}