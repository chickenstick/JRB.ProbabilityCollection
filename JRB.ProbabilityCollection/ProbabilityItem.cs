using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRB.ProbabilityCollection
{
    public class ProbabilityItem<T>
    {

        public ProbabilityItem(int probability, T item)
        {
            this.Probability = probability;
            this.Item = item;
        }

        public int Probability { get; set; }
        public T Item { get; set; }

    }
}
