using FizzBuzzEnterprizz.Models;
using FizzBuzzEnterprizz.SeriesModels;

namespace FizzBuzzEnterprizz.SeriesProvider
{
    public class PreloadedSeriesProvider(
        int RequestedBufferLength,
        ISeriesProvider BaseProvider) : ISeriesProvider
    {
        // TODO RequestedBufferLength => ActualLength
        private List<NumberPattern> Buffer { get; set; } =
            BaseProvider
                .GetSeries(RequestedBufferLength)
                .GetPatterns()
                .ToList();

        public Series GetSeries() => new(GetInfiniteSequence(1));
        public Series GetSeries(int count) => new(GetRangeSequence(1, count));
        public Series GetSeries(int start, int count) => new(GetRangeSequence(start, count));

        private IEnumerable<NumberPattern> GetRangeSequence(int start, int count) => GetInfiniteSequence(start).TakeWhile(np => np.Number <= count);
        private IEnumerable<NumberPattern> GetInfiniteSequence(int start)
        {
            int number = GetStartingBufIndex(start);
            do
            {
                yield return Buffer[number];
                number = number == RequestedBufferLength
                    ? 0
                    : number + 1;
            } while ((long)number + 1L <= Int32.MaxValue);
        }
        private int GetStartingBufIndex(int number) => (number - 1) % Buffer.Count;
    }
}
