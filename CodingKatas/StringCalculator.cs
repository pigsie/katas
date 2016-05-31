using System.Collections.Generic;
using System.Linq;

namespace CodingKatas
{
    public class StringCalculator
    {
        public int Add(string numberAsString)
        {
            if (numberAsString.Equals(string.Empty)) return 0;

            var arguments = numberAsString.Split(',');

            var sum = arguments.Sum(x => new Unit(x).AsInt());

            return sum;
        }
    }
}
