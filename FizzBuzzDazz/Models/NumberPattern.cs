namespace FizzBuzzEnterprizz.Models
{
    public class NumberPattern(
        int Number,
        string? Pattern)
    {
        public int Number { get; } = Number;
        public string? Pattern { get; } = Pattern;
        public bool HasNoPattern() => Pattern == null;
    }
}
