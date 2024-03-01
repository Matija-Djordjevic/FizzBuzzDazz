using FizzBuzzEnterprizz.Models;
using FizzBuzzEnterprizz.SeriesModels;

namespace FizzBuzzDazz.SeriesModels
{
    public class NoPatternsSeries(ISeries Other) : ISeries
    {
        public IEnumerable<NumberPattern> GetPatterns() =>
            Other
                .GetPatterns()
                .Where(np => np.HasNoPattern());
    }
}
