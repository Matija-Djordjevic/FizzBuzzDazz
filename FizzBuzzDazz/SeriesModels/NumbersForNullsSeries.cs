using FizzBuzzEnterprizz.Models;

namespace FizzBuzzEnterprizz.SeriesModels
{
    public class NumbersForNullsSeries(ISeries Other) : ISeries
    {
        public IEnumerable<NumberPattern> GetPatterns() => 
            Other
                .GetPatterns()
                .Select(np => np.HasNoPattern()
                    ? new NumberPattern(np.Number, np.Number.ToString())
                    : np);
    }
}
