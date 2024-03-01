using FizzBuzzEnterprizz.Models;
using FizzBuzzEnterprizz.SeriesModels;

namespace FizzBuzzDazz.SeriesModels
{
    public class StrForNullSeries(string Word, ISeries Other) : ISeries
    {
        public IEnumerable<NumberPattern> GetPatterns() =>
            Other
                .GetPatterns()
                .Select(np => np.HasNoPattern()
                    ? new NumberPattern(np.Number, Word)
                    : np);
    }
}
