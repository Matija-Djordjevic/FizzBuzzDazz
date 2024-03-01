using FizzBuzzEnterprizz.Models;

namespace FizzBuzzEnterprizz.SeriesModels
{
    public class Series(
        IEnumerable<NumberPattern> Patterns) : ISeries 
    {
        private IEnumerable<NumberPattern> Patterns { get; } = Patterns;

        public IEnumerable<NumberPattern> GetPatterns() => Patterns;
    }
}
