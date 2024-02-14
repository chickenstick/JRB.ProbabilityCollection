using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRB.ProbabilityCollection
{
    public class IntRange
    {

        internal IntRange(int lowerInclusive, int upperExclusive)
        {
            this.LowerInclusive = lowerInclusive;
            this.UpperExclusive = upperExclusive;
        }

        public int LowerInclusive { get; private set; }
        public int UpperExclusive { get; private set; }

        public bool IsInRange(int value) => this.LowerInclusive <= value && value < this.UpperExclusive;

        public override string ToString()
        {
            return $"({LowerInclusive} - {UpperExclusive})";
        }

    }
}
