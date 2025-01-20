using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRB.ProbabilityCollection
{
    public sealed class ProbabilityCollection<T> : IEnumerable<RangeOption<T>>
    {

        #region - Constants -

        private const int ALL_LOWER_INCLUSIVE = 0;

        #endregion

        #region - Fields -

        private int _allUpperExclusive;
        private List<RangeOption<T>> _options;

        #endregion

        #region - Constructor -

        public ProbabilityCollection()
        {
            _allUpperExclusive = ALL_LOWER_INCLUSIVE;
            _options = new List<RangeOption<T>>();
        }

        #endregion

        #region - Methods -

        public void Add(int probability, T item)
        {
            int minInclusive = _allUpperExclusive;
            _allUpperExclusive = minInclusive + probability;

            RangeOption<T> option = new RangeOption<T>(minInclusive, _allUpperExclusive, item);
            _options.Add(option);
        }

        public void Add(ProbabilityItem<T> probabilityItem) => Add(probabilityItem.Probability, probabilityItem.Item);

        public T GetRandom(Random random)
        {
            int index = random.Next(ALL_LOWER_INCLUSIVE, _allUpperExclusive);
            return _options.Where(o => o.Range.IsInRange(index)).Select(o => o.Item).Single();
        }

        public IEnumerator<RangeOption<T>> GetEnumerator()
        {
            foreach (RangeOption<T> obj in _options)
                yield return obj;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

    }
}
