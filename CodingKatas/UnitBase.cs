using System.Collections.Generic;

namespace CodingKatas
{
    public abstract class UnitBase
    {
        protected readonly Dictionary<string, int> _units = new Dictionary<string, int>();
        protected readonly Dictionary<string, int> _teens = new Dictionary<string, int>();
        protected readonly Dictionary<string, int> _tens = new Dictionary<string, int>();

        public abstract int AsInt();
        public abstract string AsString();
        protected abstract void PopulateLookup();
    }
}