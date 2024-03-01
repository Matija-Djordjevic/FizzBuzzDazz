using FizzBuzzEnterprizz.Models;
using FizzBuzzEnterprizz.PatternProviders;
using FizzBuzzEnterprizz.SeriesModels;

namespace FizzBuzzEnterprizz.SeriesProvider
{
    public class SeriesProvider(IPatternProvider Provider) : ISeriesProvider
    {
        public Series GetSeries() => new(GetInfiniteSequence(1));
        public Series GetSeries(int count) => new(GetRangeSequence(1, count));
        public Series GetSeries(int start, int count) => new(GetRangeSequence(start, count));

        private IEnumerable<NumberPattern> GetRangeSequence(int start, int count) => GetInfiniteSequence(start).TakeWhile(np => np.Number <= count);
        private IEnumerable<NumberPattern> GetInfiniteSequence(int start)
        {
            int number = start;
            do
            {
                yield return Provider.GetPattern(number++);
            } while ((long)number + 1L <= Int32.MaxValue);
        }
    }
}
