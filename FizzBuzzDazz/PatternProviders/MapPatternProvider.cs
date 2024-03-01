using System.Text;
using FizzBuzzEnterprizz.Extensions;
using FizzBuzzEnterprizz.Models;

namespace FizzBuzzEnterprizz.PatternProviders
{
    public class MapPatternProvider(IEnumerable<Transformation> Transformations) : IPatternProvider
    {
        private List<Transformation> Transformations { get; } = Transformations.ToList();

        public NumberPattern GetPattern(int number) => new(
                number,
                GetCorrespondents(number)?.ToString());
        private StringBuilder? GetCorrespondents(int number) =>
            new StringBuilder()
                .AppendJoin(string.Empty, GetCorrespondentsSequence(number))
                .NullIfEmpty();
        private IEnumerable<string?> GetCorrespondentsSequence(int number) =>
            Transformations
                .Select(t => t.TryTransformNumber(number));
    }
}
