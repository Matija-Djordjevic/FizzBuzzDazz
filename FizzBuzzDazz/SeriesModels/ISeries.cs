using FizzBuzzEnterprizz.Models;

namespace FizzBuzzEnterprizz.SeriesModels
{
    public interface ISeries
    {
        IEnumerable<NumberPattern> GetPatterns();
    }
}
