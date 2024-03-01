namespace FizzBuzzEnterprizz.Models
{
    public class Transformation(
        int Divisor,
        string Correspondent)
    {
        public int Divisor { get; } = Divisor < 1 ? throw new ArgumentException($"{nameof(Divisor)} must be greater or equal to 0")
            : Divisor;
        public string Correspondent { get; } = Correspondent;
        public string? TryTransformNumber(int number) => number % Divisor == 0 ? Correspondent : null;
    }
}
