using FizzBuzzEnterprizz.Models;

namespace FizzBuzzEnterprizz.SeriesModels
{
    public class NoNullsSeries(ISeries Other) : ISeries
    {
        public IEnumerable<NumberPattern> GetPatterns() => 
            Other
                .GetPatterns()
                .Where(np => !np.HasNoPattern());
    }
}
