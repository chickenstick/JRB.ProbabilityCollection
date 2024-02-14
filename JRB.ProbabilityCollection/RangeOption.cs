using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRB.ProbabilityCollection
{
    public class RangeOption<T>
    {

        internal RangeOption(IntRange range, T item)
        {
            this.Range = range;
            this.Item = item;
        }

        internal RangeOption(int lowerInclusive, int upperExclusive, T item)
            : this(new IntRange(lowerInclusive, upperExclusive), item)
        {
        }

        public IntRange Range { get; private set; }
        public T Item { get; private set; }

        public override string ToString()
        {
            return $"{Range} | {Item}";
        }

    }
}
