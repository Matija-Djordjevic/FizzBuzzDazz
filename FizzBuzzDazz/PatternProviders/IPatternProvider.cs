using FizzBuzzEnterprizz.Models;

namespace FizzBuzzEnterprizz.PatternProviders
{
    public interface IPatternProvider
    {
        NumberPattern GetPattern(int number);
    }
}
